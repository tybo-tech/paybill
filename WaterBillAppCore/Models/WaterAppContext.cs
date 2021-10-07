using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterBillAppCore.Areas.Identity.Data;
using WaterBillAppCore.Models;

namespace WaterBillAppCore.Models
{
    public class WaterAppContext : IdentityDbContext<AppUser>
    {
        public WaterAppContext(DbContextOptions<WaterAppContext> options):base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<Billitem> billitems { get; set; }
        public DbSet<Query> queries { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<QueryType> querytypes { get; set; }
        public DbSet<Vat> vats { get; set; }
        public DbSet<UserType> usertypes { get; set; }

        // public DbSet<AppUser> AspNetUsers { get; set; }
    }
}
