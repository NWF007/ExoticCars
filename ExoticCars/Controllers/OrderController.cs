﻿using ExoticCars.Models;
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
        Customer customerObj;
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
        public IActionResult List()
        {
            ViewBag.Message =  "All the orders are here";
            IEnumerable<Order> orders;

            orders = orderRepository.GetAllOrders;

            return View(new OrderViewModel
            {
                Orders = orders
            });
        }

        public IActionResult Detail(int orderId)
        {
            ViewBag.Message = "View Customer Details";

            var order = orderRepository.GetOrderById(orderId);
            if (order == null)
                return NotFound();

            return View(order);
        }

        /*public IActionResult OrderPlaced()
        {

            var orders = orderRepository.GetAllOrders.ToList();
            foreach(var order in orders)
            {
                if(order.Status == "OrderPlaced")
            }

            return View(order);
        }*/

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
                        Comments = ord.Comments,
                        TotalAmount = ord.TotalAmount
                    };
                    break;
                }
            }
            return View(orderObj);
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
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
                        Comments = ord.Comments,
                        TotalAmount = ord.TotalAmount
                    };
                    break;
                }
            }
            return View(orderObj);
        }
    }
}
