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
    [Route("api/RSVP")]
    [ApiController]
    public class RSVPController : ControllerBase
    {
        private RsvpService _rsvpService;

        public RSVPController(RsvpService rsvpService)
        {
            _rsvpService = rsvpService;
        }

        [HttpGet]
        [Route("/All")]
        public IActionResult GetAllRSVP()
        {
            var rsvp = new List<WeddingRSVP>()
            {
                new WeddingRSVP()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Attendees = new List<WeddingAttendee>()
                    {
                        new WeddingAttendee()
                        {
                            Name = "Bentley",
                            DietaryRestrictions = "Steak and Peanut Butter",
                            Status = WeddingAttendee.AttendenceStatus.Accept
                        },
                        new WeddingAttendee()
                        {
                            Name = "Mandy",
                            DietaryRestrictions = "Nick's Penis",
                            Status = WeddingAttendee.AttendenceStatus.Accept
                        },
                    }
                },
                new WeddingRSVP()
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Attendees = new List<WeddingAttendee>()
                    {
                        new WeddingAttendee()
                        {
                            Name = "Number Two",
                            Status = WeddingAttendee.AttendenceStatus.Accept
                       },
                        new WeddingAttendee()
                        {
                            Name = "Dr. Evil",
                            Status = WeddingAttendee.AttendenceStatus.Accept
                        },
                    }
                },
            };

            //var allRsvp = _rsvpService.GetAllRSVP();
            return Ok(rsvp);
        }

        // GET: api/RSVP/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult SubmitRSVP(WeddingRSVP rsvp)
        {
            try
            {
                rsvp.Id = Guid.NewGuid().ToString();
                Response.Cookies.Append("RSVP", rsvp.Id);

                return Ok(rsvp);

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

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
