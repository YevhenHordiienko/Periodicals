using Periodicals.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodicals.Domain.Abstract
{
    public interface IPeriodicalRepository
    {
        IEnumerable<Periodical> Periodicals { get; } 
    }
}
