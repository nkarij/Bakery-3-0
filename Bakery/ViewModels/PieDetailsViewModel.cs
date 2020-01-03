using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.ViewModels
{
    public class PieDetailsViewModel
    {
        public Pie Pie { get; set; }
        public IEnumerable<Review> PieReviews { get; set; }
    }



}
