using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class SalePrice
    {
        public string ItemId { get; set; }
        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
