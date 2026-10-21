using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Сертификат : Form
    {
        private void RunCommand(string command, string workingDir)
        {
            var process = new Process();
            process.StartInfo.FileName = "openssl.exe";
            process.StartInfo.Arguments = command;
            process.StartInfo.WorkingDirectory = workingDir;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (process.ExitCode != 0)
                throw new Exception("Ошибка:\n" + error);
        }
        private string AskPassword()
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите пароль (минимум 6 символов)",
                "Пароль",
                "");

            if (password.Length < 6)
                throw new Exception("Пароль слишком короткий");

            return password;
        }
        private bool ValidateFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                    return false;
            }

            return true;
        }
        private string _dbPath;
        public Сертификат(string dbPath)
        {
            InitializeComponent();
            _dbPath = dbPath;
            LoadAdmins();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    throw new Exception("Заполните все поля");
                string password = AskPassword();
                string workDir = @"C:\Documents\bee2evp";
                //string workDir = Path.Combine(basePath, "req");
                if (!Directory.Exists(workDir))
                { Directory.CreateDirectory(workDir); }
                string keyLen = comboBox1.SelectedItem.ToString();

                // 1. Генерация ключа
                RunCommand(
                    $"genpkey -engine bee2evp -algorithm bign -pkeyopt params:bign-curve{keyLen}v1 -out {CertName.Text}.key",
                    workDir
                );
                // 2. Генерация сертификата
                string subj = $"/CN={CertName.Text}/ST={Region.Text}/L={Town.Text}/O={Organization.Text}/OU={Unit.Text}/emailAddress={mail.Text}";

                RunCommand(
                    $"req -engine bee2evp -new -key {CertName.Text}.key -days 360 -subj \"{subj}\" -out {CertName.Text}.csr",
                    workDir
                );
                // 2. Генерация сертификата
                RunCommand(
    $"req -engine bee2evp -new -x509 -utf8 -nameopt multiline,utf8 -key {CertName.Text}.key -days 360 -subj \"{subj}\" -out {CertName.Text}.crt",
    workDir
);
                // 3. В DER
                RunCommand(
                    $"x509 -in {CertName.Text}.crt -outform der -out {CertName.Text}.der",
                    workDir
                );

                // 4. В PFX
                RunCommand(
                    $"pkcs12 -export -engine bee2evp -out {CertName.Text}.pfx -inkey {CertName.Text}.key -in {CertName.Text}.der -password pass:{password}",
                    workDir
                );
                MessageBox.Show("Сертификат успешно создан");
                string derPath = Path.Combine(workDir, $"{CertName.Text}.der");
                string pfxPath = Path.Combine(workDir, $"{CertName.Text}.pfx");

                byte[] derData = File.ReadAllBytes(derPath);
                byte[] pfxData = File.ReadAllBytes(pfxPath);
                using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
                {
                    connection.Open();

                    string insertSql = @"
        INSERT INTO REQ (Name, ORG, MAIL, CertDer, CertPfx, CreatedAt)
        VALUES (@name, @org, @mail, @der, @pfx, @createdAt)";

                    using (var command = new SQLiteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@name", CertName.Text);
                        command.Parameters.AddWithValue("@org", Organization.Text);
                        command.Parameters.AddWithValue("@mail", mail.Text);
                        command.Parameters.AddWithValue("@der", derData);
                        command.Parameters.AddWithValue("@pfx", pfxData);
                        command.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("o"));

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Req form3 = new Req(_dbPath);
            form3.Show();
            this.Hide();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            Req form3 = new Req(_dbPath);
            form3.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mainWindow form1 = new mainWindow();
            form1.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MainCA form1 = new MainCA(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void Certificates_Click(object sender, EventArgs e)
        {
            CertsA form1 = new CertsA(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void recalled_Click(object sender, EventArgs e)
        {
            revoked1 form1 = new revoked1(_dbPath);
            form1.Show();
            this.Hide();
        }
        private void LoadAdmins()
        {
            string connectionString = $"Data Source={_dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Name FROM Certificates WHERE IsCA = 1";

                using (var adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    comboBox2.DataSource = table;
                    comboBox2.DisplayMember = "Name"; // что видит пользователь
                    comboBox2.ValueMember = "Id";     // скрытое значение
                }
            }
        }
        private void comboBox2_Layout(object sender, LayoutEventArgs e)
        { }
    }
    }

