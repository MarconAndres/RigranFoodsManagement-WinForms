using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Entities;

namespace Winform
{
    public partial class FormSaleDetail : Form
    {
        private readonly SalesService _salesService;
        private Sales _currentSale;
        private bool _isEditMode = false;

        public FormSaleDetail()
        {
            InitializeComponent();
            _salesService = new SalesService();
            _currentSale = new Sales();
            _isEditMode = false;
        }

        public FormSaleDetail(Sales saleToEdit) : this()
        {
            _currentSale = saleToEdit;
            _isEditMode = true;
        }

        private void FormSaleDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _customerService = new CustomerService();
                cmbCustomer.DataSource = _customerService.GetAll();
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "ID";

                var _productService = new ProductMasterService();
                cmbProduct.DataSource = _productService.GetAll();
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "ID";

                var _statusService = new StatusService();
                cmbStatus.DataSource = _statusService.GetAll();
                cmbStatus.DisplayMember = "Name";
                cmbStatus.ValueMember = "ID";

                var _currencyService = new CurrencyService();
                cmbCurrency.DataSource = _currencyService.GetAll();
                cmbCurrency.DisplayMember = "Code";
                cmbCurrency.ValueMember = "ID";

                var _incotermService = new IncoTermService();
                cmbIncoterm.DataSource = _incotermService.GetAll();
                cmbIncoterm.DisplayMember = "Code";
                cmbIncoterm.ValueMember = "ID";

                var _methodOfPaymentService = new MethodOfPaymentService();
                cmbMethodOfPayment.DataSource = _methodOfPaymentService.GetAll();
                cmbMethodOfPayment.DisplayMember = "Code";
                cmbMethodOfPayment.ValueMember = "ID";

                var _portOfLoadingService = new PortsService();
                cmbPortOfLoading.DataSource = _portOfLoadingService.GetAll();
                cmbPortOfLoading.DisplayMember = "Name";
                cmbPortOfLoading.ValueMember = "ID";

                var _portOfDestinationsService = new PortsService();
                cmbPortOfDestination.DataSource = _portOfDestinationsService.GetAll();
                cmbPortOfDestination.DisplayMember = "Name";
                cmbPortOfDestination.ValueMember = "ID";

                if (_isEditMode && _currentSale != null)
                {
                    this.Text = "Edit Sale";

                    dateTimePicker1.Value = _currentSale.ContractDate.Value;
                    txtShipper.Text = _currentSale.Shipper;
                    txtSeller.Text = _currentSale.Seller;
                    txtCropYear.Text = _currentSale.CropYear;
                    txtQuantity.Text = _currentSale.Quantity.ToString();
                    txtPricePerTon.Text = _currentSale.PricePerTon.ToString();
                    txtBrokerComission.Text = _currentSale.BrokerComission.ToString();

                    cmbCustomer.SelectedValue = _currentSale.IdCustomer;
                    cmbProduct.SelectedValue = _currentSale.IdProduct;
                    cmbStatus.SelectedValue = _currentSale.IdStatus;
                    cmbCurrency.SelectedValue = _currentSale.IdCurrency;
                    cmbIncoterm.SelectedValue = _currentSale.IdIncoTerm;
                    cmbMethodOfPayment.SelectedValue = _currentSale.IdMethodOfPayment;
                    cmbPortOfLoading.SelectedValue = _currentSale.IdPortOfLoading;
                    cmbPortOfDestination.SelectedValue = _currentSale.IdPortOfDestination;
                }
                else
                {
                    this.Text = "Add Sale";
                    _currentSale = new Sales();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sale details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
