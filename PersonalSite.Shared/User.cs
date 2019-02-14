using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class User : IUser
    {
        string IUser<string>.Id { get; }
        string IUser<string>.UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string FacebookId { get; set; }
        public string GoogleId { get; set; }

    }
}
