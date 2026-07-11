namespace Winform
{
    partial class FormCustomerDetail
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
            lblFormCustomerDetail = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblCustomerBusineSector = new Label();
            cmbCustomerBusinessSector = new ComboBox();
            lblCustomerRegisteredName = new Label();
            txtCustomerRegisteredName = new TextBox();
            lblCustomerAddress = new Label();
            txtCustomerAddress = new TextBox();
            lblCustomerCountry = new Label();
            cmbCustomerCountry = new ComboBox();
            lblCustomerEmail = new Label();
            txtCustomerEmail = new TextBox();
            lblCustomerVAT = new Label();
            txtCustomerVAT = new TextBox();
            lblCustomerEORI = new Label();
            txtCustomerEORI = new TextBox();
            lblCustomerPhoneNumber = new Label();
            txtCustomerPhoneNumber = new TextBox();
            lblCustomerBio = new Label();
            txtCustomerBio = new TextBox();
            lblcustomerActive = new Label();
            rdbCustomerActive = new RadioButton();
            rdbCustomerInactive = new RadioButton();
            btnCustomerDetailSave = new Button();
            btnCustomerDetailCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblFormCustomerDetail
            // 
            lblFormCustomerDetail.AutoSize = true;
            lblFormCustomerDetail.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            lblFormCustomerDetail.Location = new Point(293, 30);
            lblFormCustomerDetail.Name = "lblFormCustomerDetail";
            lblFormCustomerDetail.Size = new Size(186, 25);
            lblFormCustomerDetail.TabIndex = 0;
            lblFormCustomerDetail.Text = "Form Customer Detail";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(280, 93);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(55, 21);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(366, 91);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(208, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerBusineSector
            // 
            lblCustomerBusineSector.AutoSize = true;
            lblCustomerBusineSector.Font = new Font("Segoe UI", 12F);
            lblCustomerBusineSector.Location = new Point(214, 129);
            lblCustomerBusineSector.Name = "lblCustomerBusineSector";
            lblCustomerBusineSector.Size = new Size(121, 21);
            lblCustomerBusineSector.TabIndex = 3;
            lblCustomerBusineSector.Text = "Business Sector:";
            // 
            // cmbCustomerBusinessSector
            // 
            cmbCustomerBusinessSector.FormattingEnabled = true;
            cmbCustomerBusinessSector.Location = new Point(366, 127);
            cmbCustomerBusinessSector.Name = "cmbCustomerBusinessSector";
            cmbCustomerBusinessSector.Size = new Size(208, 23);
            cmbCustomerBusinessSector.TabIndex = 4;
            // 
            // lblCustomerRegisteredName
            // 
            lblCustomerRegisteredName.AutoSize = true;
            lblCustomerRegisteredName.Font = new Font("Segoe UI", 12F);
            lblCustomerRegisteredName.Location = new Point(202, 165);
            lblCustomerRegisteredName.Name = "lblCustomerRegisteredName";
            lblCustomerRegisteredName.Size = new Size(133, 21);
            lblCustomerRegisteredName.TabIndex = 5;
            lblCustomerRegisteredName.Text = "Registered Name:";
            // 
            // txtCustomerRegisteredName
            // 
            txtCustomerRegisteredName.Location = new Point(366, 163);
            txtCustomerRegisteredName.Name = "txtCustomerRegisteredName";
            txtCustomerRegisteredName.Size = new Size(208, 23);
            txtCustomerRegisteredName.TabIndex = 6;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Segoe UI", 12F);
            lblCustomerAddress.Location = new Point(266, 197);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(69, 21);
            lblCustomerAddress.TabIndex = 7;
            lblCustomerAddress.Text = "Address:";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(366, 195);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(208, 23);
            txtCustomerAddress.TabIndex = 8;
            // 
            // lblCustomerCountry
            // 
            lblCustomerCountry.AutoSize = true;
            lblCustomerCountry.Font = new Font("Segoe UI", 12F);
            lblCustomerCountry.Location = new Point(266, 233);
            lblCustomerCountry.Name = "lblCustomerCountry";
            lblCustomerCountry.Size = new Size(69, 21);
            lblCustomerCountry.TabIndex = 9;
            lblCustomerCountry.Text = "Country:";
            // 
            // cmbCustomerCountry
            // 
            cmbCustomerCountry.FormattingEnabled = true;
            cmbCustomerCountry.Location = new Point(366, 231);
            cmbCustomerCountry.Name = "cmbCustomerCountry";
            cmbCustomerCountry.Size = new Size(208, 23);
            cmbCustomerCountry.TabIndex = 10;
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Segoe UI", 12F);
            lblCustomerEmail.Location = new Point(280, 266);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(51, 21);
            lblCustomerEmail.TabIndex = 11;
            lblCustomerEmail.Text = "Email:";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(366, 266);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(208, 23);
            txtCustomerEmail.TabIndex = 12;
            // 
            // lblCustomerVAT
            // 
            lblCustomerVAT.AutoSize = true;
            lblCustomerVAT.Font = new Font("Segoe UI", 12F);
            lblCustomerVAT.Location = new Point(292, 297);
            lblCustomerVAT.Name = "lblCustomerVAT";
            lblCustomerVAT.Size = new Size(39, 21);
            lblCustomerVAT.TabIndex = 13;
            lblCustomerVAT.Text = "VAT:";
            // 
            // txtCustomerVAT
            // 
            txtCustomerVAT.Location = new Point(366, 297);
            txtCustomerVAT.Name = "txtCustomerVAT";
            txtCustomerVAT.Size = new Size(208, 23);
            txtCustomerVAT.TabIndex = 14;
            // 
            // lblCustomerEORI
            // 
            lblCustomerEORI.AutoSize = true;
            lblCustomerEORI.Font = new Font("Segoe UI", 12F);
            lblCustomerEORI.Location = new Point(284, 328);
            lblCustomerEORI.Name = "lblCustomerEORI";
            lblCustomerEORI.Size = new Size(47, 21);
            lblCustomerEORI.TabIndex = 15;
            lblCustomerEORI.Text = "EORI:";
            // 
            // txtCustomerEORI
            // 
            txtCustomerEORI.Location = new Point(366, 330);
            txtCustomerEORI.Name = "txtCustomerEORI";
            txtCustomerEORI.Size = new Size(208, 23);
            txtCustomerEORI.TabIndex = 16;
            // 
            // lblCustomerPhoneNumber
            // 
            lblCustomerPhoneNumber.AutoSize = true;
            lblCustomerPhoneNumber.Font = new Font("Segoe UI", 12F);
            lblCustomerPhoneNumber.Location = new Point(212, 364);
            lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber";
            lblCustomerPhoneNumber.Size = new Size(119, 21);
            lblCustomerPhoneNumber.TabIndex = 17;
            lblCustomerPhoneNumber.Text = "Phone Number:";
            // 
            // txtCustomerPhoneNumber
            // 
            txtCustomerPhoneNumber.Location = new Point(366, 364);
            txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            txtCustomerPhoneNumber.Size = new Size(208, 23);
            txtCustomerPhoneNumber.TabIndex = 18;
            // 
            // lblCustomerBio
            // 
            lblCustomerBio.AutoSize = true;
            lblCustomerBio.Font = new Font("Segoe UI", 12F);
            lblCustomerBio.Location = new Point(224, 400);
            lblCustomerBio.Name = "lblCustomerBio";
            lblCustomerBio.Size = new Size(107, 21);
            lblCustomerBio.TabIndex = 19;
            lblCustomerBio.Text = "Customer Bio:";
            // 
            // txtCustomerBio
            // 
            txtCustomerBio.Location = new Point(366, 400);
            txtCustomerBio.Name = "txtCustomerBio";
            txtCustomerBio.Size = new Size(208, 23);
            txtCustomerBio.TabIndex = 20;
            // 
            // lblcustomerActive
            // 
            lblcustomerActive.AutoSize = true;
            lblcustomerActive.Font = new Font("Segoe UI", 12F);
            lblcustomerActive.Location = new Point(228, 434);
            lblcustomerActive.Name = "lblcustomerActive";
            lblcustomerActive.Size = new Size(107, 21);
            lblcustomerActive.TabIndex = 21;
            lblcustomerActive.Text = "Active:(Status)";
            // 
            // rdbCustomerActive
            // 
            rdbCustomerActive.AutoSize = true;
            rdbCustomerActive.Checked = true;
            rdbCustomerActive.Location = new Point(366, 437);
            rdbCustomerActive.Name = "rdbCustomerActive";
            rdbCustomerActive.Size = new Size(58, 19);
            rdbCustomerActive.TabIndex = 22;
            rdbCustomerActive.TabStop = true;
            rdbCustomerActive.Text = "Active";
            rdbCustomerActive.UseVisualStyleBackColor = true;
            // 
            // rdbCustomerInactive
            // 
            rdbCustomerInactive.AutoSize = true;
            rdbCustomerInactive.Location = new Point(443, 436);
            rdbCustomerInactive.Name = "rdbCustomerInactive";
            rdbCustomerInactive.Size = new Size(66, 19);
            rdbCustomerInactive.TabIndex = 23;
            rdbCustomerInactive.TabStop = true;
            rdbCustomerInactive.Text = "Inactive";
            rdbCustomerInactive.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDetailSave
            // 
            btnCustomerDetailSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCustomerDetailSave.Font = new Font("Segoe UI", 12F);
            btnCustomerDetailSave.Location = new Point(280, 505);
            btnCustomerDetailSave.Name = "btnCustomerDetailSave";
            btnCustomerDetailSave.Size = new Size(75, 30);
            btnCustomerDetailSave.TabIndex = 24;
            btnCustomerDetailSave.Text = "Save";
            btnCustomerDetailSave.UseVisualStyleBackColor = true;
            btnCustomerDetailSave.Click += btnCustomerDetailSave_Click;
            // 
            // btnCustomerDetailCancel
            // 
            btnCustomerDetailCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCustomerDetailCancel.Font = new Font("Segoe UI", 12F);
            btnCustomerDetailCancel.Location = new Point(455, 505);
            btnCustomerDetailCancel.Name = "btnCustomerDetailCancel";
            btnCustomerDetailCancel.Size = new Size(75, 30);
            btnCustomerDetailCancel.TabIndex = 25;
            btnCustomerDetailCancel.Text = "Cancel";
            btnCustomerDetailCancel.UseVisualStyleBackColor = true;
            btnCustomerDetailCancel.Click += btnCustomerDetailCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(580, 93);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 26;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(580, 268);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 27;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(580, 233);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 28;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(580, 364);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 29;
            label4.Text = "*";
            // 
            // FormCustomerDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCustomerDetailCancel);
            Controls.Add(btnCustomerDetailSave);
            Controls.Add(rdbCustomerInactive);
            Controls.Add(rdbCustomerActive);
            Controls.Add(lblcustomerActive);
            Controls.Add(txtCustomerBio);
            Controls.Add(lblCustomerBio);
            Controls.Add(txtCustomerPhoneNumber);
            Controls.Add(lblCustomerPhoneNumber);
            Controls.Add(txtCustomerEORI);
            Controls.Add(lblCustomerEORI);
            Controls.Add(txtCustomerVAT);
            Controls.Add(lblCustomerVAT);
            Controls.Add(txtCustomerEmail);
            Controls.Add(lblCustomerEmail);
            Controls.Add(cmbCustomerCountry);
            Controls.Add(lblCustomerCountry);
            Controls.Add(txtCustomerAddress);
            Controls.Add(lblCustomerAddress);
            Controls.Add(txtCustomerRegisteredName);
            Controls.Add(lblCustomerRegisteredName);
            Controls.Add(cmbCustomerBusinessSector);
            Controls.Add(lblCustomerBusineSector);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblFormCustomerDetail);
            Name = "FormCustomerDetail";
            Text = "FormCustomerDetail";
            Load += FormCustomerDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormCustomerDetail;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblCustomerBusineSector;
        private ComboBox cmbCustomerBusinessSector;
        private Label lblCustomerRegisteredName;
        private TextBox txtCustomerRegisteredName;
        private Label lblCustomerAddress;
        private TextBox txtCustomerAddress;
        private Label lblCustomerCountry;
        private ComboBox cmbCustomerCountry;
        private Label lblCustomerEmail;
        private TextBox txtCustomerEmail;
        private Label lblCustomerVAT;
        private TextBox txtCustomerVAT;
        private Label lblCustomerEORI;
        private TextBox txtCustomerEORI;
        private Label lblCustomerPhoneNumber;
        private TextBox txtCustomerPhoneNumber;
        private Label lblCustomerBio;
        private TextBox txtCustomerBio;
        private Label lblcustomerActive;
        private RadioButton rdbCustomerActive;
        private RadioButton rdbCustomerInactive;
        private Button btnCustomerDetailSave;
        private Button btnCustomerDetailCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}