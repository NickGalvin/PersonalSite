using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Auth
{
    public class User 
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public string FacebookId { get; set; }
        //public string GoogleId { get; set; }

        public string Role { get; set; }
    }
}
