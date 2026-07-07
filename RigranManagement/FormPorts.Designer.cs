namespace Winform
{
    partial class FormPorts
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
            dgvPorts = new DataGridView();
            btnInsertFormPorts = new Button();
            btnUpdateFormPorts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPorts).BeginInit();
            SuspendLayout();
            // 
            // dgvPorts
            // 
            dgvPorts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPorts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorts.Location = new Point(2, 129);
            dgvPorts.Name = "dgvPorts";
            dgvPorts.Size = new Size(800, 168);
            dgvPorts.TabIndex = 0;
            // 
            // btnInsertFormPorts
            // 
            btnInsertFormPorts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertFormPorts.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertFormPorts.Font = new Font("Segoe UI", 11F);
            btnInsertFormPorts.Location = new Point(292, 331);
            btnInsertFormPorts.Name = "btnInsertFormPorts";
            btnInsertFormPorts.Size = new Size(75, 29);
            btnInsertFormPorts.TabIndex = 1;
            btnInsertFormPorts.Text = "Insert";
            btnInsertFormPorts.UseVisualStyleBackColor = true;
            btnInsertFormPorts.Click += btnInsertFormPorts_Click;
            // 
            // btnUpdateFormPorts
            // 
            btnUpdateFormPorts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateFormPorts.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdateFormPorts.Font = new Font("Segoe UI", 11F);
            btnUpdateFormPorts.Location = new Point(415, 331);
            btnUpdateFormPorts.Name = "btnUpdateFormPorts";
            btnUpdateFormPorts.Size = new Size(75, 29);
            btnUpdateFormPorts.TabIndex = 2;
            btnUpdateFormPorts.Text = "Update";
            btnUpdateFormPorts.UseVisualStyleBackColor = true;
            btnUpdateFormPorts.Click += btnUpdateFormPorts_Click;
            // 
            // FormPorts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateFormPorts);
            Controls.Add(btnInsertFormPorts);
            Controls.Add(dgvPorts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPorts";
            Text = "FormPorts";
            Load += FormPorts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPorts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPorts;
        private Button btnInsertFormPorts;
        private Button btnUpdateFormPorts;
    }
}