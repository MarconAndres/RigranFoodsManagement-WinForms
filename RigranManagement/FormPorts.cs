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
    public partial class FormPorts : Form
    {
        private readonly PortsService _portsService;
        public FormPorts()
        {
            InitializeComponent();
            _portsService = new PortsService();
        }

        private void FormPorts_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            try
            {
                List<Ports> portsList = _portsService.GetAll();
                CountryService countryService = new CountryService();
                List<Country> countriesList = countryService.GetAll();

                var portsWithCountryNames = from ports in portsList
                                            join country in countriesList on ports.IdCountry equals country.ID
                                            select new
                                            {
                                                ports.ID,
                                                ports.Name,
                                                Country = country.Name
                                            };



                dgvPorts.DataSource = null;
                dgvPorts.DataSource = portsWithCountryNames.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error loading ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvPorts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnInsertFormPorts_Click(object sender, EventArgs e)
        {
            FormPortdetail formPortDetail = new FormPortdetail();

            if (formPortDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateFormPorts_Click(object sender, EventArgs e)
        {
            if (dgvPorts.CurrentRow == null)
            {
                MessageBox.Show("Please select a port to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int selectedId = (int)dgvPorts.CurrentRow.Cells["ID"].Value;
                Ports portToEdit = _portsService.GetById(selectedId);
                if (portToEdit != null)
                {
                    FormPortdetail frmDetail = new FormPortdetail(portToEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening edit window: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
