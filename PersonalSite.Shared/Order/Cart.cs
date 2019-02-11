using PersonalSite.Shared.Auth;
using PersonalSite.Shared.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Order
{
    public class Cart
    {
        public string UserId { get; set; }
        public User User { get; set; }

        List<Item> Items { get; set; }
        public List<DeliveryOption> DeliveryOptions { get; set; }

        public string ShippingAddressId { get; set; }
        public Address ShippingAddress { get; set; }

        public string BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
    }
}
