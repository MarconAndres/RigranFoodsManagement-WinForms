namespace Winform
{
    partial class FormSaleDetail
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
            labelCustomer = new Label();
            cmbCustomer = new ComboBox();
            labelProduct = new Label();
            cmbProduct = new ComboBox();
            labelStatus = new Label();
            cmbStatus = new ComboBox();
            labelContractDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelShipper = new Label();
            txtShipper = new TextBox();
            labelSeller = new Label();
            txtSeller = new TextBox();
            labelCropYear = new Label();
            txtCropYear = new TextBox();
            labelQuantity = new Label();
            txtQuantity = new TextBox();
            labelFormatQua = new Label();
            labelPricePerTone = new Label();
            txtPricePerTon = new TextBox();
            labelFormatPrice = new Label();
            labelCurrency = new Label();
            cmbCurrency = new ComboBox();
            labelIncoterm = new Label();
            cmbIncoterm = new ComboBox();
            labelMethodOfPayment = new Label();
            cmbMethodOfPayment = new ComboBox();
            labelPortOfLoading = new Label();
            cmbPortOfLoading = new ComboBox();
            labelPortOfDestination = new Label();
            cmbPortOfDestination = new ComboBox();
            labelBrokerCom = new Label();
            txtBrokerComission = new TextBox();
            labelBrokerComFormat = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            cmbSize = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Underline);
            label1.Location = new Point(353, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Form Sale Detail";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 12F);
            labelCustomer.Location = new Point(233, 101);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(81, 21);
            labelCustomer.TabIndex = 1;
            labelCustomer.Text = "Customer:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(328, 99);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(195, 23);
            cmbCustomer.TabIndex = 2;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI", 12F);
            labelProduct.Location = new Point(247, 132);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(67, 21);
            labelProduct.TabIndex = 3;
            labelProduct.Text = "Product:";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(328, 132);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(195, 23);
            cmbProduct.TabIndex = 4;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.Location = new Point(259, 194);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(55, 21);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(328, 194);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(195, 23);
            cmbStatus.TabIndex = 6;
            // 
            // labelContractDate
            // 
            labelContractDate.AutoSize = true;
            labelContractDate.Font = new Font("Segoe UI", 12F);
            labelContractDate.Location = new Point(206, 230);
            labelContractDate.Name = "labelContractDate";
            labelContractDate.Size = new Size(108, 21);
            labelContractDate.TabIndex = 7;
            labelContractDate.Text = "Contract Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(328, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // labelShipper
            // 
            labelShipper.AutoSize = true;
            labelShipper.Font = new Font("Segoe UI", 12F);
            labelShipper.Location = new Point(247, 263);
            labelShipper.Name = "labelShipper";
            labelShipper.Size = new Size(67, 21);
            labelShipper.TabIndex = 9;
            labelShipper.Text = "Shipper:";
            // 
            // txtShipper
            // 
            txtShipper.Location = new Point(328, 263);
            txtShipper.Name = "txtShipper";
            txtShipper.Size = new Size(195, 23);
            txtShipper.TabIndex = 10;
            // 
            // labelSeller
            // 
            labelSeller.AutoSize = true;
            labelSeller.Font = new Font("Segoe UI", 12F);
            labelSeller.Location = new Point(262, 295);
            labelSeller.Name = "labelSeller";
            labelSeller.Size = new Size(52, 21);
            labelSeller.TabIndex = 11;
            labelSeller.Text = "Seller:";
            // 
            // txtSeller
            // 
            txtSeller.Location = new Point(328, 295);
            txtSeller.Name = "txtSeller";
            txtSeller.Size = new Size(195, 23);
            txtSeller.TabIndex = 12;
            // 
            // labelCropYear
            // 
            labelCropYear.AutoSize = true;
            labelCropYear.Font = new Font("Segoe UI", 12F);
            labelCropYear.Location = new Point(233, 328);
            labelCropYear.Name = "labelCropYear";
            labelCropYear.Size = new Size(81, 21);
            labelCropYear.TabIndex = 13;
            labelCropYear.Text = "Crop Year:";
            // 
            // txtCropYear
            // 
            txtCropYear.Location = new Point(328, 328);
            txtCropYear.Name = "txtCropYear";
            txtCropYear.Size = new Size(195, 23);
            txtCropYear.TabIndex = 14;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 12F);
            labelQuantity.Location = new Point(241, 363);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(73, 21);
            labelQuantity.TabIndex = 15;
            labelQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(328, 363);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(195, 23);
            txtQuantity.TabIndex = 16;
            // 
            // labelFormatQua
            // 
            labelFormatQua.AutoSize = true;
            labelFormatQua.Location = new Point(542, 368);
            labelFormatQua.Name = "labelFormatQua";
            labelFormatQua.Size = new Size(163, 15);
            labelFormatQua.TabIndex = 17;
            labelFormatQua.Text = "(Format: 0,000 - Ex: 23,530 Tn)";
            // 
            // labelPricePerTone
            // 
            labelPricePerTone.AutoSize = true;
            labelPricePerTone.Font = new Font("Segoe UI", 12F);
            labelPricePerTone.Location = new Point(212, 397);
            labelPricePerTone.Name = "labelPricePerTone";
            labelPricePerTone.Size = new Size(102, 21);
            labelPricePerTone.TabIndex = 18;
            labelPricePerTone.Text = "Price per Ton:";
            // 
            // txtPricePerTon
            // 
            txtPricePerTon.Location = new Point(328, 395);
            txtPricePerTon.Name = "txtPricePerTon";
            txtPricePerTon.Size = new Size(195, 23);
            txtPricePerTon.TabIndex = 19;
            // 
            // labelFormatPrice
            // 
            labelFormatPrice.AutoSize = true;
            labelFormatPrice.Location = new Point(542, 403);
            labelFormatPrice.Name = "labelFormatPrice";
            labelFormatPrice.Size = new Size(169, 15);
            labelFormatPrice.TabIndex = 20;
            labelFormatPrice.Text = "(Format: 0,00 - Ex: 1230,50 usd)";
            // 
            // labelCurrency
            // 
            labelCurrency.AutoSize = true;
            labelCurrency.Font = new Font("Segoe UI", 12F);
            labelCurrency.Location = new Point(233, 429);
            labelCurrency.Name = "labelCurrency";
            labelCurrency.Size = new Size(76, 21);
            labelCurrency.TabIndex = 21;
            labelCurrency.Text = "Currency:";
            // 
            // cmbCurrency
            // 
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Location = new Point(328, 429);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(195, 23);
            cmbCurrency.TabIndex = 22;
            // 
            // labelIncoterm
            // 
            labelIncoterm.AutoSize = true;
            labelIncoterm.Font = new Font("Segoe UI", 12F);
            labelIncoterm.Location = new Point(233, 464);
            labelIncoterm.Name = "labelIncoterm";
            labelIncoterm.Size = new Size(75, 21);
            labelIncoterm.TabIndex = 23;
            labelIncoterm.Text = "Incoterm:";
            // 
            // cmbIncoterm
            // 
            cmbIncoterm.FormattingEnabled = true;
            cmbIncoterm.Location = new Point(328, 464);
            cmbIncoterm.Name = "cmbIncoterm";
            cmbIncoterm.Size = new Size(195, 23);
            cmbIncoterm.TabIndex = 24;
            // 
            // labelMethodOfPayment
            // 
            labelMethodOfPayment.AutoSize = true;
            labelMethodOfPayment.Font = new Font("Segoe UI", 12F);
            labelMethodOfPayment.Location = new Point(159, 500);
            labelMethodOfPayment.Name = "labelMethodOfPayment";
            labelMethodOfPayment.Size = new Size(149, 21);
            labelMethodOfPayment.TabIndex = 25;
            labelMethodOfPayment.Text = "Method of Payment:";
            // 
            // cmbMethodOfPayment
            // 
            cmbMethodOfPayment.FormattingEnabled = true;
            cmbMethodOfPayment.Location = new Point(328, 498);
            cmbMethodOfPayment.Name = "cmbMethodOfPayment";
            cmbMethodOfPayment.Size = new Size(195, 23);
            cmbMethodOfPayment.TabIndex = 26;
            // 
            // labelPortOfLoading
            // 
            labelPortOfLoading.AutoSize = true;
            labelPortOfLoading.Font = new Font("Segoe UI", 12F);
            labelPortOfLoading.Location = new Point(193, 537);
            labelPortOfLoading.Name = "labelPortOfLoading";
            labelPortOfLoading.Size = new Size(115, 21);
            labelPortOfLoading.TabIndex = 27;
            labelPortOfLoading.Text = "Port of loading:";
            // 
            // cmbPortOfLoading
            // 
            cmbPortOfLoading.FormattingEnabled = true;
            cmbPortOfLoading.Location = new Point(328, 537);
            cmbPortOfLoading.Name = "cmbPortOfLoading";
            cmbPortOfLoading.Size = new Size(195, 23);
            cmbPortOfLoading.TabIndex = 28;
            // 
            // labelPortOfDestination
            // 
            labelPortOfDestination.AutoSize = true;
            labelPortOfDestination.Font = new Font("Segoe UI", 12F);
            labelPortOfDestination.Location = new Point(166, 573);
            labelPortOfDestination.Name = "labelPortOfDestination";
            labelPortOfDestination.Size = new Size(142, 21);
            labelPortOfDestination.TabIndex = 29;
            labelPortOfDestination.Text = "Port of Destination:";
            // 
            // cmbPortOfDestination
            // 
            cmbPortOfDestination.FormattingEnabled = true;
            cmbPortOfDestination.Location = new Point(328, 575);
            cmbPortOfDestination.Name = "cmbPortOfDestination";
            cmbPortOfDestination.Size = new Size(195, 23);
            cmbPortOfDestination.TabIndex = 30;
            // 
            // labelBrokerCom
            // 
            labelBrokerCom.AutoSize = true;
            labelBrokerCom.Font = new Font("Segoe UI", 12F);
            labelBrokerCom.Location = new Point(172, 610);
            labelBrokerCom.Name = "labelBrokerCom";
            labelBrokerCom.Size = new Size(136, 21);
            labelBrokerCom.TabIndex = 31;
            labelBrokerCom.Text = "Broker Comission:";
            // 
            // txtBrokerComission
            // 
            txtBrokerComission.Location = new Point(328, 610);
            txtBrokerComission.Name = "txtBrokerComission";
            txtBrokerComission.Size = new Size(195, 23);
            txtBrokerComission.TabIndex = 32;
            // 
            // labelBrokerComFormat
            // 
            labelBrokerComFormat.AutoSize = true;
            labelBrokerComFormat.Location = new Point(536, 618);
            labelBrokerComFormat.Name = "labelBrokerComFormat";
            labelBrokerComFormat.Size = new Size(142, 15);
            labelBrokerComFormat.TabIndex = 33;
            labelBrokerComFormat.Text = "(Format: 0,00 - Ex: 2,50 %)";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(293, 672);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 34);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(469, 672);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 34);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(529, 103);
            label2.Name = "label2";
            label2.Size = new Size(15, 19);
            label2.TabIndex = 36;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(529, 132);
            label3.Name = "label3";
            label3.Size = new Size(15, 19);
            label3.TabIndex = 37;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(529, 198);
            label4.Name = "label4";
            label4.Size = new Size(15, 19);
            label4.TabIndex = 38;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(529, 234);
            label5.Name = "label5";
            label5.Size = new Size(15, 19);
            label5.TabIndex = 39;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(529, 332);
            label6.Name = "label6";
            label6.Size = new Size(15, 19);
            label6.TabIndex = 40;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(529, 368);
            label7.Name = "label7";
            label7.Size = new Size(15, 19);
            label7.TabIndex = 41;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(529, 399);
            label8.Name = "label8";
            label8.Size = new Size(15, 19);
            label8.TabIndex = 42;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(529, 433);
            label9.Name = "label9";
            label9.Size = new Size(15, 19);
            label9.TabIndex = 43;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(529, 468);
            label10.Name = "label10";
            label10.Size = new Size(15, 19);
            label10.TabIndex = 44;
            label10.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(529, 500);
            label11.Name = "label11";
            label11.Size = new Size(15, 19);
            label11.TabIndex = 45;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(273, 161);
            label12.Name = "label12";
            label12.Size = new Size(41, 21);
            label12.TabIndex = 46;
            label12.Text = "Size:";
            // 
            // cmbSize
            // 
            cmbSize.FormattingEnabled = true;
            cmbSize.Location = new Point(328, 161);
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(195, 23);
            cmbSize.TabIndex = 47;
            // 
            // FormSaleDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 722);
            Controls.Add(cmbSize);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labelBrokerComFormat);
            Controls.Add(txtBrokerComission);
            Controls.Add(labelBrokerCom);
            Controls.Add(cmbPortOfDestination);
            Controls.Add(labelPortOfDestination);
            Controls.Add(cmbPortOfLoading);
            Controls.Add(labelPortOfLoading);
            Controls.Add(cmbMethodOfPayment);
            Controls.Add(labelMethodOfPayment);
            Controls.Add(cmbIncoterm);
            Controls.Add(labelIncoterm);
            Controls.Add(cmbCurrency);
            Controls.Add(labelCurrency);
            Controls.Add(labelFormatPrice);
            Controls.Add(txtPricePerTon);
            Controls.Add(labelPricePerTone);
            Controls.Add(labelFormatQua);
            Controls.Add(txtQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(txtCropYear);
            Controls.Add(labelCropYear);
            Controls.Add(txtSeller);
            Controls.Add(labelSeller);
            Controls.Add(txtShipper);
            Controls.Add(labelShipper);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelContractDate);
            Controls.Add(cmbStatus);
            Controls.Add(labelStatus);
            Controls.Add(cmbProduct);
            Controls.Add(labelProduct);
            Controls.Add(cmbCustomer);
            Controls.Add(labelCustomer);
            Controls.Add(label1);
            MaximumSize = new Size(816, 761);
            MinimumSize = new Size(816, 761);
            Name = "FormSaleDetail";
            Text = "FormSalesDetail";
            Load += FormSaleDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCustomer;
        private ComboBox cmbCustomer;
        private Label labelProduct;
        private ComboBox cmbProduct;
        private Label labelStatus;
        private ComboBox cmbStatus;
        private Label labelContractDate;
        private DateTimePicker dateTimePicker1;
        private Label labelShipper;
        private TextBox txtShipper;
        private Label labelSeller;
        private TextBox txtSeller;
        private Label labelCropYear;
        private TextBox txtCropYear;
        private Label labelQuantity;
        private TextBox txtQuantity;
        private Label labelFormatQua;
        private Label labelPricePerTone;
        private TextBox txtPricePerTon;
        private Label labelFormatPrice;
        private Label labelCurrency;
        private ComboBox cmbCurrency;
        private Label labelIncoterm;
        private ComboBox cmbIncoterm;
        private Label labelMethodOfPayment;
        private ComboBox cmbMethodOfPayment;
        private Label labelPortOfLoading;
        private ComboBox cmbPortOfLoading;
        private Label labelPortOfDestination;
        private ComboBox cmbPortOfDestination;
        private Label labelBrokerCom;
        private TextBox txtBrokerComission;
        private Label labelBrokerComFormat;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cmbSize;
    }
}