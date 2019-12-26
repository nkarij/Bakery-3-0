using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class MockPieRepository : IPieRepository
    {

        public MockPieRepository()
        {
            
        }

        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{PieID=1, Name="Blueberry Pie", ShortDescription="This is a Blueberry Pie", Price=12},
            new Pie{PieID=2, Name="Chokolade Pie", ShortDescription="This is a Chokolade Pie", Price=13},
            new Pie{PieID=3, Name="Cheese Cake", ShortDescription="This is a Cheese Cake", Price=14},
            new Pie{PieID=4, Name="Brownie", ShortDescription="This is a Brownie", Price=15},
            new Pie{PieID=5, Name="Apple Pie", ShortDescription="This is a Apple Pie", Price=16},
            new Pie{PieID=6, Name="Kiwi Pie", ShortDescription="This is a Kiwi Pie", Price=17}
        };

        public Pie GetPieByID(int pieid)
        {
            return AllPies.FirstOrDefault(p => p.PieID == pieid);
        }
    }
}
