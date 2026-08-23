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
    public partial class FormProductMaster : Form
    {
        private readonly ProductMasterService _productMasterService;
        private List<dynamic> _allProductMasters;

        public FormProductMaster()
        {
            InitializeComponent();
            _productMasterService = new ProductMasterService();
            _allProductMasters = new List<dynamic>();
        }

        private void FormProductMaster_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void RefreshDgv()
        {
            try
            {
                List<ProductMaster> productMasterList = _productMasterService.GetAll();
                ProductTypeService productTypeService = new ProductTypeService();
                List<ProductType> productTypes = productTypeService.GetAll();

                var productMasterListWithProductType = from product in productMasterList
                                                       join productType in productTypes on product.IdProductType equals productType.ID into TypeGroup
                                                       from productType in TypeGroup.DefaultIfEmpty()
                                                       select new
                                                       {
                                                           product.ID,
                                                           ProductType = productType?.Name ?? "N/A",
                                                           product.Name,

                                                       };
                dgvProductMaster.DataSource = null;
                var productMasterView = productMasterListWithProductType.ToList();
                _allProductMasters = productMasterView.Select(x => (dynamic)x).ToList();
                dgvProductMaster.DataSource = productMasterView;
                FormatDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Product Master data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormatDgv()
        {
            dgvProductMaster.Columns["ProductType"].HeaderText = "Product Type";
            dgvProductMaster.Columns["Name"].HeaderText = "Product Name";
            dgvProductMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductMaster.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductMaster.MultiSelect = false;
            dgvProductMaster.ReadOnly = true;
        }

        private void btnInsertProductMaster_Click(object sender, EventArgs e)
        {
            FormProductMasterDetail frmProductMasterDetail = new FormProductMasterDetail();
            if (frmProductMasterDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateProductMaster_Click(object sender, EventArgs e)
        {
            if (dgvProductMaster.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int selectedID = (int)dgvProductMaster.CurrentRow.Cells["ID"].Value;
                ProductMaster productMasterToEdit = _productMasterService.GetById(selectedID);
                if (productMasterToEdit != null)
                {
                    FormProductMasterDetail frmDetail = new FormProductMasterDetail(productMasterToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Product Master data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSearchProductMaster_TextChanged(object sender, EventArgs e)
        {
            if (_allProductMasters == null) return;

            string filterText = txtSearchProductMaster.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                dgvProductMaster.DataSource = _allProductMasters;
            }
            else
            {
                var filteredList = _allProductMasters.Where(x => x.Name.ToLower().Contains(filterText) || x.ProductType.ToLower().Contains(filterText)).ToList();
                dgvProductMaster.DataSource = null;
                dgvProductMaster.DataSource = filteredList; 
            }
        }
    }
}
