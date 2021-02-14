using ExoticCars.Models;
using ExoticCars.Repositories;
using ExoticCars.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Controllers
{
    public class ExtraController : Controller
    {
        Extra extraObj;
        private readonly IExtraRepository extraRepository;

        public ExtraController(IExtraRepository extraRepository)
        {
            this.extraRepository = extraRepository;
        }
        /*public IActionResult List()
        {
            ViewBag.Message = "Welcome Customers";
            return View();
        }*/

        public ViewResult List()
        {
            IEnumerable<Extra> extras;

            extras = extraRepository.GetExtras;

            return View(new ExtraViewModel
            {
                Extras = extras
            });
        }

        public IActionResult Edit(int extraId)
        {
            ViewBag.Message = "Edit page";
            IEnumerable<Extra> extras = extraRepository.GetExtras;
            List<Extra> data = extras.ToList();

            /*List<Customer> customers = new List<Customer>();*/

            foreach (var ex in data)
            {
                if (ex.ExtraID == extraId)
                {
                    extraObj = new Extra
                    {
                        ExtraID = ex.ExtraID,
                        ExtraName = ex.ExtraName,
                        ExtraPrice = ex.ExtraPrice
                    };
                    break;
                }
            }
            return View(extraObj);
        }

        [HttpPost]
        public IActionResult Edit(Extra extra)
        {
            if (ModelState.IsValid)
            {
                extraRepository.UpdateExtra(extra);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Extra extra)
        {
            if (ModelState.IsValid)
            {
                extraRepository.AddExtra(extra);
                return RedirectToAction("List");
            }
            return View();
        }


        public IActionResult Delete(int extraId)
        {
            ViewBag.Message = "Delete page";
            IEnumerable<Extra> extras = extraRepository.GetExtras;
            List<Extra> data = extras.ToList();

            /*List<Customer> customers = new List<Customer>();*/

            foreach (var ex in data)
            {
                if (ex.ExtraID == extraId)
                {
                    extraObj = new Extra
                    {
                        ExtraID = ex.ExtraID,
                        ExtraName = ex.ExtraName,
                        ExtraPrice = ex.ExtraPrice
                    };
                    break;
                }
            }
            return View(extraObj);
        }

        [HttpPost]
        public IActionResult Delete(Extra extra)
        {
            if (ModelState.IsValid)
            {
                extraRepository.DeleteExtra(extra);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Detail(int extraId)
        {
            ViewBag.Message = "View Customer Details";

            var extra = extraRepository.GetExtraId(extraId);
            if (extra == null)
                return NotFound();

            return View(extra);
        }
    }
}
