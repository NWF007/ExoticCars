using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewBag.Message = "Find all our cars here";
            return View();
        }
    }
}
