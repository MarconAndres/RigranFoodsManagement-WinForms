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
    public partial class FormProductMasterDetail : Form
    {
        public readonly ProductMasterService _productMasterService;
        private ProductMaster _currentProductMaster;
        private bool _isEditMode = false;

        public FormProductMasterDetail()
        {
            InitializeComponent();
            _productMasterService = new ProductMasterService();
            _currentProductMaster = new ProductMaster();
            _isEditMode = false;
        }

        public FormProductMasterDetail(ProductMaster productMasterToEdit) : this()
        {
            _currentProductMaster = productMasterToEdit;
            _isEditMode = true;
        }

        private void FormProductMasterDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _productTypeService = new ProductTypeService();
                cmbProductType.DataSource = _productTypeService.GetAll();
                cmbProductType.DisplayMember = "Name";
                cmbProductType.ValueMember = "ID";

                if (_isEditMode && _currentProductMaster != null)
                {
                    this.Text = "Edit Product Master";

                    if (_currentProductMaster.IdProductType.HasValue && _currentProductMaster.IdProductType.Value > 0)
                    {
                        cmbProductType.SelectedValue = _currentProductMaster.IdProductType.Value;
                    }
                    else
                    {
                        cmbProductType.SelectedIndex = -1;
                    }
                    txtProductTypeName.Text = _currentProductMaster.Name;
                }
                else
                {
                    this.Text = "Add Product Master";
                    _currentProductMaster = new ProductMaster();
                    cmbProductType.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMDetailSave_Click(object sender, EventArgs e)
        {
            if (cmbProductType.SelectedIndex == -1 || cmbProductType.SelectedValue == null)
            {
                _currentProductMaster.IdProductType = null;
            }
            else
            {
                _currentProductMaster.IdProductType = (int)cmbProductType.SelectedValue;
            }
            _currentProductMaster.Name = txtProductTypeName.Text.Trim();

            try
            {
                if (_isEditMode)
                {
                    _productMasterService.Update(_currentProductMaster);
                    MessageBox.Show("Product Master updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _productMasterService.Insert(_currentProductMaster);
                    MessageBox.Show("Product Master added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while saving the Product Master: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPMDetailCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
