using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Main");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Bag bag)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(bag);

                return View("CreatedBag", bag);
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult ListBags()
        {
            return View(Repository.GetRep());
        }
    }
}
