using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class OrderProduct
    {
        public int OrderProductID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int ExtraID { get; set; }
        public int ProductQuantity { get; set; }
        public double ExtraQuantity { get; set; }
        public double Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Extra Extra { get; set; }
    }
}
