using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Auth
{
    public class AuthenticateResponse
    {
        public string Token { get; set; }
        public UserProfile Profile { get; set; }
    }
}
