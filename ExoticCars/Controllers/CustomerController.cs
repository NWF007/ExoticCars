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
        Customer customerObj;
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

        public IActionResult Edit(int customerId)
        {
            ViewBag.Message = "Edit page";
            IEnumerable<Customer> customers = customerRepository.GetCustomers;
            List<Customer> data = customers.ToList();

            /*List<Customer> customers = new List<Customer>();*/

            foreach (var cust in data)
            {
                if (cust.CustomerID == customerId)
                {
                    customerObj = new Customer
                    {
                        CustomerID = cust.CustomerID,
                        FirstName = cust.FirstName,
                        LastName = cust.LastName,
                        Phone = cust.Phone,
                        Address = cust.Address,
                        City = cust.City,
                        PostalCode = cust.PostalCode
                    };
                    break;
                }
            }
            return View(customerObj);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerRepository.UpdateCustomer(customer);
                return RedirectToAction("List");
            }
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
            IEnumerable<Customer> customers = customerRepository.GetCustomers;
            List<Customer> data = customers.ToList();

            /*List<Customer> customers = new List<Customer>();*/

            foreach (var cust in data)
            {
                if (cust.CustomerID == customerId)
                {
                    customerObj = new Customer
                    {
                        CustomerID = cust.CustomerID,
                        FirstName = cust.FirstName,
                        LastName = cust.LastName,
                        Phone = cust.Phone,
                        Address = cust.Address,
                        City = cust.City,
                        PostalCode = cust.PostalCode
                    };
                    break;
                }
            }
            return View(customerObj);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerRepository.DeleteCustomer(customer);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Detail(int customerId)
        {
            ViewBag.Message = "View Customer Details";
            
            var customer = customerRepository.GetCustomerById(customerId);
            if (customer == null)
                return NotFound();

            return View(customer);
        }
    }
}
