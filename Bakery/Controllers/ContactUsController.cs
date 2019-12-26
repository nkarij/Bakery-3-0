using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bakery.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsRepository _contactUsRepository;

        public ContactUsController(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        public ViewResult InfoPage()
        {
            InfoPageViewModel infoPageViewModel = new InfoPageViewModel();
            infoPageViewModel.Info = _contactUsRepository.AllInfo;
            return View(infoPageViewModel);
        }
    }
}
    