namespace Winform
{
    partial class FormMain
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
            panelLeft = new Panel();
            btnCustomerContact = new Button();
            buttonCustomer = new Button();
            buttonSales = new Button();
            labelCommercial = new Label();
            buttonPorts = new Button();
            buttonShipments = new Button();
            labelLogistics = new Label();
            splitter1 = new Splitter();
            panelContainer = new Panel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ControlDark;
            panelLeft.BorderStyle = BorderStyle.FixedSingle;
            panelLeft.Controls.Add(btnCustomerContact);
            panelLeft.Controls.Add(buttonCustomer);
            panelLeft.Controls.Add(buttonSales);
            panelLeft.Controls.Add(labelCommercial);
            panelLeft.Controls.Add(buttonPorts);
            panelLeft.Controls.Add(buttonShipments);
            panelLeft.Controls.Add(labelLogistics);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.ForeColor = SystemColors.ActiveCaptionText;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(196, 510);
            panelLeft.TabIndex = 0;
            // 
            // btnCustomerContact
            // 
            btnCustomerContact.BackColor = SystemColors.ControlDark;
            btnCustomerContact.Dock = DockStyle.Top;
            btnCustomerContact.FlatAppearance.MouseOverBackColor = Color.White;
            btnCustomerContact.Font = new Font("Segoe UI", 12F);
            btnCustomerContact.Location = new Point(0, 198);
            btnCustomerContact.Margin = new Padding(4, 3, 4, 3);
            btnCustomerContact.Name = "btnCustomerContact";
            btnCustomerContact.Size = new Size(194, 39);
            btnCustomerContact.TabIndex = 6;
            btnCustomerContact.Text = "Customer Contact";
            btnCustomerContact.UseVisualStyleBackColor = false;
            // 
            // buttonCustomer
            // 
            buttonCustomer.BackColor = SystemColors.ControlDark;
            buttonCustomer.Dock = DockStyle.Top;
            buttonCustomer.FlatAppearance.MouseOverBackColor = Color.White;
            buttonCustomer.Font = new Font("Segoe UI", 12F);
            buttonCustomer.Location = new Point(0, 159);
            buttonCustomer.Margin = new Padding(4, 3, 4, 3);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(194, 39);
            buttonCustomer.TabIndex = 5;
            buttonCustomer.Text = "Customer";
            buttonCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonSales
            // 
            buttonSales.BackColor = SystemColors.ControlDark;
            buttonSales.Dock = DockStyle.Top;
            buttonSales.FlatAppearance.MouseOverBackColor = Color.White;
            buttonSales.Font = new Font("Segoe UI", 12F);
            buttonSales.Location = new Point(0, 120);
            buttonSales.Margin = new Padding(4, 3, 4, 3);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(194, 39);
            buttonSales.TabIndex = 4;
            buttonSales.Text = "Sales";
            buttonSales.UseVisualStyleBackColor = false;
            // 
            // labelCommercial
            // 
            labelCommercial.AutoSize = true;
            labelCommercial.Dock = DockStyle.Top;
            labelCommercial.Font = new Font("Segoe UI", 12F);
            labelCommercial.Location = new Point(0, 99);
            labelCommercial.Margin = new Padding(4, 0, 4, 0);
            labelCommercial.Name = "labelCommercial";
            labelCommercial.Size = new Size(97, 21);
            labelCommercial.TabIndex = 3;
            labelCommercial.Text = "Commercial:";
            // 
            // buttonPorts
            // 
            buttonPorts.BackColor = SystemColors.ControlDark;
            buttonPorts.Dock = DockStyle.Top;
            buttonPorts.FlatAppearance.MouseOverBackColor = Color.White;
            buttonPorts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPorts.Location = new Point(0, 60);
            buttonPorts.Margin = new Padding(4, 3, 4, 3);
            buttonPorts.Name = "buttonPorts";
            buttonPorts.Size = new Size(194, 39);
            buttonPorts.TabIndex = 2;
            buttonPorts.Text = "Ports";
            buttonPorts.UseVisualStyleBackColor = false;
            buttonPorts.Click += buttonPorts_Click;
            // 
            // buttonShipments
            // 
            buttonShipments.BackColor = SystemColors.ControlDark;
            buttonShipments.Dock = DockStyle.Top;
            buttonShipments.FlatAppearance.MouseOverBackColor = Color.White;
            buttonShipments.Font = new Font("Segoe UI", 12F);
            buttonShipments.ForeColor = SystemColors.ActiveCaptionText;
            buttonShipments.Location = new Point(0, 21);
            buttonShipments.Margin = new Padding(4, 3, 4, 3);
            buttonShipments.Name = "buttonShipments";
            buttonShipments.Size = new Size(194, 39);
            buttonShipments.TabIndex = 1;
            buttonShipments.Text = "Shipments";
            buttonShipments.UseVisualStyleBackColor = false;
            buttonShipments.Click += buttonShipments_Click;
            // 
            // labelLogistics
            // 
            labelLogistics.AutoSize = true;
            labelLogistics.BackColor = SystemColors.ControlDark;
            labelLogistics.Dock = DockStyle.Top;
            labelLogistics.FlatStyle = FlatStyle.Flat;
            labelLogistics.Font = new Font("Segoe UI", 12F);
            labelLogistics.ForeColor = SystemColors.ActiveCaptionText;
            labelLogistics.Location = new Point(0, 0);
            labelLogistics.Margin = new Padding(4, 0, 4, 0);
            labelLogistics.Name = "labelLogistics";
            labelLogistics.Size = new Size(73, 21);
            labelLogistics.TabIndex = 0;
            labelLogistics.Text = "Logistics:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(196, 0);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 510);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.ControlLight;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 0);
            panelContainer.Margin = new Padding(4, 3, 4, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(600, 510);
            panelContainer.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 510);
            Controls.Add(panelContainer);
            Controls.Add(splitter1);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Rigran Foods ";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Splitter splitter1;
        private Panel panelContainer;
        private Label labelLogistics;
        private Button buttonShipments;
        private Button buttonPorts;
        private Button buttonSales;
        private Label labelCommercial;
        private Button buttonCustomer;
        private Button btnCustomerContact;
    }
}