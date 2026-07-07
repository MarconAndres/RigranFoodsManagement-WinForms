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
    public partial class FormPortdetail : Form
    {

        private readonly PortsService _portsService;
        private readonly CountryService _countryService;
        private Ports _currentPort;
        private bool _isEditMode = false;

        public FormPortdetail()
        {
            InitializeComponent();
            _portsService = new PortsService();
            _countryService = new CountryService();
            _isEditMode = false;
        }

        public FormPortdetail(Ports porttoEdit) : this()
        {
            _currentPort = porttoEdit;
            _isEditMode = true;
        }

        private void FormPortdetail_Load(object sender, EventArgs e)
        {
            LoadCmbCountries();
            if (_isEditMode && _currentPort != null)
            {
                this.Text = "Update Port";
                txbCountryName.Text = _currentPort.Name;
                cmbCountriesFormPortDetail.SelectedValue = _currentPort.IdCountry;

            }

        }

        private void LoadCmbCountries()
        {
            try
            {
                List<Country> countries = _countryService.GetAll();
                cmbCountriesFormPortDetail.DataSource = countries;
                cmbCountriesFormPortDetail.DisplayMember = "Name";
                cmbCountriesFormPortDetail.ValueMember = "ID";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading Countries: " + ex.Message);
            }
        }

        private void btnSaveFormPortDetail_Click(object sender, EventArgs e)
        {
            _currentPort.Name = txbCountryName.Text.Trim();
            _currentPort.IdCountry = (int)cmbCountriesFormPortDetail.SelectedValue;

            try
            {
                if (_isEditMode)
                {
                    MessageBox.Show("Port Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Port Inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error saving port:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelFormPortDetail_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
