using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class MainCA : Form
    {
        private void RunCommand(string command, string workingDir)
        {
            var process = new Process();
            process.StartInfo.FileName ="openssl.exe";
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

        private string _dbPath;
        public MainCA(string dbPath)
        {
            InitializeComponent();
            _dbPath = dbPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                    return false;
            }

            return true;
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
        private void Done_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    throw new Exception("Заполните все поля");

                string password = AskPassword();

                string workDir = @"C:\Documents\bee2evp";
                //string workDir = Path.Combine(basePath, "mainCA");
                if (!Directory.Exists(workDir))
                { Directory.CreateDirectory(workDir); }

                string keyLen = comboBox1.SelectedItem.ToString();

                string keyFile = "key.key";
                string certFile = "cert.crt";

                // 1. Генерация ключа
                RunCommand(
                    $"genpkey -engine bee2evp -algorithm bign -pkeyopt params:bign-curve{keyLen}v1 -out {keyFile}",
                    workDir
                );

                // 2. Генерация сертификата
                string subj = $"/CN={CertName.Text}/ST={Region.Text}/L={Town.Text}/O={Organization.Text}/OU={Unit.Text}/emailAddress={mail.Text}";

                RunCommand(
                    $"req -engine bee2evp -new -x509 -utf8 -nameopt multiline,utf8 -key {keyFile} -days 360 -subj \"{subj}\" -out {certFile}",
                    workDir
                );

                // 3. В DER
                RunCommand(
                    $"x509 -in {certFile} -outform der -out {CertName.Text}.der",
                    workDir
                );

                // 4. В PFX
                RunCommand(
                    $"pkcs12 -export -engine bee2evp -out {CertName.Text}.pfx -inkey {keyFile} -in {certFile} -password pass:{password}",
                    workDir
                );

                // 5. Удаление незашифрованных файлов
                //File.Delete(Path.Combine(workDir, keyFile));
                //File.Delete(Path.Combine(workDir, certFile));

                MessageBox.Show("Сертификат успешно создан");
                string derPath = Path.Combine(workDir, $"{CertName.Text}.der");
                string pfxPath = Path.Combine(workDir, $"{CertName.Text}.pfx");

                byte[] derData = File.ReadAllBytes(derPath);
                byte[] pfxData = File.ReadAllBytes(pfxPath);

                using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
                {
                    connection.Open();

                    string insertSql = @"
        INSERT INTO Certificates (Name, ORG, MAIL, CertDer, CertPfx, Password, IsCA, CreatedAt)
        VALUES (@name, @org, @mail, @der, @pfx, @pass, @ca, @createdAt)";

                    using (var command = new SQLiteCommand(insertSql, connection))
                    {
                        command.Parameters.AddWithValue("@name", CertName.Text);
                        command.Parameters.AddWithValue("@org", Organization.Text);
                        command.Parameters.AddWithValue("@mail", mail.Text);
                        command.Parameters.AddWithValue("@der", derData);
                        command.Parameters.AddWithValue("@pfx", pfxData);
                        command.Parameters.AddWithValue("@pass", password);
                        command.Parameters.AddWithValue("@ca", 1);
                        command.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("o"));

                        command.ExecuteNonQuery();
                    }
                }
                File.Delete(derPath);
                File.Delete(pfxPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CertImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Certificates (*.crt;*.pem)|*.crt;*.pem";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string workDir = @"C:\Users\ASUS\Documents\bee2\1\mainCA";

                string input = ofd.FileName;
                string der = Path.Combine(workDir, "imported.der");

                RunCommand(
                    $"openssl x509 -in \"{input}\" -outform der -out \"{der}\"",
                    workDir
                );

                MessageBox.Show("Импортированный сертификат переведен в DER");
            }
        }

        private void KeyImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Key (*.key;*.pem)|*.key;*.pem";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string password = AskPassword();

                string workDir = @"C:\Users\ASUS\Documents\bee2\1\mainCA";

                string key = ofd.FileName;
                string cert = Path.Combine(workDir, "imported.crt");
                string pfx = Path.Combine(workDir, "imported.pfx");

                // предполагается, что сертификат уже есть
                RunCommand(
                    $"openssl pkcs12 -export -inkey \"{key}\" -in \"{cert}\" -out \"{pfx}\" -password pass:{password}",
                    workDir
                );

                MessageBox.Show("Создан PFX из импортированного ключа");
            }
        }

        private void Request_Click(object sender, EventArgs e)
        {
            Req form1 = new Req(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mainWindow form1 = new mainWindow();
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                    comboBox3.DataSource = table;
                    comboBox3.DisplayMember = "Name"; // что видит пользователь
                    comboBox3.ValueMember = "Id";     // скрытое значение
                }
            }
        }
        private void LoadComboBoxData()
        {
            LoadAdmins();
        }


        private void MainCA_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
    }
    }
}

