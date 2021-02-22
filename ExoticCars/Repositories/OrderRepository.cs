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
            System.Diagnostics.Debug.WriteLine(customerOrder.CustomerID);
            Order order = new Order();

            if (customerOrder != null)
            {
                /*Firstly find objects based on the selection on the form and create instances of it to be used for price calculations*/
                Customer cust = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerOrder.CustomerID);
                Product prod = dbContext.Products.FirstOrDefault(p => p.ProductID == customerOrder.ProductID);
                Extra ex = dbContext.Extras.FirstOrDefault(e => e.ExtraID == customerOrder.ExtraID);

                /*List < Extra > ex = dbContext.Extras.Find().ExtraID;*/

                /*Create order*/
                order.CustomerID = cust.CustomerID;
                order.TotalAmount = prod.SellingPrice * customerOrder.ProductQuantity + (ex.ExtraPrice * customerOrder.ExtraQuantity);

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();

                /*Populate OrderProduct table with details of order*/
                OrderProduct ord = new OrderProduct();
                ord.OrderID = order.OrderID;
                ord.ProductID = customerOrder.ProductID;
                ord.ExtraID = customerOrder.ExtraID;
                ord.ProductQuantity = customerOrder.ProductQuantity;
                ord.ExtraQuantity = customerOrder.ExtraQuantity;
                ord.Price = prod.SellingPrice * customerOrder.ProductQuantity + (ex.ExtraPrice * customerOrder.ExtraQuantity);
                dbContext.OrderProducts.Add(ord);
                dbContext.SaveChanges();

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
