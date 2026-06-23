using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CustomerProductProfile
    {
        public int ID { get; set; }
        public int IdProductMaster { get; set; }
        public decimal AnnualVolume { get; set; }
        public int IdPreferredPackaging { get; set; }
        public int IdPurchaseFrequency { get; set; }
        public int IdPriceSensitivity { get; set; }
        public string AlternativeOrigin { get; set; }
        public int IdQualityStandart { get; set; }
        public string Notes {  get; set; }

    }
}
