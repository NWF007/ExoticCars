using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class CustomerOrder
    {
        public int OrderID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int ProductQuantity { get; set; }

        public int ExtraID { get; set; } 
        public double ExtraQuantity { get; set; }
        public double Price { get; set; } 
    }
}
