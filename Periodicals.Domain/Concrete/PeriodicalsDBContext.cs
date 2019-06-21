using Periodicals.Domain.Entities;
using System.Data.Entity;

namespace Periodicals.Domain.Concrete
{
    class PeriodicalsDBContext : DbContext
    {
        public DbSet<Periodical> Periodicals { get; set; }

        static PeriodicalsDBContext()
        {
            Database.SetInitializer<PeriodicalsDBContext>(new PeriodicalsDBInitializer());
        }

    }
}
