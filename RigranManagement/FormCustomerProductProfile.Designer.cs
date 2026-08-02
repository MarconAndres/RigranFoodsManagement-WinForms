namespace Winform
{
    partial class FormCustomerProductProfile
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
            dgvCustomerProductProfile = new DataGridView();
            btnInsertCPP = new Button();
            btnUpdateCPP = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerProductProfile).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerProductProfile
            // 
            dgvCustomerProductProfile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomerProductProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerProductProfile.Location = new Point(1, 138);
            dgvCustomerProductProfile.Name = "dgvCustomerProductProfile";
            dgvCustomerProductProfile.Size = new Size(798, 170);
            dgvCustomerProductProfile.TabIndex = 0;
            // 
            // btnInsertCPP
            // 
            btnInsertCPP.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertCPP.Font = new Font("Segoe UI", 11F);
            btnInsertCPP.Location = new Point(12, 87);
            btnInsertCPP.Name = "btnInsertCPP";
            btnInsertCPP.Size = new Size(75, 29);
            btnInsertCPP.TabIndex = 2;
            btnInsertCPP.Text = "Insert";
            btnInsertCPP.UseVisualStyleBackColor = true;
            btnInsertCPP.Click += btnInsertCPP_Click;
            // 
            // btnUpdateCPP
            // 
            btnUpdateCPP.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateCPP.Font = new Font("Segoe UI", 11F);
            btnUpdateCPP.Location = new Point(115, 87);
            btnUpdateCPP.Name = "btnUpdateCPP";
            btnUpdateCPP.Size = new Size(75, 29);
            btnUpdateCPP.TabIndex = 3;
            btnUpdateCPP.Text = "Update";
            btnUpdateCPP.UseVisualStyleBackColor = true;
            btnUpdateCPP.Click += btnUpdateCPP_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(93, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 6;
            label1.Text = "Search:";
            // 
            // FormCustomerProductProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdateCPP);
            Controls.Add(btnInsertCPP);
            Controls.Add(dgvCustomerProductProfile);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomerProductProfile";
            Text = "FormCustomerProductProfile";
            Load += FormCustomerProductProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerProductProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerProductProfile;
        private Button btnInsertCPP;
        private Button btnUpdateCPP;
        private TextBox txtSearch;
        private Label label1;
    }
}