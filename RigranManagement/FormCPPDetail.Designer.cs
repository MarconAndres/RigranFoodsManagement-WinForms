namespace Winform
{
    partial class FormCPPDetail
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
            lblFormCPPDetail = new Label();
            lblCustomerName = new Label();
            cmbCustomer = new ComboBox();
            label1 = new Label();
            cmbProduct = new ComboBox();
            label2 = new Label();
            txtAnnualVolume = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbPreferredPackaging = new ComboBox();
            cmbPurchaseFrequency = new ComboBox();
            label5 = new Label();
            cmbPriceSensitivity = new ComboBox();
            label6 = new Label();
            txtAlternativeOrigin = new TextBox();
            label7 = new Label();
            cmbQualityStandard = new ComboBox();
            label8 = new Label();
            txtNotes = new TextBox();
            label9 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // lblFormCPPDetail
            // 
            lblFormCPPDetail.AutoSize = true;
            lblFormCPPDetail.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            lblFormCPPDetail.Location = new Point(229, 48);
            lblFormCPPDetail.Name = "lblFormCPPDetail";
            lblFormCPPDetail.Size = new Size(308, 25);
            lblFormCPPDetail.TabIndex = 1;
            lblFormCPPDetail.Text = "Form Customer Product Profile Detail";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(248, 107);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(55, 21);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Name:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(309, 105);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(184, 23);
            cmbCustomer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(236, 137);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 4;
            label1.Text = "Product:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(309, 135);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(184, 23);
            cmbProduct.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(184, 167);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 6;
            label2.Text = "Annual Volume:";
            // 
            // txtAnnualVolume
            // 
            txtAnnualVolume.Location = new Point(309, 165);
            txtAnnualVolume.Name = "txtAnnualVolume";
            txtAnnualVolume.Size = new Size(184, 23);
            txtAnnualVolume.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(499, 167);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 8;
            label3.Text = "(Format: 0.000 Ex: 489.900 tn)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(151, 196);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 9;
            label4.Text = "Preferred Packaging:";
            // 
            // cmbPreferredPackaging
            // 
            cmbPreferredPackaging.FormattingEnabled = true;
            cmbPreferredPackaging.Location = new Point(309, 194);
            cmbPreferredPackaging.Name = "cmbPreferredPackaging";
            cmbPreferredPackaging.Size = new Size(184, 23);
            cmbPreferredPackaging.TabIndex = 10;
            // 
            // cmbPurchaseFrequency
            // 
            cmbPurchaseFrequency.FormattingEnabled = true;
            cmbPurchaseFrequency.Location = new Point(309, 223);
            cmbPurchaseFrequency.Name = "cmbPurchaseFrequency";
            cmbPurchaseFrequency.Size = new Size(184, 23);
            cmbPurchaseFrequency.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(151, 225);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 12;
            label5.Text = "Purchase Frequency:";
            // 
            // cmbPriceSensitivity
            // 
            cmbPriceSensitivity.FormattingEnabled = true;
            cmbPriceSensitivity.Location = new Point(309, 252);
            cmbPriceSensitivity.Name = "cmbPriceSensitivity";
            cmbPriceSensitivity.Size = new Size(184, 23);
            cmbPriceSensitivity.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(181, 254);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 14;
            label6.Text = "Price Sensitivity:";
            // 
            // txtAlternativeOrigin
            // 
            txtAlternativeOrigin.Location = new Point(309, 281);
            txtAlternativeOrigin.Name = "txtAlternativeOrigin";
            txtAlternativeOrigin.Size = new Size(184, 23);
            txtAlternativeOrigin.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(167, 283);
            label7.Name = "label7";
            label7.Size = new Size(136, 21);
            label7.TabIndex = 16;
            label7.Text = "Alternative Origin:";
            // 
            // cmbQualityStandard
            // 
            cmbQualityStandard.FormattingEnabled = true;
            cmbQualityStandard.Location = new Point(309, 310);
            cmbQualityStandard.Name = "cmbQualityStandard";
            cmbQualityStandard.Size = new Size(184, 23);
            cmbQualityStandard.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(174, 312);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 18;
            label8.Text = "Quality Standard:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(309, 339);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(184, 23);
            txtNotes.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(248, 341);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 20;
            label9.Text = "Notes:";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(309, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(418, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(499, 109);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 27;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(499, 139);
            label11.Name = "label11";
            label11.Size = new Size(15, 19);
            label11.TabIndex = 28;
            label11.Text = "*";
            // 
            // FormCPPDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(txtNotes);
            Controls.Add(label8);
            Controls.Add(cmbQualityStandard);
            Controls.Add(label7);
            Controls.Add(txtAlternativeOrigin);
            Controls.Add(label6);
            Controls.Add(cmbPriceSensitivity);
            Controls.Add(label5);
            Controls.Add(cmbPurchaseFrequency);
            Controls.Add(cmbPreferredPackaging);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAnnualVolume);
            Controls.Add(label2);
            Controls.Add(cmbProduct);
            Controls.Add(label1);
            Controls.Add(cmbCustomer);
            Controls.Add(lblCustomerName);
            Controls.Add(lblFormCPPDetail);
            MaximumSize = new Size(816, 547);
            Name = "FormCPPDetail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCPPDetail";
            Load += FormCPPDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormCPPDetail;
        private Label lblCustomerName;
        private ComboBox cmbCustomer;
        private Label label1;
        private ComboBox cmbProduct;
        private Label label2;
        private TextBox txtAnnualVolume;
        private Label label3;
        private Label label4;
        private ComboBox cmbPreferredPackaging;
        private ComboBox cmbPurchaseFrequency;
        private Label label5;
        private ComboBox cmbPriceSensitivity;
        private Label label6;
        private TextBox txtAlternativeOrigin;
        private Label label7;
        private ComboBox cmbQualityStandard;
        private Label label8;
        private TextBox txtNotes;
        private Label label9;
        private Button btnSave;
        private Button btnCancel;
        private Label label10;
        private Label label11;
    }
}