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

        public double GetOrderTotal(int orderId)
        {
            var total = dbContext.OrderProducts.Where(o => o.OrderID == orderId)
                .Select(c => c.ProductQuantity * c.Product.SellingPrice + c.ExtraQuantity * c.Extra.ExtraPrice)
                .Sum();

            return total;
        }

        public void UpdateOrder(int orderId)
        {
            var order = dbContext.Orders.FirstOrDefault(o => o.OrderID == orderId);
            
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
