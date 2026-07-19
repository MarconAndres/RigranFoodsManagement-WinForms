namespace Winform
{
    partial class FormShipmentsDetail
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
            label1 = new Label();
            labelIdSale = new Label();
            cmbIdSale = new ComboBox();
            labelstatus = new Label();
            cmbStatus = new ComboBox();
            labelBookingNum = new Label();
            txtBookingNumber = new TextBox();
            labelContainerNum = new Label();
            txtContainerNumber = new TextBox();
            labelcontainerType = new Label();
            cmbContainerType = new ComboBox();
            labelshippingLine = new Label();
            txtShippingLine = new TextBox();
            labelPortLoading = new Label();
            cmbPortOfLoading = new ComboBox();
            labelPortDestination = new Label();
            cmbPortOfDestination = new ComboBox();
            labelETD = new Label();
            labelATD = new Label();
            dtpETD = new DateTimePicker();
            dtpATD = new DateTimePicker();
            labelETA = new Label();
            dtpETA = new DateTimePicker();
            labelATA = new Label();
            dtpATA = new DateTimePicker();
            labelFreeDays = new Label();
            txtFreeDays = new TextBox();
            labelDHLNumber = new Label();
            labelBLapproved = new Label();
            txtDHLNumber = new TextBox();
            labelHasClaim = new Label();
            labelClaimNotes = new Label();
            txtClaimNotes = new TextBox();
            labelNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panelBLApproved = new Panel();
            rbBLApprovedNo = new RadioButton();
            rdBLApprovedYes = new RadioButton();
            panelHasClaim = new Panel();
            rbHasCliamNo = new RadioButton();
            rbHasClaimYes = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panelBLApproved.SuspendLayout();
            panelHasClaim.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            label1.Location = new Point(276, 34);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "Form Shipments Detail";
            // 
            // labelIdSale
            // 
            labelIdSale.AutoSize = true;
            labelIdSale.Font = new Font("Segoe UI", 12F);
            labelIdSale.Location = new Point(236, 86);
            labelIdSale.Name = "labelIdSale";
            labelIdSale.Size = new Size(61, 21);
            labelIdSale.TabIndex = 1;
            labelIdSale.Text = "ID Sale:";
            // 
            // cmbIdSale
            // 
            cmbIdSale.FormattingEnabled = true;
            cmbIdSale.Location = new Point(318, 84);
            cmbIdSale.Name = "cmbIdSale";
            cmbIdSale.Size = new Size(200, 23);
            cmbIdSale.TabIndex = 2;
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.Font = new Font("Segoe UI", 12F);
            labelstatus.Location = new Point(242, 122);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(55, 21);
            labelstatus.TabIndex = 3;
            labelstatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(318, 122);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 4;
            // 
            // labelBookingNum
            // 
            labelBookingNum.AutoSize = true;
            labelBookingNum.Font = new Font("Segoe UI", 12F);
            labelBookingNum.Location = new Point(165, 158);
            labelBookingNum.Name = "labelBookingNum";
            labelBookingNum.Size = new Size(132, 21);
            labelBookingNum.TabIndex = 5;
            labelBookingNum.Text = "Booking Number:";
            // 
            // txtBookingNumber
            // 
            txtBookingNumber.Location = new Point(318, 158);
            txtBookingNumber.Name = "txtBookingNumber";
            txtBookingNumber.Size = new Size(200, 23);
            txtBookingNumber.TabIndex = 6;
            // 
            // labelContainerNum
            // 
            labelContainerNum.AutoSize = true;
            labelContainerNum.Font = new Font("Segoe UI", 12F);
            labelContainerNum.Location = new Point(154, 192);
            labelContainerNum.Name = "labelContainerNum";
            labelContainerNum.Size = new Size(143, 21);
            labelContainerNum.TabIndex = 7;
            labelContainerNum.Text = "Container Number:";
            // 
            // txtContainerNumber
            // 
            txtContainerNumber.Location = new Point(318, 192);
            txtContainerNumber.Name = "txtContainerNumber";
            txtContainerNumber.Size = new Size(200, 23);
            txtContainerNumber.TabIndex = 8;
            // 
            // labelcontainerType
            // 
            labelcontainerType.AutoSize = true;
            labelcontainerType.Font = new Font("Segoe UI", 12F);
            labelcontainerType.Location = new Point(180, 225);
            labelcontainerType.Name = "labelcontainerType";
            labelcontainerType.Size = new Size(117, 21);
            labelcontainerType.TabIndex = 9;
            labelcontainerType.Text = "Container Type:";
            // 
            // cmbContainerType
            // 
            cmbContainerType.FormattingEnabled = true;
            cmbContainerType.Location = new Point(318, 223);
            cmbContainerType.Name = "cmbContainerType";
            cmbContainerType.Size = new Size(200, 23);
            cmbContainerType.TabIndex = 10;
            // 
            // labelshippingLine
            // 
            labelshippingLine.AutoSize = true;
            labelshippingLine.Font = new Font("Segoe UI", 12F);
            labelshippingLine.Location = new Point(189, 257);
            labelshippingLine.Name = "labelshippingLine";
            labelshippingLine.Size = new Size(108, 21);
            labelshippingLine.TabIndex = 11;
            labelshippingLine.Text = "Shipping Line:";
            // 
            // txtShippingLine
            // 
            txtShippingLine.Location = new Point(318, 257);
            txtShippingLine.Name = "txtShippingLine";
            txtShippingLine.Size = new Size(200, 23);
            txtShippingLine.TabIndex = 12;
            // 
            // labelPortLoading
            // 
            labelPortLoading.AutoSize = true;
            labelPortLoading.Font = new Font("Segoe UI", 12F);
            labelPortLoading.Location = new Point(189, 291);
            labelPortLoading.Name = "labelPortLoading";
            labelPortLoading.Size = new Size(119, 21);
            labelPortLoading.TabIndex = 13;
            labelPortLoading.Text = "Port of Loading:";
            // 
            // cmbPortOfLoading
            // 
            cmbPortOfLoading.FormattingEnabled = true;
            cmbPortOfLoading.Location = new Point(318, 291);
            cmbPortOfLoading.Name = "cmbPortOfLoading";
            cmbPortOfLoading.Size = new Size(200, 23);
            cmbPortOfLoading.TabIndex = 14;
            // 
            // labelPortDestination
            // 
            labelPortDestination.AutoSize = true;
            labelPortDestination.Font = new Font("Segoe UI", 12F);
            labelPortDestination.Location = new Point(165, 328);
            labelPortDestination.Name = "labelPortDestination";
            labelPortDestination.Size = new Size(142, 21);
            labelPortDestination.TabIndex = 15;
            labelPortDestination.Text = "Port of Destination:";
            // 
            // cmbPortOfDestination
            // 
            cmbPortOfDestination.FormattingEnabled = true;
            cmbPortOfDestination.Location = new Point(318, 328);
            cmbPortOfDestination.Name = "cmbPortOfDestination";
            cmbPortOfDestination.Size = new Size(200, 23);
            cmbPortOfDestination.TabIndex = 16;
            // 
            // labelETD
            // 
            labelETD.AutoSize = true;
            labelETD.Font = new Font("Segoe UI", 12F);
            labelETD.Location = new Point(267, 364);
            labelETD.Name = "labelETD";
            labelETD.Size = new Size(40, 21);
            labelETD.TabIndex = 17;
            labelETD.Text = "ETD:";
            // 
            // labelATD
            // 
            labelATD.AutoSize = true;
            labelATD.Font = new Font("Segoe UI", 12F);
            labelATD.Location = new Point(266, 398);
            labelATD.Name = "labelATD";
            labelATD.Size = new Size(41, 21);
            labelATD.TabIndex = 19;
            labelATD.Text = "ATD:";
            // 
            // dtpETD
            // 
            dtpETD.Location = new Point(318, 364);
            dtpETD.Name = "dtpETD";
            dtpETD.Size = new Size(200, 23);
            dtpETD.TabIndex = 18;
            // 
            // dtpATD
            // 
            dtpATD.Location = new Point(318, 402);
            dtpATD.Name = "dtpATD";
            dtpATD.Size = new Size(200, 23);
            dtpATD.TabIndex = 20;
            // 
            // labelETA
            // 
            labelETA.AutoSize = true;
            labelETA.Font = new Font("Segoe UI", 12F);
            labelETA.Location = new Point(269, 431);
            labelETA.Name = "labelETA";
            labelETA.Size = new Size(38, 21);
            labelETA.TabIndex = 21;
            labelETA.Text = "ETA:";
            // 
            // dtpETA
            // 
            dtpETA.Location = new Point(318, 431);
            dtpETA.Name = "dtpETA";
            dtpETA.Size = new Size(200, 23);
            dtpETA.TabIndex = 22;
            // 
            // labelATA
            // 
            labelATA.AutoSize = true;
            labelATA.Font = new Font("Segoe UI", 12F);
            labelATA.Location = new Point(268, 465);
            labelATA.Name = "labelATA";
            labelATA.Size = new Size(39, 21);
            labelATA.TabIndex = 23;
            labelATA.Text = "ATA:";
            // 
            // dtpATA
            // 
            dtpATA.Location = new Point(318, 465);
            dtpATA.Name = "dtpATA";
            dtpATA.Size = new Size(200, 23);
            dtpATA.TabIndex = 24;
            // 
            // labelFreeDays
            // 
            labelFreeDays.AutoSize = true;
            labelFreeDays.Font = new Font("Segoe UI", 12F);
            labelFreeDays.Location = new Point(177, 500);
            labelFreeDays.Name = "labelFreeDays";
            labelFreeDays.Size = new Size(130, 21);
            labelFreeDays.TabIndex = 25;
            labelFreeDays.Text = "Free Days at Port:";
            // 
            // txtFreeDays
            // 
            txtFreeDays.Location = new Point(318, 500);
            txtFreeDays.Name = "txtFreeDays";
            txtFreeDays.Size = new Size(200, 23);
            txtFreeDays.TabIndex = 26;
            // 
            // labelDHLNumber
            // 
            labelDHLNumber.AutoSize = true;
            labelDHLNumber.Font = new Font("Segoe UI", 12F);
            labelDHLNumber.Location = new Point(202, 568);
            labelDHLNumber.Name = "labelDHLNumber";
            labelDHLNumber.Size = new Size(105, 21);
            labelDHLNumber.TabIndex = 27;
            labelDHLNumber.Text = "DHL Number:";
            // 
            // labelBLapproved
            // 
            labelBLapproved.AutoSize = true;
            labelBLapproved.Font = new Font("Segoe UI", 12F);
            labelBLapproved.Location = new Point(205, 535);
            labelBLapproved.Name = "labelBLapproved";
            labelBLapproved.Size = new Size(102, 21);
            labelBLapproved.TabIndex = 28;
            labelBLapproved.Text = "BL Approved:";
            // 
            // txtDHLNumber
            // 
            txtDHLNumber.Location = new Point(318, 566);
            txtDHLNumber.Name = "txtDHLNumber";
            txtDHLNumber.Size = new Size(200, 23);
            txtDHLNumber.TabIndex = 31;
            // 
            // labelHasClaim
            // 
            labelHasClaim.AutoSize = true;
            labelHasClaim.Font = new Font("Segoe UI", 12F);
            labelHasClaim.Location = new Point(224, 601);
            labelHasClaim.Name = "labelHasClaim";
            labelHasClaim.Size = new Size(83, 21);
            labelHasClaim.TabIndex = 32;
            labelHasClaim.Text = "Has Claim:";
            // 
            // labelClaimNotes
            // 
            labelClaimNotes.AutoSize = true;
            labelClaimNotes.Font = new Font("Segoe UI", 12F);
            labelClaimNotes.Location = new Point(209, 631);
            labelClaimNotes.Name = "labelClaimNotes";
            labelClaimNotes.Size = new Size(98, 21);
            labelClaimNotes.TabIndex = 35;
            labelClaimNotes.Text = "Claim Notes:";
            // 
            // txtClaimNotes
            // 
            txtClaimNotes.Location = new Point(318, 631);
            txtClaimNotes.Name = "txtClaimNotes";
            txtClaimNotes.Size = new Size(200, 23);
            txtClaimNotes.TabIndex = 36;
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Segoe UI", 12F);
            labelNotes.Location = new Point(253, 665);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(54, 21);
            labelNotes.TabIndex = 37;
            labelNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(318, 665);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(200, 23);
            txtNotes.TabIndex = 38;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(290, 741);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 34);
            btnSave.TabIndex = 39;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(443, 741);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 34);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelBLApproved
            // 
            panelBLApproved.Controls.Add(rbBLApprovedNo);
            panelBLApproved.Controls.Add(rdBLApprovedYes);
            panelBLApproved.Location = new Point(318, 529);
            panelBLApproved.Name = "panelBLApproved";
            panelBLApproved.Size = new Size(200, 31);
            panelBLApproved.TabIndex = 42;
            // 
            // rbBLApprovedNo
            // 
            rbBLApprovedNo.AutoSize = true;
            rbBLApprovedNo.Location = new Point(109, 6);
            rbBLApprovedNo.Name = "rbBLApprovedNo";
            rbBLApprovedNo.Size = new Size(41, 19);
            rbBLApprovedNo.TabIndex = 1;
            rbBLApprovedNo.TabStop = true;
            rbBLApprovedNo.Text = "No";
            rbBLApprovedNo.UseVisualStyleBackColor = true;
            // 
            // rdBLApprovedYes
            // 
            rdBLApprovedYes.AutoSize = true;
            rdBLApprovedYes.Location = new Point(29, 6);
            rdBLApprovedYes.Name = "rdBLApprovedYes";
            rdBLApprovedYes.Size = new Size(42, 19);
            rdBLApprovedYes.TabIndex = 0;
            rdBLApprovedYes.TabStop = true;
            rdBLApprovedYes.Text = "Yes";
            rdBLApprovedYes.UseVisualStyleBackColor = true;
            // 
            // panelHasClaim
            // 
            panelHasClaim.Controls.Add(rbHasCliamNo);
            panelHasClaim.Controls.Add(rbHasClaimYes);
            panelHasClaim.Location = new Point(318, 595);
            panelHasClaim.Name = "panelHasClaim";
            panelHasClaim.Size = new Size(200, 31);
            panelHasClaim.TabIndex = 43;
            // 
            // rbHasCliamNo
            // 
            rbHasCliamNo.AutoSize = true;
            rbHasCliamNo.Location = new Point(109, 8);
            rbHasCliamNo.Name = "rbHasCliamNo";
            rbHasCliamNo.Size = new Size(41, 19);
            rbHasCliamNo.TabIndex = 2;
            rbHasCliamNo.TabStop = true;
            rbHasCliamNo.Text = "No";
            rbHasCliamNo.UseVisualStyleBackColor = true;
            // 
            // rbHasClaimYes
            // 
            rbHasClaimYes.AutoSize = true;
            rbHasClaimYes.Location = new Point(29, 6);
            rbHasClaimYes.Name = "rbHasClaimYes";
            rbHasClaimYes.Size = new Size(42, 19);
            rbHasClaimYes.TabIndex = 1;
            rbHasClaimYes.TabStop = true;
            rbHasClaimYes.Text = "Yes";
            rbHasClaimYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(524, 87);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 44;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(524, 125);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 45;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(524, 161);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 46;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(524, 260);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 47;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(524, 294);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 48;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(524, 331);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 49;
            label7.Text = "*";
            // 
            // FormShipmentsDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 800);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelHasClaim);
            Controls.Add(panelBLApproved);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(labelNotes);
            Controls.Add(txtClaimNotes);
            Controls.Add(labelClaimNotes);
            Controls.Add(labelHasClaim);
            Controls.Add(txtDHLNumber);
            Controls.Add(labelBLapproved);
            Controls.Add(labelDHLNumber);
            Controls.Add(txtFreeDays);
            Controls.Add(labelFreeDays);
            Controls.Add(dtpATA);
            Controls.Add(labelATA);
            Controls.Add(dtpETA);
            Controls.Add(labelETA);
            Controls.Add(dtpATD);
            Controls.Add(labelATD);
            Controls.Add(dtpETD);
            Controls.Add(labelETD);
            Controls.Add(cmbPortOfDestination);
            Controls.Add(labelPortDestination);
            Controls.Add(cmbPortOfLoading);
            Controls.Add(labelPortLoading);
            Controls.Add(txtShippingLine);
            Controls.Add(labelshippingLine);
            Controls.Add(cmbContainerType);
            Controls.Add(labelcontainerType);
            Controls.Add(txtContainerNumber);
            Controls.Add(labelContainerNum);
            Controls.Add(txtBookingNumber);
            Controls.Add(labelBookingNum);
            Controls.Add(cmbStatus);
            Controls.Add(labelstatus);
            Controls.Add(cmbIdSale);
            Controls.Add(labelIdSale);
            Controls.Add(label1);
            MaximumSize = new Size(816, 839);
            Name = "FormShipmentsDetail";
            Text = "FormShipmentsDetail";
            Load += FormShipmentsDetail_Load;
            panelBLApproved.ResumeLayout(false);
            panelBLApproved.PerformLayout();
            panelHasClaim.ResumeLayout(false);
            panelHasClaim.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelIdSale;
        private ComboBox cmbIdSale;
        private Label labelstatus;
        private ComboBox cmbStatus;
        private Label labelBookingNum;
        private TextBox txtBookingNumber;
        private Label labelContainerNum;
        private TextBox txtContainerNumber;
        private Label labelcontainerType;
        private ComboBox cmbContainerType;
        private Label labelshippingLine;
        private TextBox txtShippingLine;
        private Label labelPortLoading;
        private ComboBox cmbPortOfLoading;
        private Label labelPortDestination;
        private ComboBox cmbPortOfDestination;
        private Label labelETD;
        private Label labelATD;
        private DateTimePicker dtpETD;
        private DateTimePicker dtpATD;
        private Label labelETA;
        private DateTimePicker dtpETA;
        private Label labelATA;
        private DateTimePicker dtpATA;
        private Label labelFreeDays;
        private TextBox txtFreeDays;
        private Label labelDHLNumber;
        private Label labelBLapproved;
        private TextBox txtDHLNumber;
        private Label labelHasClaim;
        private Label labelClaimNotes;
        private TextBox txtClaimNotes;
        private Label labelNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelBLApproved;
        private RadioButton rbBLApprovedNo;
        private RadioButton rdBLApprovedYes;
        private Panel panelHasClaim;
        private RadioButton rbHasClaimYes;
        private RadioButton rbHasCliamNo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}