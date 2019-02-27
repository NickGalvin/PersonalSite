using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Server.Services;
using PersonalSite.Shared;

namespace PersonalSite.Server.Controllers
{
    [Route("api/About")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly InquiryService inquiryService;

        public AboutController(InquiryService inquiryService)
        {
            this.inquiryService = inquiryService;
        }

        [HttpGet("/Me")]
        public  IActionResult Me()
        {
            return Ok(new { });
        }
    }
}