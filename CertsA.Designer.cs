namespace WinFormsApp1
{
    partial class CertsA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertsA));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            Request = new ToolStripButton();
            Certificates = new ToolStripButton();
            recalled = new ToolStripButton();
            Info = new Button();
            Rewoke = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, Request, Certificates, recalled });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 37;
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
            // Info
            // 
            Info.Location = new Point(616, 125);
            Info.Name = "Info";
            Info.Size = new Size(172, 29);
            Info.TabIndex = 36;
            Info.Text = "Информация";
            Info.UseVisualStyleBackColor = true;
            Info.Click += Info_Click;
            // 
            // Rewoke
            // 
            Rewoke.Location = new Point(616, 55);
            Rewoke.Name = "Rewoke";
            Rewoke.Size = new Size(172, 29);
            Rewoke.TabIndex = 35;
            Rewoke.Text = "Отозвать";
            Rewoke.UseVisualStyleBackColor = true;
            Rewoke.Click += Rewoke_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Location = new Point(29, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(565, 377);
            tableLayoutPanel1.TabIndex = 32;
            tableLayoutPanel1.Layout += tableLayoutPanel1_Layout;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(562, 371);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(616, 90);
            button1.Name = "button1";
            button1.Size = new Size(172, 29);
            button1.TabIndex = 38;
            button1.Text = "Экспорт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CertsA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(toolStrip1);
            Controls.Add(Info);
            Controls.Add(Rewoke);
            Controls.Add(tableLayoutPanel1);
            Name = "CertsA";
            Text = "Сертификаты";
            Load += CertsA_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton Request;
        private ToolStripButton Certificates;
        private ToolStripButton recalled;
        private Button Info;
        private Button Rewoke;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button button1;
    }
}