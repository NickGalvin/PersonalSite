using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared.Authentication
{
    public class LoginResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
    }
}
