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
    public partial class FormSales : Form
    {
        private readonly SalesService _salesService;
        public FormSales()
        {
            InitializeComponent();
            _salesService = new SalesService();
        }

    
        private void RefreshDgv()
        {
            try
            {
                List<Sales> salesList = _salesService.GetAll();
                dgvFormSales.DataSource = null;
                dgvFormSales.DataSource = salesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvFormSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormSales.MultiSelect = false;
            dgvFormSales.ReadOnly = true;
        }

        private void FormSales_Load_1(object sender, EventArgs e)
        {
            FormatDgv();
            RefreshDgv();
        }
    }
}
