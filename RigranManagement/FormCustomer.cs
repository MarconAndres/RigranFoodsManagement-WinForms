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
    public partial class FormCustomer : Form
    {
        private readonly CustomerService _customerService;

        public FormCustomer()
        {
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            FormatDgv();
            RefreshDgv();
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
                dgvCustomer.DataSource = customerListwithCountryandSector.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
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

                MessageBox.Show("Error opening edit window: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
