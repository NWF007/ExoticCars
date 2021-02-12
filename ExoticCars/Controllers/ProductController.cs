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
        Product productObj;
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

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

        public IActionResult Edit(int productId)
        {
            ViewBag.Message = "Edit page";
            IEnumerable<Product> products = productRepository.GetProducts;
            List<Product> data = products.ToList();

            /*List<Customer> customers = new List<Customer>();*/

            foreach (var prod in data)
            {
                if (prod.ProductID == productId)
                {
                    productObj = new Product
                    {
                        ProductID = prod.ProductID,
                        Name = prod.Name,
                        Model = prod.Model,
                        SellingPrice = prod.SellingPrice,
                        CostPrice = prod.CostPrice,
                        Year = prod.Year,
                        EngineNo = prod.EngineNo
                    };
                    break;
                }
            }
            return View(productObj);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productRepository.UpdateProduct(product);
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
