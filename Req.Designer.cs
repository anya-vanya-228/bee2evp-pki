namespace WinFormsApp1
{
    partial class Req
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Req));
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            CreateCert = new Button();
            approve = new Button();
            Reject = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            Request = new ToolStripButton();
            Certificates = new ToolStripButton();
            recalled = new ToolStripButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Location = new Point(29, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(565, 377);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(559, 371);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Layout += dataGridView1_Layout;
            // 
            // CreateCert
            // 
            CreateCert.Location = new Point(616, 60);
            CreateCert.Name = "CreateCert";
            CreateCert.Size = new Size(172, 29);
            CreateCert.TabIndex = 1;
            CreateCert.Text = "Создать запрос";
            CreateCert.UseVisualStyleBackColor = true;
            CreateCert.Click += CreateCert_Click;
            // 
            // approve
            // 
            approve.Location = new Point(616, 95);
            approve.Name = "approve";
            approve.Size = new Size(172, 29);
            approve.TabIndex = 2;
            approve.Text = "Утвердить";
            approve.UseVisualStyleBackColor = true;
            approve.Click += approve_Click;
            // 
            // Reject
            // 
            Reject.Location = new Point(616, 130);
            Reject.Name = "Reject";
            Reject.Size = new Size(172, 29);
            Reject.TabIndex = 3;
            Reject.Text = "Отклонить";
            Reject.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, Request, Certificates, recalled });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 31;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(89, 24);
            toolStripButton1.Text = "Главная";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(53, 24);
            toolStripButton2.Text = "УЦ";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // Request
            // 
            Request.Image = (Image)resources.GetObject("Request.Image");
            Request.ImageTransparentColor = Color.Magenta;
            Request.Name = "Request";
            Request.Size = new Size(94, 24);
            Request.Text = "Запросы";
            Request.Click += Request_Click;
            // 
            // Certificates
            // 
            Certificates.Image = (Image)resources.GetObject("Certificates.Image");
            Certificates.ImageTransparentColor = Color.Magenta;
            Certificates.Name = "Certificates";
            Certificates.Size = new Size(125, 24);
            Certificates.Text = "Сертификаты";
            Certificates.Click += Certificates_Click;
            // 
            // recalled
            // 
            recalled.Image = (Image)resources.GetObject("recalled.Image");
            recalled.ImageTransparentColor = Color.Magenta;
            recalled.Name = "recalled";
            recalled.Size = new Size(119, 24);
            recalled.Text = "Отозванные";
            recalled.Click += recalled_Click;
            // 
            // Req
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(Reject);
            Controls.Add(approve);
            Controls.Add(CreateCert);
            Controls.Add(tableLayoutPanel1);
            Name = "Req";
            Text = "Запросы";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button CreateCert;
        private Button approve;
        private Button Reject;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton Request;
        private ToolStripButton Certificates;
        private ToolStripButton recalled;
        private DataGridView dataGridView1;
    }
}