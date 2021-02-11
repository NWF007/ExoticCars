using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message =  "All the orders are here";
            return View();
        }
    }
}
