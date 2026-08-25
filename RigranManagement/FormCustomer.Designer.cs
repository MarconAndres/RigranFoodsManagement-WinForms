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
            label1 = new Label();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            btnIcedFilter = new Button();
            btnColdFilter = new Button();
            btnWarmFilter = new Button();
            btnHotFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            groupBox1.SuspendLayout();
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
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // btnInsertCustomer
            // 
            btnInsertCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnInsertCustomer.Font = new Font("Segoe UI", 11F);
            btnInsertCustomer.Location = new Point(30, 92);
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
            btnUpdateCustomer.Location = new Point(128, 92);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(75, 29);
            btnUpdateCustomer.TabIndex = 2;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(96, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(btnIcedFilter);
            groupBox1.Controls.Add(btnColdFilter);
            groupBox1.Controls.Add(btnWarmFilter);
            groupBox1.Controls.Add(btnHotFilter);
            groupBox1.Location = new Point(531, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 59);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temperature Filter";
            // 
            // btnIcedFilter
            // 
            btnIcedFilter.BackColor = Color.RoyalBlue;
            btnIcedFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnIcedFilter.Font = new Font("Segoe UI", 11F);
            btnIcedFilter.Location = new Point(192, 22);
            btnIcedFilter.Name = "btnIcedFilter";
            btnIcedFilter.Size = new Size(56, 29);
            btnIcedFilter.TabIndex = 5;
            btnIcedFilter.Text = "Iced";
            btnIcedFilter.UseVisualStyleBackColor = false;
            btnIcedFilter.Click += btnIcedFilter_Click;
            // 
            // btnColdFilter
            // 
            btnColdFilter.BackColor = Color.DeepSkyBlue;
            btnColdFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnColdFilter.Font = new Font("Segoe UI", 11F);
            btnColdFilter.Location = new Point(130, 22);
            btnColdFilter.Name = "btnColdFilter";
            btnColdFilter.Size = new Size(56, 29);
            btnColdFilter.TabIndex = 4;
            btnColdFilter.Text = "Cold";
            btnColdFilter.UseVisualStyleBackColor = false;
            btnColdFilter.Click += btnColdFilter_Click;
            // 
            // btnWarmFilter
            // 
            btnWarmFilter.BackColor = Color.Khaki;
            btnWarmFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnWarmFilter.Font = new Font("Segoe UI", 11F);
            btnWarmFilter.Location = new Point(68, 22);
            btnWarmFilter.Name = "btnWarmFilter";
            btnWarmFilter.Size = new Size(56, 29);
            btnWarmFilter.TabIndex = 3;
            btnWarmFilter.Text = "Warm";
            btnWarmFilter.UseVisualStyleBackColor = false;
            btnWarmFilter.Click += btnWarmFilter_Click;
            // 
            // btnHotFilter
            // 
            btnHotFilter.BackColor = Color.Tomato;
            btnHotFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnHotFilter.Font = new Font("Segoe UI", 11F);
            btnHotFilter.ForeColor = SystemColors.ControlText;
            btnHotFilter.Location = new Point(6, 22);
            btnHotFilter.Name = "btnHotFilter";
            btnHotFilter.Size = new Size(56, 29);
            btnHotFilter.TabIndex = 2;
            btnHotFilter.Text = "Hot";
            btnHotFilter.UseVisualStyleBackColor = false;
            btnHotFilter.Click += btnHotFilter_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(btnInsertCustomer);
            Controls.Add(dgvCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private Button btnInsertCustomer;
        private Button btnUpdateCustomer;
        private Label label1;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Button btnColdFilter;
        private Button btnWarmFilter;
        private Button btnHotFilter;
        private Button btnIcedFilter;
    }
}