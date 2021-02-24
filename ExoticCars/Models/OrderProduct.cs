using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class OrderProduct
    {

        public int OrderProductID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int OrderID { get; set; }
        public int? ExtraID { get; set; } 
        [Required]
        public int ProductQuantity { get; set; }
        public double? ExtraQuantity { get; set; } 

        [Required]
        public double Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Extra Extra { get; set; }

    }
}
