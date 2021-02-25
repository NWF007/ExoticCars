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
    public class OrderController : Controller
    {
        Order orderObj;
        /*Customer customerObj;*/
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IProductRepository productRepository;
        private readonly IExtraRepository extraRepository;
        private readonly IOrderProductRepository orderProductRepository;

        public OrderController(IOrderRepository orderRepository, ICustomerRepository customerRepository, IProductRepository productRepository, IExtraRepository extraRepository, IOrderProductRepository orderProductRepository)
        {
            this.orderRepository = orderRepository;
            this.customerRepository = customerRepository;
            this.productRepository = productRepository;
            this.extraRepository = extraRepository;
            this.orderProductRepository = orderProductRepository;
        }
        public IActionResult List(string status)
        {
            ViewBag.Message =  "All the orders are here";
            IEnumerable<Order> orders;

            orders = orderRepository.GetAllOrders;

            return View(new OrderViewModel
            {
                Orders = orders
            });
        }

        public IActionResult Create()
        {
            IEnumerable<Product> products;
            IEnumerable<Extra> extras;
            IEnumerable<Customer> customers;

            products = productRepository.GetProducts;
            extras = extraRepository.GetExtras;
            customers = customerRepository.GetCustomers;

            return View(new OrderViewModel
            {
                Products = products,
                Extras = extras,
                Customers = customers,
                /*OrderProduct = new OrderProduct(),
                Customer = new Customer()*/
                OrderProduct = new OrderProduct(),
                CustomerOrder = new CustomerOrder(),
                
            }) ; 
        }

        [HttpPost]
        public IActionResult Create(CustomerOrder customerOrder)
        {
            if (ModelState.IsValid)
            {
                orderRepository.PlaceOrder(customerOrder);
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Detail(int orderId)
        {
            ViewBag.Message = "View Customer Details";

            var order = orderRepository.GetOrderById(orderId);
            var orderDetail = orderProductRepository.GetOrderProductDetails(orderId);

/*            var extras = orderRepository.GetExtrasByCarOnOrder(orderId, productId);
*/

            if (order == null)
                return NotFound();

            return View(new OrderViewModel{
                Order = order,
                OrderProducts = orderDetail
            });
        }

        public IActionResult Extras(int orderId,int productId)
        {
            var extras = extraRepository.GetExtras;
            var order = orderRepository.GetOrderById(orderId);
            var product = productRepository.GetProductId(productId);
            return View(new ExtraViewModel
            {
                Extras = extras,
                Order = order,
                Product = product,
                ProductExtra = new ProductExtras()
            });
        }

        [HttpPost]
        public IActionResult Extras(ProductExtras productExtras)
        {
            if (productExtras != null)
            {
                /* var orderToUpdate = orderRepository.GetOrderById(order);*/
                /*var ordId = orderID;
                var prodId = productID;*/
                /*System.Diagnostics.Debug.WriteLine(productExtras);*/
                orderRepository.AddExtras(productExtras);

                return RedirectToAction("List");
            }
            return View();
        }


        public IActionResult OrderDetail(int orderId)
        {
            var orderDetail = orderProductRepository.GetOrderProductDetails(orderId);
            /*var orderTotal = orderRepository.GetOrderTotal(orderId);*/
            return View(orderDetail);
        }

        public IActionResult Edit(int orderId)
        {
            ViewBag.Message = "Edit page";
            IEnumerable<Order> orders = orderRepository.GetAllOrders;
            List<Order> data = orders.ToList();


            foreach (var ord in data)
            {
                if (ord.OrderID == orderId)
                {
                    orderObj = new Order
                    {
                        OrderID = ord.OrderID,
                        CustomerID = ord.CustomerID,
                        OrderDate = ord.OrderDate,
                        Status = ord.Status,
                        Comments = ord.Comments,
                        TotalAmount = ord.TotalAmount
                    };
                    break;
                }
            }
            return View(orderObj);
        }

        [HttpPost]
        public IActionResult EditOrder(Order order)
        {
            if (order != null)
            {
                /*var orderToUpdate = orderRepository.GetOrderById(order);
                System.Diagnostics.Debug.WriteLine(orderToUpdate.Status);*/
                orderRepository.UpdateOrder(order);

                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult Delete(int orderId)
        {
            ViewBag.Message = "Edit page";
            IEnumerable<Order> orders = orderRepository.GetAllOrders;
            List<Order> data = orders.ToList();


            foreach (var ord in data)
            {
                if (ord.OrderID == orderId)
                {
                    orderObj = new Order
                    {
                        OrderID = ord.OrderID,
                        CustomerID = ord.CustomerID,
                        OrderDate = ord.OrderDate,
                        Status = ord.Status,
                        Comments = ord.Comments,
                        TotalAmount = ord.TotalAmount
                    };
                    break;
                }
            }
            return View(orderObj);
        }

        [HttpPost]
        public IActionResult DeleteOrder(int orderId)
        {
            if (orderId > 0)
            {
                orderRepository.DeleteOrder(orderId);
                return RedirectToAction("List");
            }
            return View();
        }
    }
}
