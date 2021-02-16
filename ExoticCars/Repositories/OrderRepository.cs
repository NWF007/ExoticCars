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

        public Order GetOrderById(int orderId)
        {
            return dbContext.Orders.FirstOrDefault(c => c.OrderID == orderId);
        }

        public void UpdateOrder(Order order)
        {
            if (order != null)
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
}
