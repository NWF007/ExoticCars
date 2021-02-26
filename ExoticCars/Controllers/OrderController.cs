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
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerRepository customerRepository;
        private readonly IProductRepository productRepository;
        private readonly IExtraRepository extraRepository;
        private readonly IOrderProductRepository orderProductRepository;

        public OrderController(IOrderRepository orderRepository, 
            ICustomerRepository customerRepository, IProductRepository productRepository, 
            IExtraRepository extraRepository, IOrderProductRepository orderProductRepository)
        {
            this.orderRepository = orderRepository;
            this.customerRepository = customerRepository;
            this.productRepository = productRepository;
            this.extraRepository = extraRepository;
            this.orderProductRepository = orderProductRepository;
        }
        public IActionResult List(int? customerId)
        {
            ViewBag.Message =  "All the orders are here";
            IEnumerable<Order> orders;

            if(customerId == null)
            {
                orders = orderRepository.GetAllOrders;
            }
            else
            {
                orders = orderRepository.GetOrdersByCustomerId(customerId);
            }

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

        public IActionResult Detail(int orderId, int customerId)
        {
            ViewBag.Message = "View Customer Details";

            var order = orderRepository.GetOrderById(orderId);
            var orderDetail = orderProductRepository.GetOrderProductDetails(orderId);
            var orderAmount = orderRepository.GetOrderTotal(orderId);
            var customer = customerRepository.GetCustomerById(order.CustomerID);
            if (order == null)
                return NotFound();

            return View(new OrderViewModel{
                Order = order,
                OrderProducts = orderDetail,
                TotalOrderAmount = orderAmount,
                Customer = customer
            });
        }

        public IActionResult ViewExtras(int orderId, int productId)
        {
            var productExtras = orderRepository.GetExtrasByCarOnOrder(orderId, productId);
            var order = orderRepository.GetOrderById(orderId);
            var car = productRepository.GetProductId(productId);            

            if(productExtras == null)
            {
                return NotFound();
            }

            return View(new OrderViewModel { 
                OrderProducts = productExtras,
                Order = order,
                Product  = car
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
                orderRepository.AddExtras(productExtras);

                return RedirectToAction("List");
            }
            return View();
        }


        public IActionResult OrderDetail(int orderId)
        {
            var orderDetail = orderProductRepository.GetOrderProductDetails(orderId);
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
                        Comments = ord.Comments
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
                        Comments = ord.Comments
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
