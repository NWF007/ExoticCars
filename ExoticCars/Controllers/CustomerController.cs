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
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        /*public IActionResult List()
        {
            ViewBag.Message = "Welcome Customers";
            return View();
        }*/

        public ViewResult List()
        {
            IEnumerable<Customer> customers;

            customers = customerRepository.GetCustomers;

            return View(new CustomerViewModel
            {
                Customers = customers
            });
        }

        public IActionResult Edit()
        {
            ViewBag.Message = "Edit page";
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerRepository.AddCustomer(customer);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Delete(int customerId)
        {
            ViewBag.Message = "Delete page";
            return View();
        }
    }
}
