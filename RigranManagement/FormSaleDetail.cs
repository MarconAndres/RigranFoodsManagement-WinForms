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
                    txtBrokerComission.Text = _currentSale.BrokerComissionPc.ToString();

                    cmbCustomer.SelectedValue = _currentSale.IdCustomer;
                    cmbProduct.SelectedValue = _currentSale.IdProduct;
                    cmbStatus.SelectedValue = _currentSale.IdStatus;
                    cmbCurrency.SelectedValue = _currentSale.IdCurrency;
                    cmbIncoterm.SelectedValue = _currentSale.IdIncoTerm;
                    cmbMethodOfPayment.SelectedValue = _currentSale.IdMethodOfPayment;

                    if (_currentSale.IdPortOfLoading.HasValue && _currentSale.IdPortOfLoading.Value > 0)
                    {
                        cmbPortOfLoading.SelectedValue = _currentSale.IdPortOfLoading.Value;
                    }
                    else
                    {
                        cmbPortOfLoading.SelectedIndex = -1;
                    }
                    if (_currentSale.IdPortOfDestination.HasValue && _currentSale.IdPortOfDestination.Value > 0)
                    {
                        cmbPortOfDestination.SelectedValue = _currentSale.IdPortOfDestination.Value;
                    }
                    else
                    {
                        cmbPortOfDestination.SelectedIndex = -1;
                    }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _currentSale.ContractDate = dateTimePicker1.Value;
                _currentSale.Shipper = txtShipper.Text.Trim();
                _currentSale.Seller = txtSeller.Text.Trim();
                _currentSale.CropYear = txtCropYear.Text.Trim();
                _currentSale.Quantity = decimal.Parse(txtQuantity.Text.Trim());
                _currentSale.PricePerTon = decimal.Parse(txtPricePerTon.Text.Trim());
                if (string.IsNullOrWhiteSpace(txtBrokerComission.Text))
                {
                    _currentSale.BrokerComissionPc = null;
                }
                else
                {
                    _currentSale.BrokerComissionPc = decimal.Parse(txtBrokerComission.Text.Trim());
                    
                }


                _currentSale.IdCustomer = cmbCustomer.SelectedIndex == -1
                    ? 0
                    : (int)cmbCustomer.SelectedValue;
                _currentSale.IdProduct = cmbProduct.SelectedIndex == -1
                    ? 0
                    : (int)cmbProduct.SelectedValue;
                _currentSale.IdStatus = cmbStatus.SelectedIndex == -1
                    ? 0
                    : (int)cmbStatus.SelectedValue;
                _currentSale.IdCurrency = cmbCurrency.SelectedIndex == -1
                    ? 0
                    : (int)cmbCurrency.SelectedValue;
                _currentSale.IdIncoTerm = cmbIncoterm.SelectedIndex == -1
                    ? 0
                    : (int)cmbIncoterm.SelectedValue;
                _currentSale.IdMethodOfPayment = cmbMethodOfPayment.SelectedIndex == -1
                    ? 0
                    : (int)cmbMethodOfPayment.SelectedValue;
                if (cmbPortOfLoading.SelectedIndex == -1 || cmbPortOfLoading.SelectedValue == null)
                {
                    _currentSale.IdPortOfLoading = null;
                }
                else
                {
                    _currentSale.IdPortOfLoading = (int)cmbPortOfLoading.SelectedValue;
                }
                if (cmbPortOfDestination.SelectedIndex == -1 || cmbPortOfDestination.SelectedValue == null)
                {
                    _currentSale.IdPortOfDestination = null;
                }
                else
                {
                    _currentSale.IdPortOfDestination = (int)cmbPortOfDestination.SelectedValue;
                }

               
                if (_isEditMode)
                {
                    _salesService.Update(_currentSale);
                    MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _salesService.Insert(_currentSale);
                    MessageBox.Show("Sale added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
