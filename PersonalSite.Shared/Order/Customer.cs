using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Order
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
