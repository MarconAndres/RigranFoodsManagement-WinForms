using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Form FormActive = null;

        private void OpenFormInPanelContainer(Form formChild)
        {
            if (FormActive != null)
            {
                FormActive.Close();
            }
            FormActive = formChild;

            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formChild);
            panelContainer.Tag = formChild;

            formChild.BringToFront();
            formChild.Show();
        }
        private void buttonShipments_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormShipments());
        }

        private void buttonPorts_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormPorts());
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormCustomer());
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormSales());
        }

        private void btnCPP_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormCustomerProductProfile());
        }

        private void btnCustomerContact_Click(object sender, EventArgs e)
        {
            OpenFormInPanelContainer(new FormCustomerContact());
        }
    }
}
