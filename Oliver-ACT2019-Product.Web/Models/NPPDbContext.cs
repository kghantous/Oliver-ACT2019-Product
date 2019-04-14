using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oliver_ACT2019_Product.Web.Models
{
    public class NPPDbContext : DbContext
    {
        public NPPDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Region> Regions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Park> Parks { get; set; }
    }
}
