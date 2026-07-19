using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Sales
    {
        public int ID {  get; set; }
        public int? IdCustomer { get; set; }
        public int? IdProduct { get; set; }
        public int? IdStatus { get; set; }
        public DateTime? ContractDate { get; set; }
        public string Shipper {  get; set; }
        public string Seller { get; set; }
        public string CropYear { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PricePerTon { get; set; }
        public int? IdCurrency { get; set; }
        public int? IdIncoTerm { get; set; }
        public int? IdMethodOfPayment { get; set; }
        public int? IdPortOfLoading { get; set; }
        public int? IdPortOfDestination { get; set; }
        public decimal? BrokerComissionPc { get; set; }

    }
}
