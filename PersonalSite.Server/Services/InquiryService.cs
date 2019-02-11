using PersonalSite.Server.Data;
using PersonalSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server.Services
{
    public class InquiryService
    {
        private readonly PersonalSiteDbContext _db;

        public InquiryService(PersonalSiteDbContext db)
        {
            _db = db;
        }

        public Inquiry SubmitInquiry(Inquiry submitted)
        {
            submitted.Id = Guid.NewGuid().ToString("N");
            submitted.Timestamp = DateTime.UtcNow;

            _db.Inquiries.Add(submitted);

            return submitted;
        }
    }
}
