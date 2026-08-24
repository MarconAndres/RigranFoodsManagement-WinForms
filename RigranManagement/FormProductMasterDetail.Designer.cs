namespace Winforms
{
    partial class FormProductMasterDetail
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
            label1 = new Label();
            cmbProductType = new ComboBox();
            lbl1 = new Label();
            txtProductTypeName = new TextBox();
            lblCustomerName = new Label();
            lblFormCustomerDetail = new Label();
            btnPMDetailCancel = new Button();
            btnPMDetailSave = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(566, 207);
            label1.Name = "label1";
            label1.Size = new Size(17, 21);
            label1.TabIndex = 32;
            label1.Text = "*";
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(352, 171);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(208, 23);
            cmbProductType.TabIndex = 31;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(243, 173);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(103, 21);
            lbl1.TabIndex = 30;
            lbl1.Text = "Product Type:";
            // 
            // txtProductTypeName
            // 
            txtProductTypeName.Location = new Point(352, 205);
            txtProductTypeName.Name = "txtProductTypeName";
            txtProductTypeName.Size = new Size(208, 23);
            txtProductTypeName.TabIndex = 29;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(291, 207);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(55, 21);
            lblCustomerName.TabIndex = 28;
            lblCustomerName.Text = "Name:";
            // 
            // lblFormCustomerDetail
            // 
            lblFormCustomerDetail.AutoSize = true;
            lblFormCustomerDetail.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            lblFormCustomerDetail.Location = new Point(295, 102);
            lblFormCustomerDetail.Name = "lblFormCustomerDetail";
            lblFormCustomerDetail.Size = new Size(186, 25);
            lblFormCustomerDetail.TabIndex = 27;
            lblFormCustomerDetail.Text = "Form Customer Detail";
            // 
            // btnPMDetailCancel
            // 
            btnPMDetailCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPMDetailCancel.Font = new Font("Segoe UI", 12F);
            btnPMDetailCancel.Location = new Point(448, 278);
            btnPMDetailCancel.Name = "btnPMDetailCancel";
            btnPMDetailCancel.Size = new Size(75, 30);
            btnPMDetailCancel.TabIndex = 34;
            btnPMDetailCancel.Text = "Cancel";
            btnPMDetailCancel.UseVisualStyleBackColor = true;
            btnPMDetailCancel.Click += btnPMDetailCancel_Click;
            // 
            // btnPMDetailSave
            // 
            btnPMDetailSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnPMDetailSave.Font = new Font("Segoe UI", 12F);
            btnPMDetailSave.Location = new Point(283, 278);
            btnPMDetailSave.Name = "btnPMDetailSave";
            btnPMDetailSave.Size = new Size(75, 30);
            btnPMDetailSave.TabIndex = 33;
            btnPMDetailSave.Text = "Save";
            btnPMDetailSave.UseVisualStyleBackColor = true;
            btnPMDetailSave.Click += btnPMDetailSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(566, 173);
            label2.Name = "label2";
            label2.Size = new Size(17, 21);
            label2.TabIndex = 35;
            label2.Text = "*";
            // 
            // FormProductMasterDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnPMDetailCancel);
            Controls.Add(btnPMDetailSave);
            Controls.Add(label1);
            Controls.Add(cmbProductType);
            Controls.Add(lbl1);
            Controls.Add(txtProductTypeName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblFormCustomerDetail);
            MaximumSize = new Size(816, 489);
            Name = "FormProductMasterDetail";
            ShowInTaskbar = false;
            Text = "FormProductMasterDetail";
            Load += FormProductMasterDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProductType;
        private Label lbl1;
        private TextBox txtProductTypeName;
        private Label lblCustomerName;
        private Label lblFormCustomerDetail;
        private Button btnPMDetailCancel;
        private Button btnPMDetailSave;
        private Label label2;
    }
}