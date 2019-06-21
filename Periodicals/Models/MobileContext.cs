using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Periodicals.Web.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext():base("MobileContext")
        {
                
        }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public System.Data.Entity.DbSet<Periodicals.Domain.Entities.Periodical> Periodicals { get; set; }
    }
}