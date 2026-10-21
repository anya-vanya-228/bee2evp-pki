namespace WinFormsApp1
{
    partial class MainCA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCA));
            label1 = new Label();
            CertName = new TextBox();
            label2 = new Label();
            UserName = new TextBox();
            Unit = new TextBox();
            label3 = new Label();
            Organization = new TextBox();
            label4 = new Label();
            mail = new TextBox();
            label5 = new Label();
            Town = new TextBox();
            label6 = new Label();
            Region = new TextBox();
            label7 = new Label();
            Country = new TextBox();
            label8 = new Label();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label9 = new Label();
            CertImport = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            Request = new ToolStripButton();
            Certificates = new ToolStripButton();
            recalled = new ToolStripButton();
            KeyImport = new Button();
            Done = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label11 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 75);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "Имя сертификата";
            label1.Click += label1_Click;
            // 
            // CertName
            // 
            CertName.Location = new Point(210, 72);
            CertName.Name = "CertName";
            CertName.Size = new Size(190, 27);
            CertName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 141);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 7;
            label2.Text = "Организация";
            // 
            // UserName
            // 
            UserName.Location = new Point(210, 105);
            UserName.Name = "UserName";
            UserName.Size = new Size(190, 27);
            UserName.TabIndex = 8;
            // 
            // Unit
            // 
            Unit.Location = new Point(210, 171);
            Unit.Name = "Unit";
            Unit.Size = new Size(190, 27);
            Unit.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 176);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 11;
            label3.Text = "Электронная почта";
            // 
            // Organization
            // 
            Organization.Location = new Point(210, 138);
            Organization.Name = "Organization";
            Organization.Size = new Size(190, 27);
            Organization.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 174);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 9;
            label4.Text = "Подразделение";
            // 
            // mail
            // 
            mail.Location = new Point(556, 171);
            mail.Name = "mail";
            mail.Size = new Size(190, 27);
            mail.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 143);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 19;
            label5.Text = "Город";
            // 
            // Town
            // 
            Town.Location = new Point(556, 138);
            Town.Name = "Town";
            Town.Size = new Size(190, 27);
            Town.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 112);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 17;
            label6.Text = "Область";
            // 
            // Region
            // 
            Region.Location = new Point(556, 105);
            Region.Name = "Region";
            Region.Size = new Size(190, 27);
            Region.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 79);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 15;
            label7.Text = "Страна";
            // 
            // Country
            // 
            Country.Location = new Point(556, 72);
            Country.Name = "Country";
            Country.Size = new Size(190, 27);
            Country.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 108);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 13;
            label8.Text = "Имя пользователя";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 207);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 21;
            label10.Text = "Длина ключа";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(496, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "256", "384", "512" });
            comboBox1.Location = new Point(210, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 28);
            comboBox1.TabIndex = 26;
            comboBox1.Text = "256";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 214);
            label9.Name = "label9";
            label9.Size = new Size(212, 20);
            label9.TabIndex = 27;
            label9.Text = "Дата окончания сертификата";
            // 
            // CertImport
            // 
            CertImport.Location = new Point(60, 384);
            CertImport.Name = "CertImport";
            CertImport.Size = new Size(182, 29);
            CertImport.TabIndex = 28;
            CertImport.Text = "Импорт Сертификата";
            CertImport.UseVisualStyleBackColor = true;
            CertImport.Click += CertImport_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, Request, Certificates, recalled });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 30;
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
            // KeyImport
            // 
            KeyImport.Location = new Point(248, 384);
            KeyImport.Name = "KeyImport";
            KeyImport.Size = new Size(137, 29);
            KeyImport.TabIndex = 32;
            KeyImport.Text = "Импорт ключа";
            KeyImport.UseVisualStyleBackColor = true;
            KeyImport.Click += KeyImport_Click;
            // 
            // Done
            // 
            Done.Location = new Point(652, 314);
            Done.Name = "Done";
            Done.Size = new Size(94, 29);
            Done.TabIndex = 33;
            Done.Text = "Готово";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Корневой УЦ", "Промежуточный УЦ" });
            comboBox2.Location = new Point(59, 350);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 28);
            comboBox2.TabIndex = 34;
            comboBox2.Text = "Корневой УЦ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(248, 346);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(120, 28);
            comboBox3.TabIndex = 35;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(210, 323);
            label11.Name = "label11";
            label11.Size = new Size(207, 20);
            label11.TabIndex = 36;
            label11.Text = "Сертификат для подписания";
            label11.Click += label11_Click;
            // 
            // MainCA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(Done);
            Controls.Add(KeyImport);
            Controls.Add(toolStrip1);
            Controls.Add(CertImport);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label10);
            Controls.Add(mail);
            Controls.Add(label5);
            Controls.Add(Town);
            Controls.Add(label6);
            Controls.Add(Region);
            Controls.Add(label7);
            Controls.Add(Country);
            Controls.Add(label8);
            Controls.Add(Unit);
            Controls.Add(label3);
            Controls.Add(Organization);
            Controls.Add(label4);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(CertName);
            Controls.Add(label1);
            Name = "MainCA";
            Text = "УЦ";
            Load += MainCA_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox CertName;
        private Label label2;
        private TextBox UserName;
        private TextBox Unit;
        private Label label3;
        private TextBox Organization;
        private Label label4;
        private TextBox mail;
        private Label label5;
        private TextBox Town;
        private Label label6;
        private TextBox Region;
        private Label label7;
        private TextBox Country;
        private Label label8;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label9;
        private Button CertImport;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton Request;
        private ToolStripButton Certificates;
        private ToolStripButton recalled;
        private Button KeyImport;
        private Button Done;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label11;
    }
}