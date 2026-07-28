namespace Winform
{
    partial class FormShipments
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
            dgvShipments = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
            SuspendLayout();
            // 
            // dgvShipments
            // 
            dgvShipments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipments.Location = new Point(3, 135);
            dgvShipments.Name = "dgvShipments";
            dgvShipments.Size = new Size(793, 189);
            dgvShipments.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsert.Font = new Font("Segoe UI", 12F);
            btnInsert.Location = new Point(32, 86);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 34);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(138, 86);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormShipments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvShipments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormShipments";
            Text = "FormShipments";
            Load += FormShipments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShipments;
        private Button btnInsert;
        private Button btnUpdate;
    }
}