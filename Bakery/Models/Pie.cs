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

        // this must be rendered to the detail page... But how? There will be no data in Pie database.
        public IEnumerable<Review> PieReviews { get; set; }

    }
}
