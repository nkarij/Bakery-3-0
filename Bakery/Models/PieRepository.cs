using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class PieRepository : IPieRepository
    {
        //the repo needs acces to AppDbContext - readonly
        // the repo will use AppDbContext to persist and read data in the database
        private readonly AppDbContext _appDbContext;

        // through ctor injection, we will have acces to the AppDbContext
        public PieRepository(AppDbContext appDbContext)
        {
            // local field = injected parameter
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies { 
            get
            {
                return _appDbContext.Pies;
            }
        }

        public Pie GetPieByID(int pieid)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieID == pieid);
        }


    }
}
