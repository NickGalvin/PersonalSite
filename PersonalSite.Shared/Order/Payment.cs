using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Order
{
    public class Payment
    {
        public string Id { get; set; }
        public PaymentMethod Method { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public PaymentStatus Status { get; set; }
        public string Notes { get; set; }

        public string ThirdPartyAuthorizationId { get; set; }
        public string ThirdPartyTransactionId { get; set; }
        public string ThirdPartyDetails { get; set; }
    }
}
