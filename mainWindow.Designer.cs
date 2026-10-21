namespace WinFormsApp1
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            createDB = new Button();
            OpenDB = new Button();
            Exit = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            MainCA = new ToolStripButton();
            Request = new ToolStripButton();
            Certificates = new ToolStripButton();
            recalled = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // createDB
            // 
            createDB.Location = new Point(76, 105);
            createDB.Name = "createDB";
            createDB.Size = new Size(132, 45);
            createDB.TabIndex = 0;
            createDB.Text = "Создание БД";
            createDB.UseVisualStyleBackColor = true;
            createDB.Click += button1_Click;
            // 
            // OpenDB
            // 
            OpenDB.Location = new Point(76, 156);
            OpenDB.Name = "OpenDB";
            OpenDB.Size = new Size(132, 45);
            OpenDB.TabIndex = 1;
            OpenDB.Text = "Открытие БД";
            OpenDB.UseVisualStyleBackColor = true;
            OpenDB.Click += button2_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(76, 207);
            Exit.Name = "Exit";
            Exit.Size = new Size(132, 45);
            Exit.TabIndex = 2;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, MainCA, Request, Certificates, recalled });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 3;
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
            // MainCA
            // 
            MainCA.Image = (Image)resources.GetObject("MainCA.Image");
            MainCA.ImageTransparentColor = Color.Magenta;
            MainCA.Name = "MainCA";
            MainCA.Size = new Size(53, 24);
            MainCA.Text = "УЦ";
            MainCA.Click += toolStripDropDownButton1_Click;
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
            Certificates.Click += toolStripButton2_Click;
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
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = SystemColors.MenuText;
            richTextBox1.Location = new Point(265, 94);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(497, 195);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Инфраструктура открытых ключей на основе стандартов СТБ ";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(Exit);
            Controls.Add(OpenDB);
            Controls.Add(createDB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainWindow";
            Text = "Главная";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createDB;
        private Button OpenDB;
        private Button Exit;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton MainCA;
        private ToolStripButton Certificates;
        private ToolStripButton Request;
        private ToolStripButton recalled;
        private RichTextBox richTextBox1;
    }
}
