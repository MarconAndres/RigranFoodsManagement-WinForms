using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Shipments
    {
        public int ID { get; set; }
        public int? IdSales { get; set; }
        public int? IdShipmentStatus { get; set; }
        public string BookingNumber { get; set; }
        public string ContainerNumber { get; set; }
        public int? IdContainerType { get; set; }
        public string ShippingLine {  get; set; }
        public int? IdPortOfLoading { get; set; }
        public int? IdPortOfDestination { get; set; }
        public DateTime? ETD { get; set; }
        public DateTime? ATD { get; set; }
        public DateTime? ETA { get; set; }
        public DateTime? ATA { get; set; }
        public string FreeDays { get; set; }
        public Boolean BLApproved { get; set; }
        public string DHLNumber { get; set; }
        public Boolean HasClaim { get; set; }
        public string ClaimNotes { get; set; }
        public string Notes { get; set; }

    }
}
