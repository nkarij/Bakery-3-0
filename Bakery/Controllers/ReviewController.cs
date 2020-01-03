using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.ViewModels;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakery.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;
        private Review _FormFeed;         

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET request
        public IActionResult Checkout(int pieId)
        {
            // Because of modelbinding? ViewResult will not work, so I dont see any other way to pass the
            // pie id than in the viewbag.
            ViewBag.PieId = pieId;
            return View();
        }

        //public ViewResult Checkout(int pieId)
        //{
        //        ReviewFormViewModel reviewFormViewModel = new ReviewFormViewModel();
        //        reviewFormViewModel.PieId = pieId;
        //        reviewFormViewModel.ReviewForm = new Review();
        //        return View(reviewFormViewModel);
        //}

        // post request
        [HttpPost]
        public IActionResult Checkout(Review review)
        {

            _FormFeed = review;
            // Hvordan får jeg mit pieId med fra order formen?          

            if(_FormFeed.ReviewText == "")
            {
                ModelState.AddModelError("", "Your Review is empty");
            }

            if(ModelState.IsValid)
            {
                _reviewRepository.addReviewToDatabase(review);
                return RedirectToAction("ReviewComplete");
            }

            return View(review);
        }

        public IActionResult ReviewComplete()
        {
            ViewBag.ReviewCompleteMessage = "Thank you for the review";
            return View();
        }
    }
}
