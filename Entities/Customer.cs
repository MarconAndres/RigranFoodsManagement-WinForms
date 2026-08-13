using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? IdBusinessSector { get; set; }
        public string RegisteredName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string VAT { get; set; }
        public int? IdCountry { get; set; }
        public string PhoneNumber { get; set; }
        public string BIO { get; set; }
        public string EORI { get; set; }
        public bool Active { get; set; }
    }
}
