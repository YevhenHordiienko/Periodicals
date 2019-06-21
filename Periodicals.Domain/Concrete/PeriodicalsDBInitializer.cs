using Periodicals.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodicals.Domain.Concrete
{
    class PeriodicalsDBInitializer : DropCreateDatabaseAlways<PeriodicalsDBContext>
    {
        protected override void Seed(PeriodicalsDBContext db)
        {
            db.Periodicals.Add(new Periodical
            {
                Name = "American Periodicals",
                Description = "A Journal of History, Criticism, and Bibliography",
                ISSN = "1054-7479",
                Type = "Journal",
                Price = 20,
                SubjectArea = "General"
            } );
            db.Periodicals.Add(new Periodical
            {
                Name = "Aircraft Engineering and Aerospace Technology",
                Description = "A Journal of History, Criticism, and Bibliography",
                ISSN = "1748-8842",
                Type = "Journal",
                Price = 50,
                CountryOrAreaOfPublication = "England",
                PublicationFrequency = "Bimonthly",
                SubjectArea = "Engineering"
            } );
            db.Periodicals.Add(new Periodical
            {
                Name = "International Journal of Industrial Electronics and Electrical Engineering",
                Description = "International Journal of Industrial Electronics and Electrical Engineering (IJIEEE) is Open access, International Journal that publishes original research articles as well as review articles and dedicated to the latest advancement in Electronics, Electrical Engineering",
                ISSN = "2349-204X",
                Type = "Journal",
                Price = 0,
                CountryOrAreaOfPublication = "India",
                PublicationFrequency = "Monthly",
                SubjectArea = "Engineering"
            } );
            db.Periodicals.Add(new Periodical
            {
                Name = "SN Computer Science",
                Description = "Broad-based, peer reviewed journal that publishes original research in all the disciplines of computer science including various inter-disciplinary aspects",
                ISSN = "2661-8907",
                Type = "Journal",
                Price = 0,
                CountryOrAreaOfPublication = "India",
                PublicationFrequency = "Monthly",
                SubjectArea = "Engineering"
            } );

            db.SaveChanges();
        }
    }
}
