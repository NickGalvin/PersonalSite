using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Auth
{
    public class AuthenticationRequest
    {
        public string Username { get; set; }
        public string ProvidedPassword { get; set; }
    }
}
