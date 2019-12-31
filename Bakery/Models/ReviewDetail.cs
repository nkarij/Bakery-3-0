using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class ReviewDetail
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }

        public Review Review { get; set; }

    }
}

