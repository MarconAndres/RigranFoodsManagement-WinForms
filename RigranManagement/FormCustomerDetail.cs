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
    public partial class FormCustomerDetail : Form
    {
        private readonly CustomerService _customerService;
        private Customer _currentCustomer;
        private bool _isEditMode = false;

        public FormCustomerDetail()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _currentCustomer = new Customer();
            _isEditMode = false;
        }
        public FormCustomerDetail(Customer customerToEdit) : this()
        {
            _currentCustomer = customerToEdit;
            _isEditMode = true;
        }

        private void FormCustomerDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _businessSectorService = new SectorBusinessService();
                cmbCustomerBusinessSector.DataSource = _businessSectorService.GetAll();
                cmbCustomerBusinessSector.DisplayMember = "Description";
                cmbCustomerBusinessSector.ValueMember = "ID";

                var _countryService = new CountryService();
                cmbCustomerCountry.DataSource = _countryService.GetAll();
                cmbCustomerCountry.DisplayMember = "Name";
                cmbCustomerCountry.ValueMember = "ID";

                if (_isEditMode && _currentCustomer != null)
                {
                    this.Text = "Edit Customer";

                    txtCustomerName.Text = _currentCustomer.Name;
                    txtCustomerRegisteredName.Text = _currentCustomer.RegisteredName;
                    txtCustomerAddress.Text = _currentCustomer.Address;
                    txtCustomerPhoneNumber.Text = _currentCustomer.PhoneNumber;
                    txtCustomerEmail.Text = _currentCustomer.Email;
                    txtCustomerVAT.Text = _currentCustomer.VAT;
                    txtCustomerEORI.Text = _currentCustomer.EORI;
                    txtCustomerBio.Text = _currentCustomer.BIO;

                    cmbCustomerBusinessSector.SelectedValue = _currentCustomer.IdBusinessSector;
                    cmbCustomerCountry.SelectedValue = _currentCustomer.IdCountry;

                    if (_currentCustomer.Active)
                    {
                        rdbCustomerActive.Checked = true;
                    }
                    else
                        rdbCustomerInactive.Checked = true;

                }
                else
                {
                    this.Text = "Add Customer";

                    _currentCustomer = new Customer();

                    rdbCustomerActive.Checked = true;
                    cmbCustomerBusinessSector.SelectedIndex = -1;
                    cmbCustomerCountry.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error initializing form data" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomerDetailSave_Click(object sender, EventArgs e)
        {

            _currentCustomer.Name = txtCustomerName.Text.Trim();
            _currentCustomer.IdBusinessSector = cmbCustomerBusinessSector.SelectedIndex == -1
                ? (int?)null
                : (int)cmbCustomerBusinessSector.SelectedValue;
            _currentCustomer.RegisteredName = txtCustomerRegisteredName.Text.Trim();
            _currentCustomer.Address = txtCustomerAddress.Text.Trim();
            _currentCustomer.IdCountry = (int)cmbCustomerCountry.SelectedValue;
            _currentCustomer.Email = txtCustomerEmail.Text.Trim();
            _currentCustomer.VAT = txtCustomerVAT.Text.Trim();
            _currentCustomer.EORI = txtCustomerEORI.Text.Trim();
            _currentCustomer.PhoneNumber = txtCustomerPhoneNumber.Text.Trim();
            _currentCustomer.BIO = txtCustomerBio.Text.Trim();
            _currentCustomer.Active = rdbCustomerActive.Checked;

            try
            {
                if (_isEditMode)
                {
                    _customerService.Update(_currentCustomer);
                    MessageBox.Show("Customer updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    _customerService.Insert(_currentCustomer);
                    MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error saving Customer" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCustomerDetailCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
