using PersonalSite.Shared.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Financial
{
    public class Account
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public Person Owner { get; set; }
    }
}
