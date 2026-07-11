namespace Winform
{
    partial class FormCustomer
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
            dgvCustomer = new DataGridView();
            btnInsertCustomer = new Button();
            btnUpdateCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(1, 138);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(798, 175);
            dgvCustomer.TabIndex = 0;
            // 
            // btnInsertCustomer
            // 
            btnInsertCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertCustomer.Font = new Font("Segoe UI", 11F);
            btnInsertCustomer.Location = new Point(12, 92);
            btnInsertCustomer.Name = "btnInsertCustomer";
            btnInsertCustomer.Size = new Size(75, 29);
            btnInsertCustomer.TabIndex = 1;
            btnInsertCustomer.Text = "Insert";
            btnInsertCustomer.UseVisualStyleBackColor = true;
            btnInsertCustomer.Click += btnInsertCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateCustomer.Font = new Font("Segoe UI", 11F);
            btnUpdateCustomer.Location = new Point(111, 92);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(75, 29);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnInsertCustomer);
            Controls.Add(dgvCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomer;
        private Button btnInsertCustomer;
        private Button btnUpdateCustomer;
    }
}