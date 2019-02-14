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
    [Route("api/Inquiry")]
    [ApiController]
    public class InquiryController : ControllerBase
    {
        private readonly InquiryService inquiryService;

        public InquiryController(InquiryService inquiryService)
        {
            this.inquiryService = inquiryService;
        }

        [HttpPost("/")]
        public  IActionResult SubmitInquiry(Inquiry inquiry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(inquiry);
            }

            var submission = inquiryService.SubmitInquiry(inquiry);

            return Ok(submission);
        }
    }
}