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
    public partial class FormProductSpecificationsDetail : Form
    {
        private readonly ProductSpecificationsService _productSpecificationsService;
        private ProductSpecifications _currentProductSpecifications;
        private bool _isEditMode = false;

        public FormProductSpecificationsDetail()
        {
            InitializeComponent();
            _productSpecificationsService = new ProductSpecificationsService();
            _currentProductSpecifications = new ProductSpecifications();
            _isEditMode = false;
        }
        public FormProductSpecificationsDetail(ProductSpecifications productSpecificationsToEdit) : this()
        {
            _currentProductSpecifications = productSpecificationsToEdit;
            _isEditMode = true;
        }

        private void FormProductSpecificationsDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _productMasterService = new ProductMasterService();
                cmbProduct.DataSource = _productMasterService.GetAll();
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "ID";

                if (_isEditMode && _currentProductSpecifications != null)
                {
                    this.Text = "Edit Mode";

                    if (_currentProductSpecifications.IdProductMaster.HasValue && _currentProductSpecifications.IdProductMaster.Value > 0)
                    {
                        cmbProduct.SelectedValue = _currentProductSpecifications.IdProductMaster;
                    }
                    else
                    {
                        cmbProduct.SelectedIndex = -1;
                    }
                    txtSize.Text = _currentProductSpecifications.Size;
                    txtMoisture.Text = _currentProductSpecifications.Moisture;
                    txtSplitAndBroken.Text = _currentProductSpecifications.SplitAndBroken;
                    txtForeignMatter.Text = _currentProductSpecifications.Foreignmatter;
                    txtTotalDamage.Text = _currentProductSpecifications.TotalDamage;
                    txtPurity.Text = _currentProductSpecifications.Purity;
                    txtAddSpecs.Text = _currentProductSpecifications.AddSpecs;
                }
                else
                {
                    this.Text = "Add Product Specifications";
                    _currentProductSpecifications = new ProductSpecifications();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
