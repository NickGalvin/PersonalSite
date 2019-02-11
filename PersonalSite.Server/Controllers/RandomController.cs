using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace PersonalSite.Server.Controllers
{
    [Route("api/Random")]
    public class RandomController : ControllerBase
    {
        public RandomController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello");
        }

        [HttpGet("Key")]
        public IActionResult GenerateKey()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var key = new byte[64];
                rng.GetBytes(key);
                return new JsonResult(Convert.ToBase64String(key));
            }
        }
    }
}
