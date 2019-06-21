using Periodicals.Domain.Abstract;
using Periodicals.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodicals.Domain.Concrete
{
    public class PeriodicalRepository : IPeriodicalRepository
    {
        private PeriodicalsDBContext _periodicalDBContext = new PeriodicalsDBContext();

        public IEnumerable<Periodical> Periodicals
        {
            get { return _periodicalDBContext.Periodicals; }
        }
    }
}
