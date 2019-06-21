using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodicals.Domain.Entities
{
    public class Periodical
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISSN { get; set; }
        public string PublicationFrequency { get; set; }
        public string CountryOrAreaOfPublication { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string SubjectArea { get; set; }
        public string Description { get; set; }
    }
}
