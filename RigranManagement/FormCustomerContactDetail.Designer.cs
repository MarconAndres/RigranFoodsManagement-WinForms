namespace Winform
{
    partial class FormCustomerContactDetail
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
            lblCustomerName = new Label();
            lblFormCCDetail = new Label();
            cmbCustomer = new ComboBox();
            label1 = new Label();
            txtContactFirstName = new TextBox();
            label2 = new Label();
            txtContactLastName = new TextBox();
            label3 = new Label();
            txtRolePosition = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(180, 97);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(127, 21);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblFormCCDetail
            // 
            lblFormCCDetail.AutoSize = true;
            lblFormCCDetail.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            lblFormCCDetail.Location = new Point(290, 36);
            lblFormCCDetail.Name = "lblFormCCDetail";
            lblFormCCDetail.Size = new Size(249, 25);
            lblFormCCDetail.TabIndex = 4;
            lblFormCCDetail.Text = "Form Customer contact Detail";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(313, 95);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(204, 23);
            cmbCustomer.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(161, 126);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 6;
            label1.Text = "Contact First Name:";
            // 
            // txtContactFirstName
            // 
            txtContactFirstName.Location = new Point(313, 124);
            txtContactFirstName.Name = "txtContactFirstName";
            txtContactFirstName.Size = new Size(204, 23);
            txtContactFirstName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(163, 155);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 8;
            label2.Text = "Contact Last Name:";
            // 
            // txtContactLastName
            // 
            txtContactLastName.Location = new Point(313, 153);
            txtContactLastName.Name = "txtContactLastName";
            txtContactLastName.Size = new Size(204, 23);
            txtContactLastName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(202, 184);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 10;
            label3.Text = "Role/Position:";
            // 
            // txtRolePosition
            // 
            txtRolePosition.Location = new Point(313, 182);
            txtRolePosition.Name = "txtRolePosition";
            txtRolePosition.Size = new Size(204, 23);
            txtRolePosition.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(256, 213);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 12;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(313, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(313, 240);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(204, 23);
            txtPhoneNumber.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(188, 242);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 15;
            label5.Text = "Phone Number:";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(313, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(442, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(524, 97);
            label6.Name = "label6";
            label6.Size = new Size(15, 19);
            label6.TabIndex = 28;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(523, 128);
            label7.Name = "label7";
            label7.Size = new Size(15, 19);
            label7.TabIndex = 29;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(523, 215);
            label8.Name = "label8";
            label8.Size = new Size(15, 19);
            label8.TabIndex = 30;
            label8.Text = "*";
            // 
            // FormCustomerContactDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 452);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtRolePosition);
            Controls.Add(label3);
            Controls.Add(txtContactLastName);
            Controls.Add(label2);
            Controls.Add(txtContactFirstName);
            Controls.Add(label1);
            Controls.Add(cmbCustomer);
            Controls.Add(lblFormCCDetail);
            Controls.Add(lblCustomerName);
            MaximumSize = new Size(786, 491);
            Name = "FormCustomerContactDetail";
            Text = "FormCustomerContactDetail";
            Load += FormCustomerContactDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblFormCCDetail;
        private ComboBox cmbCustomer;
        private Label label1;
        private TextBox txtContactFirstName;
        private Label label2;
        private TextBox txtContactLastName;
        private Label label3;
        private TextBox txtRolePosition;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}