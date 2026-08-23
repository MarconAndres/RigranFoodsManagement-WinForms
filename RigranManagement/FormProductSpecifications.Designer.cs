namespace Winforms
{
    partial class FormProductSpecifications
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
            dgvProductSpecifications = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            btnUpdateProductSpecification = new Button();
            btnInsertProductSpecification = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductSpecifications).BeginInit();
            SuspendLayout();
            // 
            // dgvProductSpecifications
            // 
            dgvProductSpecifications.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductSpecifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductSpecifications.Location = new Point(1, 132);
            dgvProductSpecifications.Name = "dgvProductSpecifications";
            dgvProductSpecifications.Size = new Size(796, 195);
            dgvProductSpecifications.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Search:";
            // 
            // btnUpdateProductSpecification
            // 
            btnUpdateProductSpecification.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateProductSpecification.Font = new Font("Segoe UI", 11F);
            btnUpdateProductSpecification.Location = new Point(131, 85);
            btnUpdateProductSpecification.Name = "btnUpdateProductSpecification";
            btnUpdateProductSpecification.Size = new Size(75, 29);
            btnUpdateProductSpecification.TabIndex = 6;
            btnUpdateProductSpecification.Text = "Update";
            btnUpdateProductSpecification.UseVisualStyleBackColor = true;
            btnUpdateProductSpecification.Click += btnUpdateProductSpecification_Click;
            // 
            // btnInsertProductSpecification
            // 
            btnInsertProductSpecification.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertProductSpecification.Font = new Font("Segoe UI", 11F);
            btnInsertProductSpecification.Location = new Point(34, 85);
            btnInsertProductSpecification.Name = "btnInsertProductSpecification";
            btnInsertProductSpecification.Size = new Size(75, 29);
            btnInsertProductSpecification.TabIndex = 5;
            btnInsertProductSpecification.Text = "Insert";
            btnInsertProductSpecification.UseVisualStyleBackColor = true;
            btnInsertProductSpecification.Click += btnInsertProductSpecification_Click;
            // 
            // FormProductSpecifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnUpdateProductSpecification);
            Controls.Add(btnInsertProductSpecification);
            Controls.Add(dgvProductSpecifications);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductSpecifications";
            Text = "FormProductSpecifications";
            Load += FormProductSpecifications_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductSpecifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductSpecifications;
        private TextBox txtSearch;
        private Label label1;
        private Button btnUpdateProductSpecification;
        private Button btnInsertProductSpecification;
    }
}