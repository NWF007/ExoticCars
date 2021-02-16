using ExoticCars.DAL;
using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public class OrderProductRepository : IOrderProductRepository
    {
        private readonly ExoticCarContext dbContext;

        public OrderProductRepository(ExoticCarContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<OrderProduct> GetAllOrderProducts
        {
            get
            {
                return dbContext.OrderProducts;
            }
        }

        public List<OrderProduct> GetOrderProductDetails(int orderId)
        {
            List<OrderProduct> orderDetailList = dbContext.OrderProducts.Where(o => o.OrderID == orderId).Include(o => o.Extra).Include(o => o.Product)/*.Select(o => new OrderProduct {
               Price = o.Price
            })*/.ToList();

            return orderDetailList;
        }

        
    }
}
