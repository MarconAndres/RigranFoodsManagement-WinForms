using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using Entities;

namespace Winform
{
    public partial class FormCustomer : Form
    {
        private readonly CustomerService _customerService;

        private List<dynamic> _allCustomers;

        public FormCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            _allCustomers = new List<dynamic>(); 
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void RefreshDgv()
        {
            try
            {
                List<Customer> customerList = _customerService.GetAll();
                
                SectorBusinessService sectorBusinessService = new SectorBusinessService();
                List<BusinessSector> businessSectors = sectorBusinessService.GetAll();
                CountryService countryService = new CountryService();
                List<Country> countries = countryService.GetAll();

                var customerListwithCountryandSector = from customer in customerList
                                                       join sector in businessSectors on customer.IdBusinessSector equals sector.ID into sectorGroup
                                                       from sector in sectorGroup.DefaultIfEmpty()
                                                       join country in countries on customer.IdCountry equals country.ID into countryGroup
                                                       from country in countryGroup.DefaultIfEmpty()
                                                       select new
                                                       {
                                                           customer.ID,
                                                           customer.Name,
                                                           BusinessSector = sector?.Description ?? "N/A",
                                                           customer.RegisteredName,
                                                           customer.Address,
                                                           customer.Email,
                                                           customer.VAT,
                                                           Country = country?.Name ?? "N/A",
                                                           customer.PhoneNumber,
                                                           customer.BIO,
                                                           customer.EORI,
                                                           Active = customer.Active ? "Yes" : "No"
                                                       };

                dgvCustomer.DataSource = null;

                // materialize for the grid
                var customerViewList = customerListwithCountryandSector.ToList();

                // convert to List<dynamic> for filtering/searching
                _allCustomers = customerViewList.Select(x => (dynamic)x).ToList();

                dgvCustomer.DataSource = customerViewList;
                FormatDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvCustomer.Columns["BusinessSector"].HeaderText = "Business Sector";
            dgvCustomer.Columns["RegisteredName"].HeaderText = "Registered Name";
            dgvCustomer.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.MultiSelect = false;
            dgvCustomer.ReadOnly = true;
        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerDetail formCustomerDetail = new FormCustomerDetail();

            if (formCustomerDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null)
            {
                MessageBox.Show("Please select a Customer to update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                int selectedID = (int)dgvCustomer.CurrentRow.Cells["ID"].Value;
                Customer customerToEdit = _customerService.GetById(selectedID);

                if (customerToEdit != null)
                {
                    FormCustomerDetail frmDetail = new FormCustomerDetail(customerToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allCustomers == null) return;

            string filterText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                dgvCustomer.DataSource = _allCustomers;
            }
            else
            {
                var filteredList = _allCustomers.Where(c =>
                    (c.Name != null && c.Name.ToLower().Contains(filterText)) ||
                    (c.BusinessSector != null && c.BusinessSector.ToLower().Contains(filterText)) ||
                    (c.RegisteredName != null && c.RegisteredName.ToLower().Contains(filterText)) ||
                    (c.Email != null && c.Email.ToLower().Contains(filterText)) ||
                    (c.Country != null && c.Country.ToLower().Contains(filterText))
                    ).ToList();

                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = filteredList;
            }
        }
    }
}
