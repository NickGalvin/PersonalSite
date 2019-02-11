using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class AppliedCoupon
    {
        /// <summary>
        /// Order Id the coupon was applied to
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// ItemId the copon was applied to [If the coupon has application level of item]
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// ID of the applied coupon
        /// </summary>
        public string CouponId { get; set; }

        /// <summary>
        /// Customer that used the coupon
        /// </summary>
        public string CustomerId { get; set; }
    }
}
