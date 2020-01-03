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

        // this method will add the form info to the database
        public void addReviewToDatabase(Review review)
        {
            _appDbContext.Reviews.Add(review);
            _appDbContext.SaveChanges();
        }
    }
}
