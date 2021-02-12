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
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        /* public IActionResult List()
         {
             ViewBag.Message = "Find all our cars here";
             return View();
         }*/

        public ViewResult List()
        {
            IEnumerable<Product> products;

            products = productRepository.GetProducts;

            return View(new ProductViewModel
            {
                Products = products
            });
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                productRepository.AddProduct(product);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Detail(int productId)
        {
            ViewBag.Message = "View Customer Details";

            var product = productRepository.GetProductId(productId);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
