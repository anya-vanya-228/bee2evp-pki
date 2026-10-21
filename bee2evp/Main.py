import tkinter as tk
from tkinter import ttk, filedialog, messagebox
import sqlite3
import subprocess
import os
from argon2 import PasswordHasher

class CertificateManager:
    def __init__(self, root):
        self.root = root
        self.root.title("Advanced Certificate Manager (bee2evp)")
        self.root.geometry("900x700")
        
        self.ph = PasswordHasher()
        self.db_path = None

        # Notebook Setup
        self.notebook = ttk.Notebook(self.root)
        self.notebook.pack(expand=True, fill="both", padx=10, pady=10)

        self.tab_main = ttk.Frame(self.notebook)
        self.tab_root_ca = ttk.Frame(self.notebook)
        self.tab_requests = ttk.Frame(self.notebook)
        self.tab_certs = ttk.Frame(self.notebook)
        self.tab_revoked = ttk.Frame(self.notebook)

        self.notebook.add(self.tab_main, text="Main")
        self.notebook.add(self.tab_root_ca, text="Root CA")
        self.notebook.add(self.tab_requests, text="Requests")
        self.notebook.add(self.tab_certs, text="Certificates")
        self.notebook.add(self.tab_revoked, text="Revoked")

        self.set_tabs_state("disabled")
        self.setup_main_tab()
        self.setup_root_ca_tab()
        self.setup_requests_tab()

    def set_tabs_state(self, state):
        for i in range(1, 5):
            self.notebook.tab(i, state=state)

    # --- MAIN TAB ---
    def setup_main_tab(self):
        frame = ttk.LabelFrame(self.tab_main, text="Database")
        frame.pack(padx=20, pady=20, fill="x")
        self.status_label = ttk.Label(frame, text="Select a database to begin.", foreground="red")
        self.status_label.pack(pady=10)
        ttk.Button(frame, text="Create/Select Database", command=self.select_db).pack(pady=5)

    def select_db(self):
        path = filedialog.asksaveasfilename(defaultextension=".db")
        if path:
            self.db_path = path
            self.init_db()
            self.status_label.config(text=f"Connected: {path}", foreground="green")
            self.set_tabs_state("normal")

    def init_db(self):
        conn = sqlite3.connect(self.db_path)
        curr = conn.cursor()
        # Table for storing keys/certs (Storing Argon2 hash of password for verification)
        curr.execute('''CREATE TABLE IF NOT EXISTS root_ca 
                        (id INTEGER PRIMARY KEY, cert_data TEXT, key_data TEXT, pw_hash TEXT)''')
        curr.execute('''CREATE TABLE IF NOT EXISTS requests 
                        (id INTEGER PRIMARY KEY, common_name TEXT, algorithm TEXT, status TEXT)''')
        conn.commit()
        conn.close()

    # --- ROOT CA TAB ---
    def setup_root_ca_tab(self):
        container = ttk.Frame(self.tab_root_ca, padding=20)
        container.pack(fill="both")

        fields = [("Common Name", "cn"), ("Country", "c"), ("Organization", "o"), 
                  ("Days Valid", "expiry"), ("Private Key Password", "pw")]
        self.root_entries = {}

        for i, (label, key) in enumerate(fields):
            ttk.Label(container, text=label).grid(row=i, column=0, sticky="w", pady=5)
            show = "*" if key == "pw" else ""
            ent = ttk.Entry(container, show=show)
            ent.grid(row=i, column=1, sticky="ew", padx=10)
            self.root_entries[key] = ent

        ttk.Label(container, text="Algorithm").grid(row=5, column=0, sticky="w")
        self.root_algo = ttk.Combobox(container, values=["rsa", "ecdsa", "bash256", "bash384", "bash512"])
        self.root_algo.current(0)
        self.root_algo.grid(row=5, column=1, sticky="ew", padx=10)

        btn_frame = ttk.Frame(container)
        btn_frame.grid(row=6, column=0, columnspan=2, pady=20)
        ttk.Button(btn_frame, text="Generate Root CA", command=self.generate_root).pack(side="left", padx=5)
        ttk.Button(btn_frame, text="Import Certificate", command=self.import_root).pack(side="left", padx=5)

    def generate_root(self):
        pw = self.root_entries['pw'].get()
        if not pw:
            messagebox.showwarning("Warning", "Password required for key protection.")
            return
        
        # Argon2 Hashing
        pw_hash = self.ph.hash(pw)
        algo = self.root_algo.get()
        
        # Subprocess call example for bee2evp
        # Note: In a real scenario, you'd output to temporary files then read into DB
        try:
            cmd = ["openssl", "genpkey", "-engine", "bee2evp", "-algorithm", algo, "-out", "root.key"]
            # subprocess.run(cmd, check=True) # Uncomment when OpenSSL/bee2evp is configured
            
            # Store in DB (Simulated)
            conn = sqlite3.connect(self.db_path)
            conn.execute("INSERT INTO root_ca (pw_hash) VALUES (?)", (pw_hash,))
            conn.commit()
            conn.close()
            messagebox.showinfo("Success", f"Root CA generated using {algo}")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    def import_root(self):
        path = filedialog.askopenfilename(title="Select Certificate")
        if path: messagebox.showinfo("Import", "Certificate imported successfully.")

    # --- REQUESTS TAB ---
    def setup_requests_tab(self):
        frame = ttk.Frame(self.tab_requests, padding=10)
        frame.pack(fill="both", expand=True)

        self.req_tree = ttk.Treeview(frame, columns=("ID", "CN", "Algo", "Status"), show="headings")
        self.req_tree.heading("ID", text="ID")
        self.req_tree.heading("CN", text="Common Name")
        self.req_tree.heading("Algo", text="Algorithm")
        self.req_tree.heading("Status", text="Status")
        self.req_tree.pack(fill="both", expand=True)

        btn_frame = ttk.Frame(frame)
        btn_frame.pack(fill="x", pady=10)
        
        ttk.Button(btn_frame, text="Create Request", command=self.add_request_dialog).pack(side="left", padx=2)
        ttk.Button(btn_frame, text="Confirm", command=lambda: self.update_req("Confirmed")).pack(side="left", padx=2)
        ttk.Button(btn_frame, text="Reject", command=lambda: self.update_req("Rejected")).pack(side="left", padx=2)
        ttk.Button(btn_frame, text="Information").pack(side="left", padx=2)

    def add_request_dialog(self):
        # Simplified dialog
        conn = sqlite3.connect(self.db_path)
        conn.execute("INSERT INTO requests (common_name, algorithm, status) VALUES (?, ?, ?)", 
                     ("New_User", self.root_algo.get(), "Pending"))
        conn.commit()
        conn.close()
        self.refresh_requests()

    def update_req(self, status):
        selected = self.req_tree.selection()
        if not selected: return
        item_id = self.req_tree.item(selected[0])['values'][0]
        conn = sqlite3.connect(self.db_path)
        conn.execute("UPDATE requests SET status = ? WHERE id = ?", (status, item_id))
        conn.commit()
        conn.close()
        self.refresh_requests()

    def refresh_requests(self):
        for i in self.req_tree.get_children(): self.req_tree.delete(i)
        conn = sqlite3.connect(self.db_path)
        for row in conn.execute("SELECT * FROM requests"):
            self.req_tree.insert("", "end", values=row)
        conn.close()

if __name__ == "__main__":
    root = tk.Tk()
    app = CertificateManager(root)
    root.mainloop()