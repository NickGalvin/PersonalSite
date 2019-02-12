using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PersonalSite.Shared;
using PersonalSite.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalSite.Server.Data
{
    public class SiteDbContext : DbContext
    {
        public SiteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
