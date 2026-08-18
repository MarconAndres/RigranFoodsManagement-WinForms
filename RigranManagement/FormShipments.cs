using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Winform
{
    public partial class FormShipments : Form
    {
        private readonly ShipmentsService _shipmentService;

        private List<dynamic> _allShipments;

        public FormShipments()
        {
            InitializeComponent();
            _shipmentService = new ShipmentsService();
            _allShipments = new List<dynamic>();
        }
        private void refreshDgv()
        {
            try
            {
                List<Shipments> shipmentList = _shipmentService.GetAll();
                ShipmentStatusService _shipmentStatusService = new ShipmentStatusService();
                List<ShipmentStatus> shipmentStatuses = _shipmentStatusService.GetAll();
                ContainerTypeService _containerTypeService = new ContainerTypeService();
                List<ContainerType> containerTypes = _containerTypeService.GetAll();
                PortsService _portsService = new PortsService();
                List<Ports> portsList = _portsService.GetAll();

                var displaylist = from shipments in shipmentList

                                  join stat in shipmentStatuses on shipments.IdShipmentStatus equals stat.ID into statGroup
                                  from shipmentStatus in statGroup.DefaultIfEmpty()


                                  join ct in containerTypes on shipments.IdContainerType equals ct.ID into ctGroup
                                  from containerType in ctGroup.DefaultIfEmpty()


                                  join portL in portsList on shipments.IdPortOfLoading equals portL.ID into portLGroup
                                  from portOfLoading in portLGroup.DefaultIfEmpty()


                                  join portD in portsList on shipments.IdPortOfDestination equals portD.ID into portDGroup
                                  from portOfDestination in portDGroup.DefaultIfEmpty()

                                  select new
                                  {
                                      ID = shipments.ID,
                                      Sales = shipments.IdSales,
                                      ShipmentStatus = shipmentStatus != null ? shipmentStatus.Name : "N/A",
                                      BookingNumber = shipments.BookingNumber,
                                      ContainerNumber = shipments.ContainerNumber,
                                      ContainerType = containerType != null ? containerType.Code : "N/A",
                                      ShippingLine = shipments.ShippingLine,
                                      PortOfLoading = portOfLoading != null ? portOfLoading.Name : "N/A",
                                      PortOfDestination = portOfDestination != null ? portOfDestination.Name : "N/A",
                                      ETD = shipments.ETD,
                                      ATD = shipments.ATD,
                                      ETA = shipments.ETA,
                                      ATA = shipments.ATA,
                                      FreeDays = shipments.FreeDays,
                                      BLApproved = shipments.BLApproved ? "Yes" : "No",
                                      DHLNumber = shipments.DHLNumber,
                                      HasClaim = shipments.HasClaim ? "Yes" : "No",
                                      ClaimNote = shipments.ClaimNotes,
                                      Notes = shipments.Notes
                                  };

                dgvShipments.DataSource = null;
                var shipmentsViewList = displaylist.ToList();
                _allShipments = shipmentsViewList.Select(x => (dynamic)x).ToList();
                dgvShipments.DataSource = shipmentsViewList;
                formatDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shipments:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatDgv()
        {
            dgvShipments.Columns["ShipmentStatus"].HeaderText = "Shipment Status";
            dgvShipments.Columns["BookingNumber"].HeaderText = "Booking Number";
            dgvShipments.Columns["ContainerNumber"].HeaderText = "Container Number";
            dgvShipments.Columns["ContainerType"].HeaderText = "Container Type";
            dgvShipments.Columns["ShippingLine"].HeaderText = "Shipping Line";
            dgvShipments.Columns["PortOfLoading"].HeaderText = "Port of Loading";
            dgvShipments.Columns["PortOfDestination"].HeaderText = "Port of Destination";
            dgvShipments.Columns["FreeDays"].HeaderText = "Free Days";
            dgvShipments.Columns["BLApproved"].HeaderText = "BL Approved";
            dgvShipments.Columns["DHLNumber"].HeaderText = "DHL Number";
            dgvShipments.Columns["HasClaim"].HeaderText = "Has Claim";
            dgvShipments.Columns["ClaimNote"].HeaderText = "Claim Notes";
            dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipments.MultiSelect = false;
            dgvShipments.ReadOnly = true;

        }

        private void FormShipments_Load(object sender, EventArgs e)
        {
            refreshDgv();
            formatDgv();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormShipmentsDetail formShipmentsDetail = new FormShipmentsDetail();
            if (formShipmentsDetail.ShowDialog() == DialogResult.OK)
            {
                refreshDgv();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvShipments.CurrentRow == null)
            {
                MessageBox.Show("Please select a Shipment to update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {
                int slectedID = (int)dgvShipments.CurrentRow.Cells["ID"].Value;
                Shipments shipmentToEdit = _shipmentService.GetById(slectedID);

                if (shipmentToEdit != null)
                {
                    FormShipmentsDetail frmDetail = new FormShipmentsDetail(shipmentToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        refreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating shipment:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allShipments == null)
            {
                return;
            }
            string filteredText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filteredText))
            {
                dgvShipments.DataSource = _allShipments;
            }
            else
            {
                var filteredList = _allShipments.Where(s => s.BookingNumber.ToLower().Contains(filteredText) ||
                                                            s.Sales.ToString().Contains(filteredText) ||
                                                            s.ContainerNumber.ToLower().Contains(filteredText) ||
                                                            s.ShippingLine.ToLower().Contains(filteredText) ||
                                                            s.PortOfLoading.ToLower().Contains(filteredText) ||
                                                            s.ShipmentStatus.ToLower().Contains(filteredText) ||
                                                            s.PortOfDestination.ToLower().Contains(filteredText)).ToList();
                dgvShipments.DataSource = filteredList;
            }
        }
    }
}
