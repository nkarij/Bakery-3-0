using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public interface IReviewRepository
    {
        void CreateReview(Review review);
    }
}
