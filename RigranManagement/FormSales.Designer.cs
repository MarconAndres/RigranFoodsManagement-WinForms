namespace Winform
{
    partial class FormSales
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
            dgvFormSales = new DataGridView();
            btnInsertFormSale = new Button();
            btnUpdateFormSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFormSales).BeginInit();
            SuspendLayout();
            // 
            // dgvFormSales
            // 
            dgvFormSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFormSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormSales.Location = new Point(2, 125);
            dgvFormSales.Name = "dgvFormSales";
            dgvFormSales.Size = new Size(797, 192);
            dgvFormSales.TabIndex = 0;
            // 
            // btnInsertFormSale
            // 
            btnInsertFormSale.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertFormSale.Font = new Font("Segoe UI", 12F);
            btnInsertFormSale.Location = new Point(41, 68);
            btnInsertFormSale.Name = "btnInsertFormSale";
            btnInsertFormSale.Size = new Size(75, 34);
            btnInsertFormSale.TabIndex = 1;
            btnInsertFormSale.Text = "Insert";
            btnInsertFormSale.UseVisualStyleBackColor = true;
            btnInsertFormSale.Click += btnInsertFormSale_Click;
            // 
            // btnUpdateFormSale
            // 
            btnUpdateFormSale.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateFormSale.Font = new Font("Segoe UI", 12F);
            btnUpdateFormSale.Location = new Point(143, 68);
            btnUpdateFormSale.Name = "btnUpdateFormSale";
            btnUpdateFormSale.Size = new Size(75, 34);
            btnUpdateFormSale.TabIndex = 2;
            btnUpdateFormSale.Text = "Update";
            btnUpdateFormSale.UseVisualStyleBackColor = true;
            btnUpdateFormSale.Click += btnUpdateFormSale_Click;
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateFormSale);
            Controls.Add(btnInsertFormSale);
            Controls.Add(dgvFormSales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSales";
            Text = "FormSales";
            Load += FormSales_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvFormSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFormSales;
        private Button btnInsertFormSale;
        private Button btnUpdateFormSale;
    }
}