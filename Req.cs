using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.Unicode;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Req : Form
    {
        private string _dbPath;

        public Req(string dbPath)
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

                string query = "SELECT Id, Name, ORG, MAIL, CreatedAt FROM REQ";

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
        private void Certificates_Click(object sender, EventArgs e)
        {
            CertsA form2 = new CertsA(_dbPath);
            form2.Show();
            this.Hide();
        }
        private void CreateCert_Click(object sender, EventArgs e)
        {
            Сертификат form3 = new Сертификат(_dbPath);
            form3.Show();
            this.Hide();
        }

        private void listView1_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Request_Click(object sender, EventArgs e)
        {

        }

        private void recalled_Click(object sender, EventArgs e)
        {
            revoked1 form1 = new revoked1(_dbPath);
            form1.Show();
            this.Hide();
        }
        private string AskPassword()
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите пароль УЦ",
                "Пароль",
                "");

            if (password.Length < 6)
                throw new Exception("Пароль слишком короткий");

            return password;
        }
        private void approve_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Выберите строку!");
                    return;
                }
                string password = AskPassword();
             int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Копирование ВСЕЙ записи
                            string insertQuery = @"
INSERT INTO Certificates (Name, ORG, MAIL, CertDer, CertPfx, CreatedAt) 
SELECT Name, ORG, MAIL, CertDer, CertPfx, CreatedAt FROM REQ WHERE Id = @id
";

                            using (var cmd = new SQLiteCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }

                        string deleteQuery = "DELETE FROM REQ WHERE Id = @id";
                        using (var deleteCmd = new SQLiteCommand(deleteQuery, connection, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", id);
                            deleteCmd.ExecuteNonQuery();
                        }

                            transaction.Commit();

                            MessageBox.Show("Запрос утвержден!");


                        }

                        catch (Exception ex)
                        {
                        }
                    }
                }
                LoadCertificates();
                }
   
            }
        }
    }
