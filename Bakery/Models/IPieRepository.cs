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

        public IEnumerable<Review> GetReviewsByPieId(int pieid);

        Pie GetPieByID(int pieid);

    }
}
