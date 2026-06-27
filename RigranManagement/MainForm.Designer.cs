namespace RigranManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGVMain = new DataGridView();
            GBCountry = new GroupBox();
            buttonInsertCountry = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVMain).BeginInit();
            GBCountry.SuspendLayout();
            SuspendLayout();
            // 
            // DGVMain
            // 
            DGVMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMain.Location = new Point(12, 195);
            DGVMain.Name = "DGVMain";
            DGVMain.Size = new Size(1117, 225);
            DGVMain.TabIndex = 0;
            DGVMain.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // GBCountry
            // 
            GBCountry.Controls.Add(buttonInsertCountry);
            GBCountry.Location = new Point(941, 472);
            GBCountry.Name = "GBCountry";
            GBCountry.Size = new Size(112, 77);
            GBCountry.TabIndex = 1;
            GBCountry.TabStop = false;
            GBCountry.Text = "Country";
            GBCountry.Enter += this.groupBox1_Enter;
            // 
            // buttonInsertCountry
            // 
            buttonInsertCountry.Location = new Point(17, 31);
            buttonInsertCountry.Name = "buttonInsertCountry";
            buttonInsertCountry.Size = new Size(75, 23);
            buttonInsertCountry.TabIndex = 0;
            buttonInsertCountry.Text = "Insert";
            buttonInsertCountry.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 629);
            Controls.Add(GBCountry);
            Controls.Add(DGVMain);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGVMain).EndInit();
            GBCountry.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVMain;
        private GroupBox GBCountry;
        private Button buttonInsertCountry;
    }
}
