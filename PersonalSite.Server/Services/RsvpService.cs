using Microsoft.AspNetCore.Hosting;
using PersonalSite.Server.Data;
using PersonalSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server.Services
{
    public class RsvpService
    {
        private IHostingEnvironment _env;
        private RsvpDbContext _rsvpDb;

        public RsvpService(IHostingEnvironment env, RsvpDbContext rsvpDbContext)
        {
            _env = env;
            _rsvpDb = rsvpDbContext;
        }

        public async void SaveRSVP(WeddingRSVP rsvp)
        {
            _rsvpDb.RSVPs.Add(rsvp);
            await _rsvpDb.SaveChangesAsync();
        }

        public List<WeddingRSVP> GetAllRSVP()
        {
            return _rsvpDb.RSVPs.ToList();
        }
    }
}
