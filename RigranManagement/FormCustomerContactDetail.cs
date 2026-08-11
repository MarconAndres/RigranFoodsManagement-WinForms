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
    public partial class FormCustomerContactDetail : Form
    {
        private readonly CustomerContactService _customerContactService;
        private CustomerContact _currentCustomerContact;
        private bool _isEditMode = false;

        public FormCustomerContactDetail()
        {
            InitializeComponent();
            _customerContactService = new CustomerContactService();
            _currentCustomerContact = new CustomerContact();
            _isEditMode = false;
        }
        public FormCustomerContactDetail(CustomerContact customerContactToEdit) : this()
        {
            _currentCustomerContact = customerContactToEdit;
            _isEditMode = true;
        }

        private void FormCustomerContactDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _customerService = new CustomerService();
                cmbCustomer.DataSource = _customerService.GetAll();
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "ID";

                if (_isEditMode && _currentCustomerContact != null)
                {
                    this.Text = "Edit Customer Contact";
                    cmbCustomer.SelectedValue = _currentCustomerContact.IdCustomer;
                    txtContactFirstName.Text = _currentCustomerContact.FirstName;
                    txtContactLastName.Text = _currentCustomerContact.LastName;
                    txtRolePosition.Text = _currentCustomerContact.RolePosition;
                    txtEmail.Text = _currentCustomerContact.Email;
                    txtPhoneNumber.Text = _currentCustomerContact.PhoneNumber;
                }
                else
                {
                    this.Text = "Add Customer Contact";

                    _currentCustomerContact = new CustomerContact();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _currentCustomerContact.IdCustomer = cmbCustomer.SelectedIndex == -1
                ? (int?)null
                : (int)cmbCustomer.SelectedValue;
            _currentCustomerContact.FirstName = txtContactFirstName.Text;
            _currentCustomerContact.LastName = txtContactLastName.Text;
            _currentCustomerContact.RolePosition = txtRolePosition.Text;
            _currentCustomerContact.Email = txtEmail.Text;
            _currentCustomerContact.PhoneNumber = txtPhoneNumber.Text;

            try
            {
                if (_isEditMode)
                {
                    _customerContactService.Update(_currentCustomerContact);
                    MessageBox.Show("Customer contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _customerContactService.Insert(_currentCustomerContact);
                    MessageBox.Show("Customer contact added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer contact: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
