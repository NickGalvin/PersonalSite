using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class Order
    {
        public string Id { get; set; }

        public Customer Customer { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public List<Item> Items { get; set; }
        public List<AppliedCoupon> AppliedCoupons { get; set; }

        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public string PreferredMethodOfContact { get; set; }
    }
}
