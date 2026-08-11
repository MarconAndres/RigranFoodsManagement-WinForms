namespace Winform
{
    partial class FormCustomerContact
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
            dgvCustomerContact = new DataGridView();
            btnInsertCustomerContact = new Button();
            btnUpdateCustomerContact = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerContact).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerContact
            // 
            dgvCustomerContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomerContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerContact.Location = new Point(2, 121);
            dgvCustomerContact.Name = "dgvCustomerContact";
            dgvCustomerContact.Size = new Size(797, 205);
            dgvCustomerContact.TabIndex = 0;
            // 
            // btnInsertCustomerContact
            // 
            btnInsertCustomerContact.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertCustomerContact.Font = new Font("Segoe UI", 12F);
            btnInsertCustomerContact.Location = new Point(39, 68);
            btnInsertCustomerContact.Name = "btnInsertCustomerContact";
            btnInsertCustomerContact.Size = new Size(75, 34);
            btnInsertCustomerContact.TabIndex = 2;
            btnInsertCustomerContact.Text = "Insert";
            btnInsertCustomerContact.UseVisualStyleBackColor = true;
            btnInsertCustomerContact.Click += btnInsertCustomerContact_Click;
            // 
            // btnUpdateCustomerContact
            // 
            btnUpdateCustomerContact.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateCustomerContact.Font = new Font("Segoe UI", 12F);
            btnUpdateCustomerContact.Location = new Point(153, 68);
            btnUpdateCustomerContact.Name = "btnUpdateCustomerContact";
            btnUpdateCustomerContact.Size = new Size(75, 34);
            btnUpdateCustomerContact.TabIndex = 3;
            btnUpdateCustomerContact.Text = "Update";
            btnUpdateCustomerContact.UseVisualStyleBackColor = true;
            btnUpdateCustomerContact.Click += btnUpdateCustomerContact_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FormCustomerContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnUpdateCustomerContact);
            Controls.Add(btnInsertCustomerContact);
            Controls.Add(dgvCustomerContact);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomerContact";
            Text = "FormCustomerContact";
            Load += FormCustomerContact_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerContact;
        private Button btnInsertCustomerContact;
        private Button btnUpdateCustomerContact;
        private Label label1;
        private TextBox txtSearch;
    }
}