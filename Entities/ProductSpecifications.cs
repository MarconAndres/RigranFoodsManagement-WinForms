using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ProductSpecifications
    {
        public int ID { get; set; } 
        public int? IdProductMaster { get; set; }
        public string Size { get; set; }
        public string Moisture { get; set; }
        public string SplitAndBroken { get; set; }
        public string Foreignmatter { get; set; }
        public string TotalDamage { get; set; }
        public string Purity { get; set; }
        public string AddSpecs { get; set; }
    }
}
