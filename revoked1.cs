using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class revoked1 : Form
    {
        private string _dbPath;
        public revoked1(string dbPath)
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

                string query = "SELECT Id, Name, CreatedAt FROM REWOKED";

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
            dataGridView1.Columns["CreatedAt"].HeaderText = "Дата отзыва";
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
            Req form1 = new Req(_dbPath);
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

        }
    }
}
