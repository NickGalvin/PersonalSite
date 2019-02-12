using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Auth
{
    public class UserProfile
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfilePhoto { get; set; }

        public static UserProfile TestProfile() => new UserProfile
        {
            FirstName = "Nick",
            LastName = "Galvin",
            Email = "nick.m.galvin@gmail.com",
            UserId = "1"
        };
    }
}
