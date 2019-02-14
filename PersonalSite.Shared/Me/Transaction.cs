using PersonalSite.Shared.Financial;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Me
{
    public class Transaction
    {
        public string Id { get; set; }

        public decimal Amount { get; set; }
        public string Reason { get; set; }

        public Account Source { get; set; }
        public Account Destination { get; set; }
    }
}
