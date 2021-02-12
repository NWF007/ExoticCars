using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Controllers
{
    public class ExtraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
