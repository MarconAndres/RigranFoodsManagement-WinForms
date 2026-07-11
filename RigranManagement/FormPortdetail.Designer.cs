namespace Winform
{
    partial class FormPortdetail
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
            labelPortDetail = new Label();
            labelPortName = new Label();
            txbCountryName = new TextBox();
            label1 = new Label();
            cmbCountriesFormPortDetail = new ComboBox();
            btnSaveFormPortDetail = new Button();
            btnCancelFormPortDetail = new Button();
            lblObligatoryfield = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelPortDetail
            // 
            labelPortDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPortDetail.AutoSize = true;
            labelPortDetail.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            labelPortDetail.Location = new Point(323, 47);
            labelPortDetail.Name = "labelPortDetail";
            labelPortDetail.Size = new Size(141, 25);
            labelPortDetail.TabIndex = 0;
            labelPortDetail.Text = "Form Port Detail";
            // 
            // labelPortName
            // 
            labelPortName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPortName.AutoSize = true;
            labelPortName.Font = new Font("Segoe UI", 12F);
            labelPortName.Location = new Point(233, 123);
            labelPortName.Name = "labelPortName";
            labelPortName.Size = new Size(55, 21);
            labelPortName.TabIndex = 1;
            labelPortName.Text = "Name:";
            // 
            // txbCountryName
            // 
            txbCountryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCountryName.Location = new Point(309, 123);
            txbCountryName.Name = "txbCountryName";
            txbCountryName.Size = new Size(181, 23);
            txbCountryName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(219, 168);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 3;
            label1.Text = "Country:";
            // 
            // cmbCountriesFormPortDetail
            // 
            cmbCountriesFormPortDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbCountriesFormPortDetail.FormattingEnabled = true;
            cmbCountriesFormPortDetail.Location = new Point(309, 170);
            cmbCountriesFormPortDetail.Name = "cmbCountriesFormPortDetail";
            cmbCountriesFormPortDetail.Size = new Size(181, 23);
            cmbCountriesFormPortDetail.TabIndex = 4;
            // 
            // btnSaveFormPortDetail
            // 
            btnSaveFormPortDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSaveFormPortDetail.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnSaveFormPortDetail.Location = new Point(270, 263);
            btnSaveFormPortDetail.Name = "btnSaveFormPortDetail";
            btnSaveFormPortDetail.Size = new Size(75, 23);
            btnSaveFormPortDetail.TabIndex = 5;
            btnSaveFormPortDetail.Text = "Save";
            btnSaveFormPortDetail.UseVisualStyleBackColor = true;
            btnSaveFormPortDetail.Click += btnSaveFormPortDetail_Click;
            // 
            // btnCancelFormPortDetail
            // 
            btnCancelFormPortDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelFormPortDetail.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCancelFormPortDetail.Location = new Point(439, 263);
            btnCancelFormPortDetail.Name = "btnCancelFormPortDetail";
            btnCancelFormPortDetail.Size = new Size(75, 23);
            btnCancelFormPortDetail.TabIndex = 6;
            btnCancelFormPortDetail.Text = "Cancel";
            btnCancelFormPortDetail.UseVisualStyleBackColor = true;
            btnCancelFormPortDetail.Click += btnCancelFormPortDetail_Click;
            // 
            // lblObligatoryfield
            // 
            lblObligatoryfield.AutoSize = true;
            lblObligatoryfield.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblObligatoryfield.ForeColor = Color.Red;
            lblObligatoryfield.Location = new Point(496, 123);
            lblObligatoryfield.Name = "lblObligatoryfield";
            lblObligatoryfield.Size = new Size(15, 19);
            lblObligatoryfield.TabIndex = 7;
            lblObligatoryfield.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(496, 171);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 8;
            label2.Text = "*";
            // 
            // FormPortdetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblObligatoryfield);
            Controls.Add(btnCancelFormPortDetail);
            Controls.Add(btnSaveFormPortDetail);
            Controls.Add(cmbCountriesFormPortDetail);
            Controls.Add(label1);
            Controls.Add(txbCountryName);
            Controls.Add(labelPortName);
            Controls.Add(labelPortDetail);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPortdetail";
            Text = "FormPortdetail";
            Load += FormPortdetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPortDetail;
        private Label labelPortName;
        private TextBox txbCountryName;
        private Label label1;
        private ComboBox cmbCountriesFormPortDetail;
        private Button btnSaveFormPortDetail;
        private Button btnCancelFormPortDetail;
        private Label lblObligatoryfield;
        private Label label2;
    }
}