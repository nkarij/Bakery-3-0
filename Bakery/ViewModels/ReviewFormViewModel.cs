using Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.ViewModels
{
    public class ReviewFormViewModel
    {
        public int PieId { get; set; }

        public Review ReviewForm { get; set; }
        public IEnumerable<Review> PieReviews { get; set; }
    }
}
