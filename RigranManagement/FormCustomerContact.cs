using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Entities;
using System.Linq;

namespace Winform
{
    public partial class FormCustomerContact : Form
    {
        private readonly CustomerContactService _customerContactService;

        private List<dynamic> _allContacts;

        public FormCustomerContact()
        {
            InitializeComponent();
            _customerContactService = new CustomerContactService();
            _allContacts = new List<dynamic>();
        }

        private void FormCustomerContact_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void RefreshDgv()
        {
            try
            {
                List<CustomerContact> contactList = _customerContactService.GetAll();

                CustomerService customerService = new CustomerService();
                List<Customer> customerList = customerService.GetAll();

                var contactListWithCustomer = from contact in contactList
                                              join customer in customerList on contact.IdCustomer equals customer.ID into customerGroup
                                              from customer in customerGroup.DefaultIfEmpty()
                                              select new
                                              {
                                                  contact.ID,
                                                  CustomerName = customer?.Name ?? "N/A",
                                                  contact.FirstName,
                                                  contact.LastName,
                                                  contact.RolePosition,
                                                  contact.Email,
                                                  contact.PhoneNumber,
                                              };
                dgvCustomerContact.DataSource = null;
                var customerContactsviewlist = contactListWithCustomer.ToList();
                _allContacts = customerContactsviewlist.Select(x => (dynamic)x).ToList();
                dgvCustomerContact.DataSource = customerContactsviewlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormatDgv()
        {
            if (dgvCustomerContact.Columns["ID"] != null)
            {
                dgvCustomerContact.Columns["ID"].Visible = false;
            }
            if (dgvCustomerContact.Columns["CustomerName"] != null)
            {
                dgvCustomerContact.Columns["CustomerName"].HeaderText = "Customer Name";
            }
            if (dgvCustomerContact.Columns["FirstName"] != null)
            {
                dgvCustomerContact.Columns["FirstName"].HeaderText = "Contact First Name";
            }
            if (dgvCustomerContact.Columns["LastName"] != null)
            {
                dgvCustomerContact.Columns["LastName"].HeaderText = "Contact Last Name";
            }
            if (dgvCustomerContact.Columns["RolePosition"] != null)
            {
                dgvCustomerContact.Columns["RolePosition"].HeaderText = "Role/Position";
            }
            if (dgvCustomerContact.Columns["Email"] != null)
            {
                dgvCustomerContact.Columns["Email"].HeaderText = "Email";
            }
            if (dgvCustomerContact.Columns["PhoneNumber"] != null)
            {
                dgvCustomerContact.Columns["PhoneNumber"].HeaderText = "Phone Number";
            }

            dgvCustomerContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerContact.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerContact.MultiSelect = false;
            dgvCustomerContact.ReadOnly = true;
        }

        private void btnInsertCustomerContact_Click(object sender, EventArgs e)
        {
            FormCustomerContactDetail formCustomerContactDetail = new FormCustomerContactDetail();

            if (formCustomerContactDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateCustomerContact_Click(object sender, EventArgs e)
        {
            if (dgvCustomerContact.CurrentRow == null)
            {
                MessageBox.Show("Please select a valid Customer Contact to update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int selectedID = (int)dgvCustomerContact.CurrentRow.Cells["ID"].Value;
                CustomerContact customerContactToEdit = _customerContactService.GetById(selectedID);
                
                if (customerContactToEdit != null)
                {
                    FormCustomerContactDetail formCustomerContactDetail = new FormCustomerContactDetail(customerContactToEdit);
                    if (formCustomerContactDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
