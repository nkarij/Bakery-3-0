﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakery.Controllers
{
    public class PieController : Controller
    {
        // We get acces to the repositories data, via a _local, private field
        private readonly IPieRepository _pieRepository;

        // the repository will be initiated in the constructor
        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        //returning a viewresult with a payload, the name of the viewresult must correspond with
        // the name of the view file (look under Views>Pie>List)
        // also (I think) the folder structure must macth the controllername (minus controller)
        // and the viewresult name, 
        //so that the folder structure will be Views>Pie(controller)>List(viewresult) 
        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;
            return View(pieListViewModel);
        }

        // The view model should be able to send the reviews to the DetailsTest page..
        public ViewResult DetailsTest(int id)
        {
            var pie = _pieRepository.GetPieByID(id);
            var reviews = _pieRepository.GetReviewsByPieId(id);

            if (pie == null)
            {
                throw new Exception("error in Piecontroller > Details");
            }
            else
            {
                PieDetailsViewModel pieDetailsViewModel = new PieDetailsViewModel();
                pieDetailsViewModel.Pie = pie;
                if(reviews != null) { 
                pieDetailsViewModel.PieReviews = reviews;
                }
                return View(pieDetailsViewModel);
            }
        }

        //public IActionResult Details(int id)
        //{
        //    var pie = _pieRepository.GetPieByID(id);

        //    if(pie == null)
        //    {
        //        return NotFound();
        //    } else
        //    {
        //        return View(pie);
        //    }
        //}
    }
}
