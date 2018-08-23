using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.Shared;
using PersonalSite.Server.Services;

namespace PersonalSite.Server.Controllers
{
    [Route("api/RSVP/")]
    public class RSVPController : ControllerBase
    {
        private RsvpService _rsvpService;

        public RSVPController(RsvpService rsvpService)
        {
            _rsvpService = rsvpService;
        }

        [HttpGet("[action]")]
        public IActionResult List()
        {
            var rsvp = new List<WeddingRSVP>()
            {
                new WeddingRSVP()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    RsvpDate = DateTime.Now,
                    Comments = "Please make sure there is plenty of steak and peanut butter otherwise Bentley will get furrrocious.",
                    Attendees = new List<WeddingAttendee>()
                    {
                        new WeddingAttendee()
                        {
                            Name = "Bentley",
                            DietaryRestrictions = "Steak and Peanut Butter",
                            Status = AttendenceStatus.Accept
                        },
                        new WeddingAttendee()
                        {
                            Name = "Mandy",
                            DietaryRestrictions = "Nick's Penis",
                            Status = AttendenceStatus.Accept
                        },
                    }
                },
                new WeddingRSVP()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    RsvpDate = DateTime.Now,
                    Comments = "Please make sure there is plenty of steak and peanut butter otherwise Bentley will get furrrocious.",
                    Attendees = new List<WeddingAttendee>()
                    {
                        new WeddingAttendee()
                        {
                            Name = "Bentley",
                            DietaryRestrictions = "Steak and Peanut Butter",
                            Status = AttendenceStatus.Accept
                        },
                        new WeddingAttendee()
                        {
                            Name = "Mandy",
                            DietaryRestrictions = "Nick's Penis",
                            Status = AttendenceStatus.Accept
                        },
                    }
                }
            };

            //var allRsvp = _rsvpService.GetAllRSVP();
            return new JsonResult(rsvp);
        }

        [HttpPost]
        public IActionResult SubmitRSVP(WeddingRSVP rsvp)
        {
            try
            {
                rsvp.Id = Guid.NewGuid().ToString();
                Response.Cookies.Append("RSVP", rsvp.Id);

                return Ok();

                //_rsvpService.SaveRSVP(rsvp);
                //return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error: " + e);
                return BadRequest("There was an error");
            }
        }

        // PUT: api/RSVP/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
