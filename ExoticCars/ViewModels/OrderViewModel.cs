using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Extra> Extras { get; set; }
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Extra Extra { get; set; }

        public OrderProduct OrderProduct { get; set; }
    }
}
