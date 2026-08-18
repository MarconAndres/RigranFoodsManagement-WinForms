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
    public partial class FormCPPDetail : Form
    {
        private readonly CustomerProductProfileService _customerProductProfileService;
        private CustomerProductProfile _CurrentCustomerProductProfile;
        private bool _isEditMode = false;

        public FormCPPDetail()
        {
            InitializeComponent();
            _customerProductProfileService = new CustomerProductProfileService();
            _CurrentCustomerProductProfile = new CustomerProductProfile();
            _isEditMode = false;
        }
        public FormCPPDetail(CustomerProductProfile customerProductProfileToEdit) : this()
        {
            //InitializeComponent();
            _CurrentCustomerProductProfile = customerProductProfileToEdit;
            _isEditMode = true;
        }

        private void FormCPPDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _customerService = new CustomerService();
                cmbCustomer.DataSource = _customerService.GetAll();
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "ID";

                var _productService = new ProductMasterService();
                cmbProduct.DataSource = _productService.GetAll();
                cmbProduct.DisplayMember = "Name";
                cmbProduct.ValueMember = "ID";

                var _preferredPackagingService = new PreferredPackagingService();
                cmbPreferredPackaging.DataSource = _preferredPackagingService.GetAll();
                cmbPreferredPackaging.DisplayMember = "Name";
                cmbPreferredPackaging.ValueMember = "ID";

                var _purchaseFrequencyService = new PurchaseFrequencyService();
                cmbPurchaseFrequency.DataSource = _purchaseFrequencyService.GetAll();
                cmbPurchaseFrequency.DisplayMember = "Name";
                cmbPurchaseFrequency.ValueMember = "ID";

                var _priceSensitivityService = new PriceSensitivityService();
                cmbPriceSensitivity.DataSource = _priceSensitivityService.GetAll();
                cmbPriceSensitivity.DisplayMember = "Level";
                cmbPriceSensitivity.ValueMember = "ID";

                var _qualityStandardService = new QualityStandartService();
                cmbQualityStandard.DataSource = _qualityStandardService.GetAll();
                cmbQualityStandard.DisplayMember = "Name";
                cmbQualityStandard.ValueMember = "ID";

                if (_isEditMode && _CurrentCustomerProductProfile != null)
                {
                    this.Text = "Edit Customer Product Profile";

                    txtAnnualVolume.Text = _CurrentCustomerProductProfile.AnnualVolume.ToString();
                    txtAlternativeOrigin.Text = _CurrentCustomerProductProfile.AlternativeOrigin;
                    txtNotes.Text = _CurrentCustomerProductProfile.Notes;

                    cmbCustomer.SelectedValue = _CurrentCustomerProductProfile.IdCustomer;
                    cmbProduct.SelectedValue = _CurrentCustomerProductProfile.IdProductMaster;
                    
                    if (_CurrentCustomerProductProfile.IdPreferredPackaging.HasValue && _CurrentCustomerProductProfile.IdPreferredPackaging.Value > 0)
                    {
                        cmbPreferredPackaging.SelectedValue = _CurrentCustomerProductProfile.IdPreferredPackaging.Value;
                    }
                    else
                    {
                        cmbPreferredPackaging.SelectedIndex = -1;
                    }

                    if (_CurrentCustomerProductProfile.IdPurchaseFrequency.HasValue && _CurrentCustomerProductProfile.IdPurchaseFrequency.Value > 0)
                    {
                        cmbPurchaseFrequency.SelectedValue = _CurrentCustomerProductProfile.IdPurchaseFrequency.Value;
                    }
                    else
                    {
                        cmbPurchaseFrequency.SelectedIndex = -1;
                    }

                    if (_CurrentCustomerProductProfile.IdPriceSensitivity.HasValue && _CurrentCustomerProductProfile.IdPriceSensitivity.Value > 0)
                    {
                        cmbPriceSensitivity.SelectedValue = _CurrentCustomerProductProfile.IdPriceSensitivity.Value;
                    }
                    else
                    {
                        cmbPriceSensitivity.SelectedIndex = -1;
                    }

                    if (_CurrentCustomerProductProfile.IdQualityStandart.HasValue && _CurrentCustomerProductProfile.IdQualityStandart.Value > 0)
                    {
                        cmbQualityStandard.SelectedValue = _CurrentCustomerProductProfile.IdQualityStandart.Value;
                    }
                    else
                    {
                        cmbQualityStandard.SelectedIndex = -1;
                    }
                }
                else
                {
                    this.Text = "Add Customer Product Profile";
                    _CurrentCustomerProductProfile = new CustomerProductProfile();

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error initializing the form: " + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _CurrentCustomerProductProfile.IdCustomer = cmbCustomer.SelectedIndex == -1
                    ? 0
                    : (int)cmbCustomer.SelectedValue;
                _CurrentCustomerProductProfile.IdProductMaster = cmbProduct.SelectedIndex == -1
                    ? 0
                    : (int)cmbProduct.SelectedValue;
                if (cmbPreferredPackaging.SelectedIndex == -1 || cmbPreferredPackaging.SelectedValue == null)
                {
                    _CurrentCustomerProductProfile.IdPreferredPackaging = null;
                }
                else
                {
                    _CurrentCustomerProductProfile.IdPreferredPackaging = (int)cmbPreferredPackaging.SelectedValue;
                }
                if (cmbPurchaseFrequency.SelectedIndex == -1 || cmbPurchaseFrequency.SelectedValue == null)
                {
                    _CurrentCustomerProductProfile.IdPurchaseFrequency = null;
                }
                else
                {
                    _CurrentCustomerProductProfile.IdPurchaseFrequency = (int)cmbPurchaseFrequency.SelectedValue;
                }
                if (cmbPriceSensitivity.SelectedIndex == -1 || cmbPriceSensitivity.SelectedValue == null)
                {
                    _CurrentCustomerProductProfile.IdPriceSensitivity = null;
                }
                else
                {  
                    _CurrentCustomerProductProfile.IdPriceSensitivity = (int)cmbPriceSensitivity.SelectedValue;
                }
                if (cmbQualityStandard.SelectedIndex == -1 || cmbQualityStandard.SelectedValue == null)
                {
                    _CurrentCustomerProductProfile.IdQualityStandart = null;
                }
                else
                {
                    _CurrentCustomerProductProfile.IdQualityStandart = (int)cmbQualityStandard.SelectedValue;
                }
                
                _CurrentCustomerProductProfile.AlternativeOrigin = txtAlternativeOrigin.Text.Trim();
                _CurrentCustomerProductProfile.Notes = txtNotes.Text.Trim();

                if (string.IsNullOrWhiteSpace(txtAnnualVolume.Text))
                {
                    _CurrentCustomerProductProfile.AnnualVolume = null;
                }
                else
                {
                    _CurrentCustomerProductProfile.AnnualVolume = decimal.Parse(txtAnnualVolume.Text.Trim());
                }

                if (_isEditMode)
                {
                    _customerProductProfileService.Update(_CurrentCustomerProductProfile);
                    MessageBox.Show("Customer Product Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _customerProductProfileService.Insert(_CurrentCustomerProductProfile);
                    MessageBox.Show("Customer Product Profile added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error saving the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
