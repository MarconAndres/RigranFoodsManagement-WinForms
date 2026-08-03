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
                dgvFormSales.DataSource = displayList.ToList();
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
    }
}
