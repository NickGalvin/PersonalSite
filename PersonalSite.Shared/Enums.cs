using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public enum Role
    {
        Admin,
        Wifey,
        Family,
        Friend,
        User,
        Guest
    }

    public enum PaymentMethod
    {
        None,
        CreditCard,
        PayPal,
        GooglePay,
        ApplePay,
        Venmo,
        Bitcoin
    }

    public enum PaymentStatus
    {
        None,
        Authorized,
        Captured,
        Error
    }
}
