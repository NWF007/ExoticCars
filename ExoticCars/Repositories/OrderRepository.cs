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

        public void AddExtras(ProductExtras productExtras)
        {
            if(productExtras != null)
            {
                var order = dbContext.Orders.FirstOrDefault(o => o.OrderID == productExtras.OrderID);
                var product = dbContext.Products.FirstOrDefault(p => p.ProductID == productExtras.ProductID);

                foreach(var prod in productExtras.ExtraID)
                {
                    OrderProduct ordProd = new OrderProduct();
                    Extra ex = dbContext.Extras.FirstOrDefault(e => e.ExtraID == prod);

                    ordProd.ProductID = product.ProductID;
                    ordProd.OrderID = order.OrderID;
                    ordProd.ProductQuantity = 1;
                    ordProd.ExtraID = ex.ExtraID;
                    ordProd.ExtraQuantity = 1;
                    ordProd.Price = (double)(ex.ExtraPrice * ordProd.ExtraQuantity);

                    dbContext.OrderProducts.Add(ordProd);
                    dbContext.SaveChanges();
                }
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

        public IEnumerable<OrderProduct> GetExtrasByCarOnOrder(int orderId, int productId)
        {
            IEnumerable<OrderProduct> extras = dbContext.OrderProducts.Where(o => o.OrderID == orderId).Where(o => o.ProductID == productId).Include(o => o.Extra).ToList();

            return extras;
        }

        public Order GetOrderById(int orderId)
        {
            return dbContext.Orders.FirstOrDefault(c => c.OrderID == orderId);
        }

        public IEnumerable<Order> GetOrdersByCustomerId(int? customerId)
        {
            IEnumerable<Order> orders = dbContext.Orders.Where(o => o.CustomerID == customerId).ToList();

            return orders;
        }

        public IEnumerable<Order> GetOrdersByStatus(string status)
        {
            return dbContext.Orders.Where(c => c.Status.Equals(status));
        }

        public double GetOrderTotal(int orderId)
        {
            double sum = dbContext.OrderProducts.Where(o => o.OrderID == orderId).Select(o => o.Price).Sum();

            return sum;
        }

        public void PlaceOrder(CustomerOrder customerOrder)
        {
            Console.Write(customerOrder.ProductID);

            Order order = new Order();

            if (customerOrder != null)
            {
                Customer cust = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerOrder.CustomerID); /*Find Customer*/
               
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
                    ord.ProductQuantity = customerOrder.ProductQuantity;
                    ord.Price = prod.SellingPrice * customerOrder.ProductQuantity;
                    totPrice += ord.Price;
                    dbContext.OrderProducts.Add(ord);
            
                    dbContext.SaveChanges();
                }
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
