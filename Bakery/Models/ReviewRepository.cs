using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateReview(Review review)
        {
            var newReview = review;

        }

        // what are we receiving here? Not the review, we are posting from the form, but not to here.

        //public void CreateReview(Review review)
        //{

        //    _appDbContext.Reviews.Add(review);

        //    var details = review.ReviewDetails;

        //    foreach (var item in details)
        //    {
        //        var reviewDetail = new ReviewDetail()
        //        {
        //            ReviewId = review.Id,
        //            PieId = item.Pie.PieId,
        //            //ReviewText = review.ReviewText,
        //            //Stars = review.Stars,
        //        };
        //        _appDbContext.Details.Add(reviewDetail);
        //    }

        //    _appDbContext.SaveChanges();
        //}

    }
}
