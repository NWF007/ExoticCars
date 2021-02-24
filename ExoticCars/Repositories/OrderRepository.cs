using ExoticCars.DAL;
using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ExoticCarContext dbContext;

        public OrderRepository(ExoticCarContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Order> GetAllOrders
        {
            get
            {
                return dbContext.Orders;
            }
        }

        public void DeleteOrder(int orderId)
        {
            var order = dbContext.Orders.FirstOrDefault(o => o.OrderID == orderId);

            if(order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
        }

        public Order GetOrderById(int orderId)
        {
            return dbContext.Orders.FirstOrDefault(c => c.OrderID == orderId);
        }

        public IEnumerable<Order> GetOrdersByStatus(string status)
        {
            return dbContext.Orders.Where(c => c.Status.Equals(status));
        }

       /* public int? GetOrderTotal(int orderId)
        {
            var total = dbContext.OrderProducts.Where(o => o.OrderID == orderId)
                .Select(c => c.ProductQuantity * c.Product.SellingPrice + c.ExtraQuantity * c.Extra.ExtraPrice)
                .Sum();

            return total;
        }*/

        public void PlaceOrder(CustomerOrder customerOrder)
        {
            /*Console.WriteLine(customerOrder);*/
            /*System.Diagnostics.Debug.WriteLine(customerOrder.ProductID[0]);*/
            Console.Write(customerOrder.ProductID);


            Order order = new Order();

            if (customerOrder != null)
            {
                Customer cust = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerOrder.CustomerID); /*Find Customer*/
                /*Extra ex = dbContext.Extras.FirstOrDefault(e => e.ExtraID == customerOrder.ExtraID);*/ /*Find Extra*/

                order.CustomerID = cust.CustomerID;
               

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();

                double totPrice = 0;

                foreach (var id in customerOrder.ProductID) /*Loop through array of product ID's*/
                {
                    OrderProduct ord = new OrderProduct();
                    Product prod = dbContext.Products.FirstOrDefault(p => p.ProductID == id); /*Find each product selected in checkboxes*/
                 
                    ord.OrderID = order.OrderID;
                    ord.ProductID = prod.ProductID;
                   /* ord.ExtraID = null;*/
                    ord.ProductQuantity = customerOrder.ProductQuantity;
                    /*ord.ExtraQuantity = null;*/
                    ord.Price = prod.SellingPrice * customerOrder.ProductQuantity;
                    totPrice += ord.Price;
                    dbContext.OrderProducts.Add(ord);
            
                    dbContext.SaveChanges();
                }

                /*order.TotalAmount = totPrice;*/

                /*Find the other, set the total amount and update order*/
                /*Order updateOrder = dbContext.Orders.Where(o => o.OrderID == order.OrderID).Include(OrderProducts);
                updateOrder.TotalAmount = totPrice;
                dbContext.Entry(updateOrder).State = EntityState.Modified;
                dbContext.SaveChanges();
*/

               /* var orderProductsTotalPrice = dbContext.OrderProducts.Where(o => o.OrderID == ord.OrderID).Select(o => o.Price).Sum();*/

                /* var orderProductsTotalPrice = dbContext.OrderProducts.Where(o => o.OrderID == order.OrderID).Select(o => o.Price).Sum();
                 order.TotalAmount = orderProductsTotalPrice;

                 dbContext.Orders.Add(order);
                 dbContext.SaveChanges();*/

                /*Find orderproducts with same orderID*/
                /*var orderProducts = dbContext.OrderProducts.Where(o => o.OrderID == order.OrderID);
                order.TotalAmount = orderProducts.AsEnumerable().Sum(o => o.Price);

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();*/

                /*Firstly find objects based on the selection on the form and create instances of it to be used for price calculations*/
                /* Customer cust = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerOrder.CustomerID);
                 Product prod = dbContext.Products.FirstOrDefault(p => p.ProductID == customerOrder.ProductID);
                 Extra ex = dbContext.Extras.FirstOrDefault(e => e.ExtraID == customerOrder.ExtraID);

                 Product prod2 = dbContext.Products.Find(customerOrder.ProductID);
                 *//*for(int i = 0; i < customerOrder.ProductID)*/

                /*List < Extra > ex = dbContext.Extras.Find().ExtraID;*/

                /*Create order*//*
                order.CustomerID = cust.CustomerID;
                order.TotalAmount = prod.SellingPrice * customerOrder.ProductQuantity + (ex.ExtraPrice * customerOrder.ExtraQuantity);

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();

                *//*Populate OrderProduct table with details of order*//*
                OrderProduct ord = new OrderProduct();
                ord.OrderID = order.OrderID;
                ord.ProductID = customerOrder.ProductID;
                ord.ExtraID = customerOrder.ExtraID;
                ord.ProductQuantity = customerOrder.ProductQuantity;
                ord.ExtraQuantity = customerOrder.ExtraQuantity;
                ord.Price = prod.SellingPrice * customerOrder.ProductQuantity + (ex.ExtraPrice * customerOrder.ExtraQuantity);
                dbContext.OrderProducts.Add(ord);
                dbContext.SaveChanges();
*/
            }
        }

        public void UpdateOrder(Order order)
        {
            
                dbContext.Entry(order).State = EntityState.Modified;
                try
                {
                    dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
           
        }
    }
}
