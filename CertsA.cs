using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CertsA : Form
    {
        private string _dbPath;
        public CertsA(string dbPath)
        {
            InitializeComponent();
            _dbPath = dbPath;
            LoadCertificates();
        }
        private void LoadCertificates()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string query = "SELECT Id, Name, ORG, MAIL, CreatedAt FROM Certificates";

                using (var adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }

            // Скрываем Id, но оставляем для логики
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["ORG"].HeaderText = "Организация";
            dataGridView1.Columns["MAIL"].HeaderText = "Адрес электронной почты";
            dataGridView1.Columns["CreatedAt"].HeaderText = "Дата создания";
        }
        private int GetSelectedCertificateId()
        {
            if (dataGridView1.CurrentRow == null)
                throw new Exception("Выберите сертификат");

            return Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
        }
        private void tableLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void Request_Click(object sender, EventArgs e)
        {
            Req form1 = new Req(_dbPath);
            form1.Show();
            this.Hide();
        }
        private void ExportCertificate(int id, string folderPath)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string query = "SELECT Name, CertDer, CertPfx FROM Certificates WHERE Id = @id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Сертификат не найден");

                        string name = reader["Name"].ToString();
                        byte[] der = (byte[])reader["CertDer"];
                        byte[] pfx = (byte[])reader["CertPfx"];

                        string derPath = Path.Combine(folderPath, name + ".der");
                        string pfxPath = Path.Combine(folderPath, name + ".pfx");

                        File.WriteAllBytes(derPath, der);
                        File.WriteAllBytes(pfxPath, pfx);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int certId = GetSelectedCertificateId();

                using (var folderDialog = new FolderBrowserDialog())
                {
                    string selectedPath = folderDialog.SelectedPath;
                    if (folderDialog.ShowDialog() == DialogResult.Cancel)
                        return;
                    else ExportCertificate(certId, selectedPath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
        }

        private void Rewoke_Click(object sender, EventArgs e)
        {
            using (var dialog = new RevokeCertificateForm())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedReason = dialog.SelectedReason;
                    MessageBox.Show($"Вы выбрали причину: {selectedReason}", "Результат");
                }

            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            string createdAt = dataGridView1.CurrentRow.Cells["CreatedAt"].Value.ToString();

            string connectionString = $"Data Source={_dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Вставка в другую таблицу
                        string insertQuery = "INSERT INTO REWOKED (Name, CreatedAt) VALUES (@name, @createdAt)";
                        using (var insertCmd = new SQLiteCommand(insertQuery, connection, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@name", name);
                            insertCmd.Parameters.AddWithValue("@createdAt", createdAt);
                            insertCmd.ExecuteNonQuery();
                        }

                        // 2. Удаление из CA
                        string deleteQuery = "DELETE FROM Certificates WHERE Id = @id";
                        using (var deleteCmd = new SQLiteCommand(deleteQuery, connection, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", id);
                            deleteCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Запись перенесена!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            LoadCertificates();
        }

        private void recalled_Click(object sender, EventArgs e)
        {
            revoked1 form1 = new revoked1(_dbPath);
            form1.Show();
            this.Hide();
        }

        private void CertsA_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
