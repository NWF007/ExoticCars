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
    public class CustomerController : Controller
    {

        public CustomerController()
        {
        }
        public IActionResult List()
        {
            ViewBag.Message = "Welcome Customers";
            return View();
        }

        /*public ViewResult List()
        {
            IEnumerable<Customer> customers;

            return View(new CustomerListViewModel
            {
                Customer = customers
            });
        }*/
    }
}
