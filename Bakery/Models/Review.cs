using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Review
    {
        public int Id { get; set; } 

        //public List<ReviewDetail> ReviewDetails { get; set; }

        public string ReviewText { get; set; }

        public int Stars { get; set; }
        public int PieId { get; set; }
        public Pie Pie { get; set; }
    }
}

