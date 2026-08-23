namespace Winforms
{
    partial class FormProductMaster
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
            dgvProductMaster = new DataGridView();
            txtSearchProductMaster = new TextBox();
            label1 = new Label();
            btnUpdateProductMaster = new Button();
            btnInsertProductMaster = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductMaster).BeginInit();
            SuspendLayout();
            // 
            // dgvProductMaster
            // 
            dgvProductMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductMaster.Location = new Point(3, 126);
            dgvProductMaster.Name = "dgvProductMaster";
            dgvProductMaster.Size = new Size(792, 201);
            dgvProductMaster.TabIndex = 0;
            // 
            // txtSearchProductMaster
            // 
            txtSearchProductMaster.Location = new Point(102, 23);
            txtSearchProductMaster.Name = "txtSearchProductMaster";
            txtSearchProductMaster.Size = new Size(194, 23);
            txtSearchProductMaster.TabIndex = 8;
            txtSearchProductMaster.TextChanged += txtSearchProductMaster_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Search:";
            // 
            // btnUpdateProductMaster
            // 
            btnUpdateProductMaster.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateProductMaster.Font = new Font("Segoe UI", 11F);
            btnUpdateProductMaster.Location = new Point(134, 83);
            btnUpdateProductMaster.Name = "btnUpdateProductMaster";
            btnUpdateProductMaster.Size = new Size(75, 29);
            btnUpdateProductMaster.TabIndex = 6;
            btnUpdateProductMaster.Text = "Update";
            btnUpdateProductMaster.UseVisualStyleBackColor = true;
            btnUpdateProductMaster.Click += btnUpdateProductMaster_Click;
            // 
            // btnInsertProductMaster
            // 
            btnInsertProductMaster.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertProductMaster.Font = new Font("Segoe UI", 11F);
            btnInsertProductMaster.Location = new Point(36, 83);
            btnInsertProductMaster.Name = "btnInsertProductMaster";
            btnInsertProductMaster.Size = new Size(75, 29);
            btnInsertProductMaster.TabIndex = 5;
            btnInsertProductMaster.Text = "Insert";
            btnInsertProductMaster.UseVisualStyleBackColor = true;
            btnInsertProductMaster.Click += btnInsertProductMaster_Click;
            // 
            // FormProductMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchProductMaster);
            Controls.Add(label1);
            Controls.Add(btnUpdateProductMaster);
            Controls.Add(btnInsertProductMaster);
            Controls.Add(dgvProductMaster);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductMaster";
            Text = "FormProductMaster";
            Load += FormProductMaster_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductMaster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductMaster;
        private TextBox txtSearchProductMaster;
        private Label label1;
        private Button btnUpdateProductMaster;
        private Button btnInsertProductMaster;
    }
}