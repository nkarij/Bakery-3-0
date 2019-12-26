using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }

        public String RouteToInfoPage { get; set; }
    }
}
