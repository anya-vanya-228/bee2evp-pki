using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{

    public partial class mainWindow : Form
    {
        private string _dbPath = string.Empty;
        public mainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "SQLite Database|*.db;*.sqlite";
                sfd.Title = "Создать новую базу данных";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _dbPath = sfd.FileName;

                    SQLiteConnection.CreateFile(_dbPath);
                    using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
                    {
                        connection.Open();
                        string sql = @"
                            CREATE TABLE Certificates (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT,
                                ORG TEXT,
                                MAIL TEXT,
                                CITY TEXT,
                                TOWN TEXT,
                                CertDer BLOB,
                                CertPfx BLOB,
                                CreatedAt TEXT,
                                Password TEXT,
                                IsCA INTEGER DEFAULT 0
                            );
                            CREATE TABLE CA (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT,
                                ORG TEXT,
                                MAIL TEXT,
                                CITY TEXT,
                                TOWN TEXT,
                                CertDer BLOB,
                                CertPfx BLOB,
                                CreatedAt TEXT
                            );
                            CREATE TABLE REWOKED (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT,
                                CertDer BLOB,
                                CertPfx BLOB,
                                CreatedAt TEXT,
                                Reason TEXT
                            );
                            CREATE TABLE REQ (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT,
                                ORG TEXT,
                                MAIL TEXT,
                                CITY TEXT,
                                TOWN TEXT,
                                CertDer BLOB,
                                CertPfx BLOB,
                                CreatedAt TEXT
                            );";
                        SQLiteCommand command = new SQLiteCommand(sql, connection);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("База данных успешно создана!", "Готово");
                    UpdateMenuState();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQLite Database|*.db;*.sqlite";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _dbPath = ofd.FileName;
                UpdateMenuState();
                MessageBox.Show("База данных подключена.", "Успех");
            }
        }
        private void UpdateMenuState()
        {

            if (!string.IsNullOrEmpty(_dbPath))
            {
                this.Text = $"Менеджер сертификатов - {_dbPath}";
            }
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            MainCA form = new MainCA(_dbPath);
            form.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CertsA form2 = new CertsA(_dbPath);
            form2.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Request_Click(object sender, EventArgs e)
        {
            Req form1 = new Req(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void recalled_Click(object sender, EventArgs e)
        {
            revoked1 form1 = new revoked1(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
