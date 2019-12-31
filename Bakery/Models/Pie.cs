using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        //public int CategoryID { get; set; }
        //public Category Category { get; set; }

    }
}
