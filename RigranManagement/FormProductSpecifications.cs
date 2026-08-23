using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using Entities;

namespace Winforms
{
    public partial class FormProductSpecifications : Form
    {
        private readonly ProductSpecificationsService _productSpecificationsService;

        private List<dynamic> _allProductSpecifications;

        public FormProductSpecifications()
        {
            InitializeComponent();
            _productSpecificationsService = new ProductSpecificationsService();
            _allProductSpecifications = new List<dynamic>();
        }

        private void FormProductSpecifications_Load_1(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void RefreshDgv()
        {
            try
            {
                List<ProductSpecifications> productSpecificationsList = _productSpecificationsService.GetAll();
                ProductMasterService productService = new ProductMasterService();
                List<ProductMaster> products = productService.GetAll();

                var productSpecificationsListWithProduct = from spec in productSpecificationsList
                                                           join product in products on spec.IdProductMaster equals product.ID into productGroup
                                                           from product in productGroup.DefaultIfEmpty()
                                                           select new
                                                           {
                                                               ID = spec.ID,
                                                               Product = product != null ? product.Name : "N/A",
                                                               Size = spec.Size,
                                                               Moisture = spec.Moisture,
                                                               SplitAndBroken = spec.SplitAndBroken,
                                                               ForeignMatter = spec.Foreignmatter,
                                                               TotalDamage = spec.TotalDamage,
                                                               Purity = spec.Purity,
                                                               AdditionalSpecs = spec.AddSpecs,
                                                           };

                var productSpecificationsViewList = productSpecificationsListWithProduct.ToList();

                _allProductSpecifications = productSpecificationsViewList.Select(x => (dynamic)x).ToList();

                dgvProductSpecifications.DataSource = productSpecificationsViewList;

                FormatDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data grid view: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvProductSpecifications.Columns["ID"].Visible = false;
            dgvProductSpecifications.Columns["Product"].HeaderText = "Product";
            dgvProductSpecifications.Columns["Size"].HeaderText = "Size";
            dgvProductSpecifications.Columns["Moisture"].HeaderText = "Moisture";
            dgvProductSpecifications.Columns["SplitAndBroken"].HeaderText = "Split & Broken";
            dgvProductSpecifications.Columns["ForeignMatter"].HeaderText = "Foreign Matter";
            dgvProductSpecifications.Columns["TotalDamage"].HeaderText = "Total Damage";
            dgvProductSpecifications.Columns["Purity"].HeaderText = "Purity";
            dgvProductSpecifications.Columns["AdditionalSpecs"].HeaderText = "Additional Specs";
            dgvProductSpecifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductSpecifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductSpecifications.MultiSelect = false;
            dgvProductSpecifications.ReadOnly = true;
        }

        private void btnInsertProductSpecification_Click(object sender, EventArgs e)
        {
            FormProductSpecificationsDetail formProductSpecificationsDetail = new FormProductSpecificationsDetail();

            if (formProductSpecificationsDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateProductSpecification_Click(object sender, EventArgs e)
        {
            if (dgvProductSpecifications.CurrentRow == null)
            {
                MessageBox.Show("Please Select a Product Specifications to update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedID = (int)dgvProductSpecifications.CurrentRow.Cells["ID"].Value;
                ProductSpecifications productSpecificationsToEdit = _productSpecificationsService.GetById(selectedID);

                if (productSpecificationsToEdit != null)
                {
                    FormProductSpecificationsDetail frmDetail = new FormProductSpecificationsDetail(productSpecificationsToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product specification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allProductSpecifications == null)
            {
                return;
            }
            string filteredText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filteredText))
            {
                dgvProductSpecifications.DataSource = _allProductSpecifications;
            }
            else
            {
                var filteredList = _allProductSpecifications.Where(x =>
                    (x.Product != null && x.Product.ToLower().Contains(filteredText)) ||
                    (x.Size != null && x.Size.ToLower().Contains(filteredText)) ||
                    (x.Moisture != null && x.Moisture.ToLower().Contains(filteredText)) ||
                    (x.SplitAndBroken != null && x.SplitAndBroken.ToLower().Contains(filteredText)) ||
                    (x.ForeignMatter != null && x.ForeignMatter.ToLower().Contains(filteredText)) ||
                    (x.TotalDamage != null && x.TotalDamage.ToLower().Contains(filteredText)) ||
                    (x.Purity != null && x.Purity.ToLower().Contains(filteredText)) ||
                    (x.AdditionalSpecs != null && x.AdditionalSpecs.ToLower().Contains(filteredText))
                ).ToList();

                dgvProductSpecifications.DataSource = null;
                dgvProductSpecifications.DataSource = filteredList;
            }
        }
    }
}
