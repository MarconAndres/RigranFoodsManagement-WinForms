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
    public partial class FormShipmentsDetail : Form
    {
        private readonly ShipmentsService _shipmentsService;
        private Shipments _currentShipment;
        private bool _isEditMode = false;
        private ErrorProvider _errorProvider;

        public FormShipmentsDetail()
        {
            InitializeComponent();
            _shipmentsService = new ShipmentsService();
            _currentShipment = new Shipments();
            _errorProvider = new ErrorProvider();
            _isEditMode = false;
        }
        public FormShipmentsDetail(Shipments shipmentToEdit) : this()
        {
            _currentShipment = shipmentToEdit;
            _isEditMode = true;
        }

        private void FormShipmentsDetail_Load(object sender, EventArgs e)
        {
            try
            {
                var _idSaleService = new SalesService();
                cmbIdSale.DataSource = _idSaleService.GetAll();
                cmbIdSale.DisplayMember = "ID";
                cmbIdSale.ValueMember = "ID";

                var _shipmentStatusService = new ShipmentStatusService();
                cmbStatus.DataSource = _shipmentStatusService.GetAll();
                cmbStatus.DisplayMember = "Name";
                cmbStatus.ValueMember = "ID";

                var _containerTypeService = new ContainerTypeService();
                cmbContainerType.DataSource = _containerTypeService.GetAll();
                cmbContainerType.DisplayMember = "Code";
                cmbContainerType.ValueMember = "ID";

                var _portsService = new PortsService();
                cmbPortOfLoading.DataSource = _portsService.GetAll();
                cmbPortOfLoading.DisplayMember = "Name";
                cmbPortOfLoading.ValueMember = "ID";
                cmbPortOfDestination.DataSource = _portsService.GetAll();
                cmbPortOfDestination.DisplayMember = "Name";
                cmbPortOfDestination.ValueMember = "ID";

                if (_isEditMode && _currentShipment != null)
                {
                    cmbIdSale.SelectedValue = _currentShipment.IdSales;
                    cmbStatus.SelectedValue = _currentShipment.IdShipmentStatus;
                    txtBookingNumber.Text = _currentShipment.BookingNumber;
                    cmbContainerType.SelectedValue = _currentShipment.IdContainerType;
                    txtShippingLine.Text = _currentShipment.ShippingLine;
                    cmbPortOfLoading.SelectedValue = _currentShipment.IdPortOfLoading;
                    cmbPortOfDestination.SelectedValue = _currentShipment.IdPortOfDestination;
                    dtpETD.Value = (DateTime)_currentShipment.ETD;
                    dtpATD.Value = (DateTime)_currentShipment.ATD;
                    dtpETA.Value = (DateTime)_currentShipment.ETA;
                    dtpATA.Value = (DateTime)_currentShipment.ATA;
                    txtFreeDays.Text = _currentShipment.FreeDays;
                    txtClaimNotes.Text = _currentShipment.ClaimNotes;
                    txtNotes.Text = _currentShipment.Notes;


                    rdBLApprovedYes.Checked = _currentShipment.BLApproved;
                    rbBLApprovedNo.Checked = !_currentShipment.BLApproved;

                    rbHasClaimYes.Checked = _currentShipment.HasClaim;
                    rbHasCliamNo.Checked = !_currentShipment.HasClaim;
                }
                else
                {
                    this.Text = "Add New Shipment";
                    _currentShipment = new Shipments();
                    rbBLApprovedNo.Checked = true;
                    rbHasCliamNo.Checked = true;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading Shipment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbHasClaimYes.Checked && string.IsNullOrWhiteSpace(txtClaimNotes.Text))
                {
                    _errorProvider.SetError(txtClaimNotes, "Claim Notes is obligatory if the Shipment has a Claim.");
                    MessageBox.Show("Please fill in the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _currentShipment.BLApproved = rdBLApprovedYes.Checked;
                _currentShipment.HasClaim = rbHasClaimYes.Checked;


                _currentShipment.BookingNumber = txtBookingNumber.Text.Trim();
                _currentShipment.ContainerNumber = txtContainerNumber.Text.Trim();
                _currentShipment.ShippingLine = txtShippingLine.Text.Trim();
                _currentShipment.FreeDays = txtFreeDays.Text.Trim();
                _currentShipment.DHLNumber = txtDHLNumber.Text.Trim();
                _currentShipment.ClaimNotes = txtClaimNotes.Text.Trim();
                _currentShipment.Notes = txtNotes.Text.Trim();
                _currentShipment.ETD = dtpETD.Value;
                _currentShipment.ATD = dtpATD.Value;
                _currentShipment.ETA = dtpETA.Value;
                _currentShipment.ATA = dtpATA.Value;

                _currentShipment.IdSales = cmbIdSale.SelectedIndex == -1
                    ? 0
                    : (int)cmbIdSale.SelectedValue;
                _currentShipment.IdShipmentStatus = cmbStatus.SelectedIndex == -1
                    ? 0
                    : (int)cmbStatus.SelectedValue;
                _currentShipment.IdContainerType = cmbContainerType.SelectedIndex == -1
                    ? 0
                    : (int)cmbContainerType.SelectedValue;
                _currentShipment.IdPortOfLoading = cmbPortOfLoading.SelectedIndex == -1
                    ? 0
                    : (int)cmbPortOfLoading.SelectedValue;
                _currentShipment.IdPortOfDestination = cmbPortOfDestination.SelectedIndex == -1
                    ? 0
                    : (int)cmbPortOfDestination.SelectedValue;

                               

                if (_isEditMode)
                {
                    _shipmentsService.Update(_currentShipment);
                    MessageBox.Show("Shipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _shipmentsService.Insert(_currentShipment);
                    MessageBox.Show("Shipment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error saving Shipment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
