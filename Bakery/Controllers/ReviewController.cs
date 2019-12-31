using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.ViewModels;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakery.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;
        private Review _singleReview;
        private int _receivedPieId;
         

        public ReviewController(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        // GET request
        public IActionResult Checkout(int pieid)
        {
            // denne bliver ikke gemt til senere
            _receivedPieId = pieid;
            return View();
        }


        // post request
        [HttpPost]
        public IActionResult Checkout(Review review)
        {
            
            _singleReview = review;
            // Hvordan får jeg mit pieId med fra order formen?          

            if(_singleReview.ReviewText == "")
            {
                ModelState.AddModelError("", "Your Review is empty");
            }

            if(ModelState.IsValid)
            {
                _reviewRepository.CreateReview(review);
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
