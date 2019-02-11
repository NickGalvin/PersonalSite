using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Shared;
using PersonalSite.Server.Services;
using PersonalSite.Shared.Authentication;

namespace PersonalSite.Server.Controllers
{
    [Route("api/user/")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpPost("[action]")]
        public IActionResult Login()
        {
            var response = new LoginResult() { Success = false, Message = "test" };
            return Ok(response);
        }     
    }
}
