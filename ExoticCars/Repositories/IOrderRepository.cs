using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders { get; }
        Order GetOrderById(int orderId);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        IEnumerable<Order> GetOrdersByStatus(string status);
        void PlaceOrder(CustomerOrder customerOrder);

        void AddExtras(ProductExtras productExtras);
        IEnumerable<OrderProduct> GetExtrasByCarOnOrder(int orderId, int productId);

        double GetOrderTotal(int orderId);
    }
}
