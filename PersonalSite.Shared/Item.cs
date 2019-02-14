using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class Item
    {
        public string Id { get; set; }
        public string Sku { get; set; }

        public string DisplayName { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public List<SalePrice> SalePrices { get; set; }

        public List<string> Tags { get; set; }
    }
}
