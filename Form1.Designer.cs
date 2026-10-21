namespace WinFormsApp1
{
    partial class Сертификат
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сертификат));
            Done = new Button();
            KeyImport = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            Request = new ToolStripButton();
            Certificates = new ToolStripButton();
            recalled = new ToolStripButton();
            CertImport = new Button();
            label9 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            mail = new TextBox();
            label5 = new Label();
            Town = new TextBox();
            label6 = new Label();
            Region = new TextBox();
            label7 = new Label();
            Country = new TextBox();
            label8 = new Label();
            Unit = new TextBox();
            label3 = new Label();
            Organization = new TextBox();
            label4 = new Label();
            UserName = new TextBox();
            label2 = new Label();
            CertName = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Done
            // 
            Done.Location = new Point(652, 333);
            Done.Name = "Done";
            Done.Size = new Size(94, 29);
            Done.TabIndex = 57;
            Done.Text = "Готово";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // KeyImport
            // 
            KeyImport.Location = new Point(248, 403);
            KeyImport.Name = "KeyImport";
            KeyImport.Size = new Size(137, 29);
            KeyImport.TabIndex = 56;
            KeyImport.Text = "Импорт ключа";
            KeyImport.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, Request, Certificates, recalled });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 55;
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
            // CertImport
            // 
            CertImport.Location = new Point(60, 403);
            CertImport.Name = "CertImport";
            CertImport.Size = new Size(182, 29);
            CertImport.TabIndex = 54;
            CertImport.Text = "Импорт Сертификата";
            CertImport.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 233);
            label9.Name = "label9";
            label9.Size = new Size(212, 20);
            label9.TabIndex = 53;
            label9.Text = "Дата окончания сертификата";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "256", "384", "512" });
            comboBox1.Location = new Point(210, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 28);
            comboBox1.TabIndex = 52;
            comboBox1.Text = "256";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(496, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 226);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 50;
            label10.Text = "Длина ключа";
            // 
            // mail
            // 
            mail.Location = new Point(556, 190);
            mail.Name = "mail";
            mail.Size = new Size(190, 27);
            mail.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 162);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 48;
            label5.Text = "Город";
            // 
            // Town
            // 
            Town.Location = new Point(556, 157);
            Town.Name = "Town";
            Town.Size = new Size(190, 27);
            Town.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 131);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 46;
            label6.Text = "Область";
            // 
            // Region
            // 
            Region.Location = new Point(556, 124);
            Region.Name = "Region";
            Region.Size = new Size(190, 27);
            Region.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 98);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 44;
            label7.Text = "Страна";
            // 
            // Country
            // 
            Country.Location = new Point(556, 91);
            Country.Name = "Country";
            Country.Size = new Size(190, 27);
            Country.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 127);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 42;
            label8.Text = "Имя пользователя";
            // 
            // Unit
            // 
            Unit.Location = new Point(210, 190);
            Unit.Name = "Unit";
            Unit.Size = new Size(190, 27);
            Unit.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 195);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 40;
            label3.Text = "Электронная почта";
            // 
            // Organization
            // 
            Organization.Location = new Point(210, 157);
            Organization.Name = "Organization";
            Organization.Size = new Size(190, 27);
            Organization.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 193);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 38;
            label4.Text = "Подразделение";
            // 
            // UserName
            // 
            UserName.Location = new Point(210, 124);
            UserName.Name = "UserName";
            UserName.Size = new Size(190, 27);
            UserName.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 160);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 36;
            label2.Text = "Организация";
            // 
            // CertName
            // 
            CertName.Location = new Point(210, 91);
            CertName.Name = "CertName";
            CertName.Size = new Size(190, 27);
            CertName.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 94);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 34;
            label1.Text = "Имя сертификата";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(250, 358);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 58;
            comboBox2.Layout += comboBox2_Layout;
            // 
            // Сертификат
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Сертификат";
            Text = "Сертификат";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Done;
        private Button KeyImport;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton Request;
        private ToolStripButton Certificates;
        private ToolStripButton recalled;
        private Button CertImport;
        private Label label9;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox mail;
        private Label label5;
        private TextBox Town;
        private Label label6;
        private TextBox Region;
        private Label label7;
        private TextBox Country;
        private Label label8;
        private TextBox Unit;
        private Label label3;
        private TextBox Organization;
        private Label label4;
        private TextBox UserName;
        private Label label2;
        private TextBox CertName;
        private Label label1;
        private ComboBox comboBox2;
    }
}