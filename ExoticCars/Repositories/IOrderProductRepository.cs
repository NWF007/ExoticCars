using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public interface IOrderProductRepository
    {
        IEnumerable<OrderProduct> GetAllOrderProducts { get; }
        List<OrderProduct> GetOrderProductDetails(int orderId);

    }
}
