using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Shared
{
    public class WeddingRSVP
    {
        public WeddingRSVP()
        {
            Attendees = new List<WeddingAttendee>() { new WeddingAttendee() };
        }

        public string Id { get; set; }
        public DateTime RsvpDate { get; set; }

        public List<WeddingAttendee> Attendees { get; set; }

        public string Comments { get; set; }
    }
}
