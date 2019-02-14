using PersonalSite.Shared.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Order
{
    public class Order
    {
        public string Id { get; set; }

        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }

        public decimal Subtotal { get; set; }
        public decimal DeliveryAmount { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public Customer Customer { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        List<Item> Items { get; set; }
        public List<AppliedCoupon> AppliedCoupons { get; set; }

        public List<DeliveryOption> DeliveryOptions { get; set; }

        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Notes that will appear in the order
        /// </summary>
        public string Notes { get; set; }
        
        /// <summary>
        /// Notes that are only available to interal employees
        /// </summary>
        public string InternalNotes { get; set; }

        public string PreferredMethodOfContact { get; set; }
    }
}
