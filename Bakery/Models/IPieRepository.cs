using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IPieRepository
    {
        // why only get? 
        IEnumerable<Pie> AllPies { get; }

        //List<Pie> PiesOfTheWeek { get; }

        Pie GetPieByID(int pieid);

    }
}
