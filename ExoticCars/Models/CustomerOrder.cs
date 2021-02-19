using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class CustomerOrder
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public Extra Extra { get; set; }
        public OrderProduct OrderProduct { get; set; }

    }
}
