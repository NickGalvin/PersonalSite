using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class Coupon
    {
        public string Id { get; set; }
        public string CouponCode { get; set; }
        public DiscountType DiscountType { get; set; }
        public DiscountApplicationLevel ApplicationLevel { get; set; }

        /// <summary>
        /// Can be used with other coupons
        /// </summary>
        public bool CanStack { get; set; }
    }

    public enum DiscountType
    {
        DollarAmount,
        Percentage
    }

    public enum DiscountApplicationLevel
    {
        WholeOrder,
        SingleItem
    }
}
