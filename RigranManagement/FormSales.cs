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
        private List<dynamic> _allSales;
        public FormSales()
        {
            InitializeComponent();
            _salesService = new SalesService();
            _allSales = new List<dynamic>();
        }


        private void RefreshDgv()
        {
            try
            {
                List<Sales> salesList = _salesService.GetAll();

                CustomerService _customerService = new CustomerService();
                List<Customer> customerList = _customerService.GetAll();
                ProductMasterService _productService = new ProductMasterService();
                List<ProductMaster> productList = _productService.GetAll();
                StatusService _statusService = new StatusService();
                List<Status> statusList = _statusService.GetAll();
                CurrencyService _currencyService = new CurrencyService();
                List<Currency> currencyList = _currencyService.GetAll();
                IncoTermService _incoTermService = new IncoTermService();
                List<IncoTerm> incotermList = _incoTermService.GetAll();
                MethodOfPaymentService _methodOfPayment = new MethodOfPaymentService();
                List<MethodOfPayment> paymentMethodList = _methodOfPayment.GetAll();
                PortsService _portsService = new PortsService();
                List<Ports> portList = _portsService.GetAll();


                var displayList = from sale in salesList


                                  join cust in customerList on sale.IdCustomer equals cust.ID into custGroup
                                  from customer in custGroup.DefaultIfEmpty()

                                  join prod in productList on sale.IdProduct equals prod.ID into prodGroup
                                  from product in prodGroup.DefaultIfEmpty()

                                  join stat in statusList on sale.IdStatus equals stat.ID into statGroup
                                  from status in statGroup.DefaultIfEmpty()

                                  join curr in currencyList on sale.IdCurrency equals curr.ID into currGroup
                                  from currency in currGroup.DefaultIfEmpty()

                                  join inco in incotermList on sale.IdIncoTerm equals inco.ID into incoGroup
                                  from incoterm in incoGroup.DefaultIfEmpty()

                                  join pay in paymentMethodList on sale.IdMethodOfPayment equals pay.ID into payGroup
                                  from payment in payGroup.DefaultIfEmpty()

                                  join portL in portList on sale.IdPortOfLoading equals portL.ID into portLGroup
                                  from portOfLoading in portLGroup.DefaultIfEmpty()

                                  join portD in portList on sale.IdPortOfDestination equals portD.ID into portDGroup
                                  from portOfDestination in portDGroup.DefaultIfEmpty()

                                  select new
                                  {
                                      ID = sale.ID,
                                      Customer = customer != null ? customer.Name : "N/A",
                                      Product = product != null ? product.Name : "N/A",
                                      Status = status != null ? status.Name : "N/A",
                                      ContractDate = sale.ContractDate.ToString(),
                                      Shipper = sale.Shipper,
                                      Seller = sale.Seller,
                                      CropYear = sale.CropYear,
                                      Quantity = sale.Quantity,
                                      PricePerTon = sale.PricePerTon,
                                      Currency = currency != null ? currency.Code : "N/A",
                                      IncoTerm = incoterm != null ? incoterm.Code : "N/A",
                                      MethodOfPayment = payment != null ? payment.Code : "N/A",
                                      PortOfLoading = portOfLoading != null ? portOfLoading.Name : "N/A",
                                      PortOfDestination = portOfDestination != null ? portOfDestination.Name : "N/A",
                                      BrokerCommission = sale.BrokerComissionPc
                                  };



                dgvFormSales.DataSource = null;
                var salesViewList = displayList.ToList();
                _allSales = salesViewList.Select(x => (dynamic)x).ToList();
                dgvFormSales.DataSource = salesViewList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDgv()
        {
            dgvFormSales.Columns["ContractDate"].HeaderText = "Contract Date";
            dgvFormSales.Columns["CropYear"].HeaderText = "Crop Year";
            dgvFormSales.Columns["PricePerTon"].HeaderText = "Price Per Ton";
            dgvFormSales.Columns["MethodOfPayment"].HeaderText = "Method of Payment";
            dgvFormSales.Columns["PortOfLoading"].HeaderText = "Port of Loading";
            dgvFormSales.Columns["PortOfDestination"].HeaderText = "Port of Destination";
            dgvFormSales.Columns["BrokerCommission"].HeaderText = "Broker Comission";
            dgvFormSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormSales.MultiSelect = false;
            dgvFormSales.ReadOnly = true;
        }

        private void FormSales_Load_1(object sender, EventArgs e)
        {
            RefreshDgv();
            FormatDgv();
        }

        private void btnInsertFormSale_Click(object sender, EventArgs e)
        {
            FormSaleDetail formSaleDetail = new FormSaleDetail();

            if (formSaleDetail.ShowDialog() == DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnUpdateFormSale_Click(object sender, EventArgs e)
        {
            if (dgvFormSales.CurrentRow == null)
            {
                MessageBox.Show("Please select a Sale to update", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int selectedID = (int)dgvFormSales.CurrentRow.Cells["ID"].Value;
                Sales saletoEdit = _salesService.GetById(selectedID);
                if (saletoEdit != null)
                {
                    FormSaleDetail frmDetail = new FormSaleDetail(saletoEdit);
                    if (frmDetail.ShowDialog() == DialogResult.OK)
                    {
                        RefreshDgv();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error opening edit window: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_allSales == null)
            {
                return;
            }
            string searchText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvFormSales.DataSource = _allSales;
            }
            else
            {
                var filteredSales = _allSales.Where(sale =>
                                                            (sale.Customer != null && sale.Customer.ToLower().Contains(searchText)) ||
                                                            (sale.Product != null && sale.Product.ToLower().Contains(searchText)) ||
                                                            (sale.Status != null && sale.Status.ToLower().Contains(searchText)) ||
                                                            (sale.ContractDate != null && sale.ContractDate.ToLower().Contains(searchText)) ||
                                                            (sale.Shipper != null && sale.Shipper.ToLower().Contains(searchText)) ||
                                                            (sale.Seller != null && sale.Seller.ToLower().Contains(searchText)) ||
                                                            (sale.CropYear != null && sale.CropYear.ToString().ToLower().Contains(searchText)) ||
                                                            (sale.Quantity != null && sale.Quantity.ToString().ToLower().Contains(searchText)) ||
                                                            (sale.PricePerTon != null && sale.PricePerTon.ToString().ToLower().Contains(searchText)) ||
                                                            (sale.Currency != null && sale.Currency.ToLower().Contains(searchText)) ||
                                                            (sale.IncoTerm != null && sale.IncoTerm.ToLower().Contains(searchText)) ||
                                                            (sale.MethodOfPayment != null && sale.MethodOfPayment.ToLower().Contains(searchText)) ||
                                                            (sale.PortOfLoading != null && sale.PortOfLoading.ToLower().Contains(searchText)) ||
                                                            (sale.PortOfDestination != null && sale.PortOfDestination.ToLower().Contains(searchText)) ||
                                                            (sale.BrokerCommission != null && sale.BrokerCommission.ToString().ToLower().Contains(searchText))
                ).ToList();
                dgvFormSales.DataSource = null;
                dgvFormSales.DataSource = filteredSales;
            }
        }
    }
}
