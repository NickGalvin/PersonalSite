using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalSite.Shared;

namespace PersonalSite.Server.Data
{
    public class RsvpDbContext : DbContext
    {
        public RsvpDbContext(DbContextOptions<RsvpDbContext> options) : base(options)
        {
        }

        public DbSet<WeddingRSVP> RSVPs { get; set; }
    }
}
