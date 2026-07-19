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
    public partial class FormShipments : Form
    {
        private readonly ShipmentsService _shipmentService;
        public FormShipments()
        {
            InitializeComponent();
            _shipmentService = new ShipmentsService();
        }
        private void refreshDgv()
        {
            try
            {
                List<Shipments> shipmentList = _shipmentService.GetAll();
                dgvShipments.DataSource = null;
                dgvShipments.DataSource = shipmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shipments:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatDgv()
        {
            dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShipments.MultiSelect = false;
            dgvShipments.ReadOnly = true;

        }

        private void FormShipments_Load(object sender, EventArgs e)
        {
            formatDgv();
            refreshDgv();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormShipmentsDetail formShipmentsDetail = new FormShipmentsDetail();
            if (formShipmentsDetail.ShowDialog() == DialogResult.OK)
            {
                refreshDgv();
            }
        }
    }
}
