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
    public partial class FormCustomerProductProfile : Form
    {
        private readonly CustomerProductProfileService _customerProductProfileService;

        private List<dynamic> _allCustomerProductProfiles;

        public FormCustomerProductProfile()
        {
            InitializeComponent();
            _customerProductProfileService = new CustomerProductProfileService();
            _allCustomerProductProfiles = new List<dynamic>();
        }

        private void RefreshDgv()
        {
            try
            {
                List<CustomerProductProfile> customerProductProfileList = _customerProductProfileService.GetAll();
                CustomerService customerService = new CustomerService();
                List<Customer> customers = customerService.GetAll();
                ProductMasterService productMasterService = new ProductMasterService();
                List<ProductMaster> products = productMasterService.GetAll();
                PreferredPackagingService preferredPackagingService = new PreferredPackagingService();
                List<PreferredPackaging> preferredPackagings = preferredPackagingService.GetAll();
                PurchaseFrequencyService purchaseFrequencyService = new PurchaseFrequencyService();
                List<PurchaseFrequency> purchaseFrequencies = purchaseFrequencyService.GetAll();
                PriceSensitivityService priceSensitivityService = new PriceSensitivityService();
                List<PriceSensitivity> priceSensitivities = priceSensitivityService.GetAll();
                QualityStandartService qualityStandartService = new QualityStandartService();
                List<QualityStandart> qualityStandarts = qualityStandartService.GetAll();

                var customerProductProfileListWithCustomerAndProduct = from profile in customerProductProfileList
                                                                       join customer in customers on profile.IdCustomer equals customer.ID into customerGroup
                                                                       from customer in customerGroup.DefaultIfEmpty()
                                                                       join product in products on profile.IdProductMaster equals product.ID into productGroup
                                                                       from product in productGroup.DefaultIfEmpty()
                                                                       join preferred in preferredPackagings on profile.IdPreferredPackaging equals preferred.ID into preferredGroup
                                                                       from preferred in preferredGroup.DefaultIfEmpty()
                                                                       join purchase in purchaseFrequencies on profile.IdPurchaseFrequency equals purchase.ID into purchaseGroup
                                                                       from purchase in purchaseGroup.DefaultIfEmpty()
                                                                       join priceSensitivity in priceSensitivities on profile.IdPriceSensitivity equals priceSensitivity.ID into priceSensitivityGroup
                                                                       from priceSensitivity in priceSensitivityGroup.DefaultIfEmpty()
                                                                       join qualityStandard in qualityStandarts on profile.IdQualityStandart equals qualityStandard.ID into qualityStandardGroup
                                                                       from qualityStandard in qualityStandardGroup.DefaultIfEmpty()
                                                                       select new
                                                                       {
                                                                           IdCustomer = profile.IdCustomer,
                                                                           IdProductMaster = profile.IdProductMaster,                                                                          
                                                                           CustomerName = customer?.Name ?? "N/A",
                                                                           ProductName = product?.Name ?? "N/A",
                                                                           profile.AnnualVolume,
                                                                           PreferredPackaging = preferred?.Name ?? "N/A",
                                                                           PurchaseFrequency = purchase?.Name ?? "N/A",
                                                                           PriceSensitivity = priceSensitivity?.Level ?? "N/A",
                                                                           profile.AlternativeOrigin,
                                                                           QualityStandard = qualityStandard?.Name ?? "N/A",
                                                                           profile.Notes
                                                                       };

                dgvCustomerProductProfile.DataSource = null;
                var CPPviewlist = customerProductProfileListWithCustomerAndProduct.ToList();
                _allCustomerProductProfiles = CPPviewlist.Select(x => (dynamic)x).ToList();
                dgvCustomerProductProfile.DataSource = CPPviewlist;
                FormatDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data grid view: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvCustomerProductProfile.Columns["IdCustomer"].Visible = false;
            dgvCustomerProductProfile.Columns["IdProductMaster"].Visible = false;
            dgvCustomerProductProfile.Columns["CustomerName"].HeaderText = "Customer";
            dgvCustomerProductProfile.Columns["ProductName"].HeaderText = "Product";
            dgvCustomerProductProfile.Columns["AnnualVolume"].HeaderText = "Annual Volume";
            dgvCustomerProductProfile.Columns["PreferredPackaging"].HeaderText = "Preferred Packaging";
            dgvCustomerProductProfile.Columns["PurchaseFrequency"].HeaderText = "Purchase Frequency";
            dgvCustomerProductProfile.Columns["PriceSensitivity"].HeaderText = "Price Sensitivity";
            dgvCustomerProductProfile.Columns["AlternativeOrigin"].HeaderText = "Alternative Origin";
            dgvCustomerProductProfile.Columns["QualityStandard"].HeaderText = "Quality Standard";
            dgvCustomerProductProfile.Columns["Notes"].HeaderText = "Notes";
            
            dgvCustomerProductProfile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerProductProfile.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerProductProfile.MultiSelect = false;
            dgvCustomerProductProfile.ReadOnly = true;
        }

        private void FormCustomerProductProfile_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allCustomerProductProfiles == null) return;
            string filteredText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filteredText))
            {
                dgvCustomerProductProfile.DataSource = _allCustomerProductProfiles;
            }
            else
            {
                var filteredList = _allCustomerProductProfiles.Where(x =>
                    (x.CustomerName != null && x.CustomerName.ToLower().Contains(filteredText)) ||
                    (x.ProductName != null && x.ProductName.ToLower().Contains(filteredText)) ||
                    (x.AnnualVolume != null && x.AnnualVolume.ToString().ToLower().Contains(filteredText)) ||
                    (x.PreferredPackaging != null && x.PreferredPackaging.ToLower().Contains(filteredText)) ||
                    (x.PurchaseFrequency != null && x.PurchaseFrequency.ToLower().Contains(filteredText)) ||
                    (x.PriceSensitivity != null && x.PriceSensitivity.ToLower().Contains(filteredText)) ||
                    (x.AlternativeOrigin != null && x.AlternativeOrigin.ToLower().Contains(filteredText)) ||
                    (x.QualityStandard != null && x.QualityStandard.ToLower().Contains(filteredText)) ||
                    (x.Notes != null && x.Notes.ToLower().Contains(filteredText))
                ).ToList();
                dgvCustomerProductProfile.DataSource = filteredList;
            }
        }

        private void btnInsertCPP_Click(object sender, EventArgs e)
        {
            FormCPPDetail frmCPPDetail = new FormCPPDetail();

            if (frmCPPDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateCPP_Click(object sender, EventArgs e)
        {
            if (dgvCustomerProductProfile.CurrentRow == null)
            {
                MessageBox.Show("Please select a Customer Product Profile to Update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                            
            }

            try
            {
                int idCustomer = (int)dgvCustomerProductProfile.CurrentRow.Cells["IdCustomer"].Value;
                int idProductMaster = (int)dgvCustomerProductProfile.CurrentRow.Cells["IdProductMaster"].Value;
                CustomerProductProfile customerProductProfileToEdit = _customerProductProfileService.GetById(idCustomer, idProductMaster);

                if (customerProductProfileToEdit != null)
                {
                    FormCPPDetail frmDetail = new FormCPPDetail(customerProductProfileToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred while updating the Customer Product Profile: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
