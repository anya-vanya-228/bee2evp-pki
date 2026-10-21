using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RevokeCertificateForm : Form
    {
        private Label lblTitle;
        private ComboBox cmbReasons;
        private Button btnOk;
        private Button btnCancel;

        public string SelectedReason => cmbReasons.SelectedItem?.ToString();

        public RevokeCertificateForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Отзыв сертификата";
            this.Width = 400;
            this.Height = 400;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            lblTitle = new Label()
            {
                Text = "Отзыв сертификата",
                Left = 40,
                Top = 30,
                Width = 300,
                Height = 50
            };

            cmbReasons = new ComboBox()
            {
                Left = 40,
                Top = 50,
                Width = 250,
                Height = 50,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cmbReasons.Items.AddRange(new string[]
            {
            "Не уточнена",
            "Ключ скомпрометирован",
            "УЦ скомпрометирован",
            "Смена места работы",
            "Заменен",
            "Прекращение деятельности"
            });

            cmbReasons.SelectedIndex = 0;

            btnOk = new Button()
            {
                Text = "ОК",
                Left = 140,
                Width = 75,
                Top = 100,
                Height = 50,
                DialogResult = DialogResult.OK

            };

            btnCancel = new Button()
            {
                Text = "Отмена",
                Left = 225,
                Width = 100,
                Top = 100,
                Height = 50,
                DialogResult = DialogResult.Cancel
            };

            this.Controls.Add(lblTitle);
            this.Controls.Add(cmbReasons);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }
    }
}
