using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Review
    {
        public Review(){}

        public int Id { get; set; } 
        public string ReviewText { get; set; }

        public int Stars { get; set; }
        public int PieId { get; set; }

        // maybe this is not necessary: ?
        //public Pie Pie { get; set; }
    }
}

