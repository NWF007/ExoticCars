using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Models
{
    public class Order
    {
        public enum status
        {
            OrderPlaced = 1,
            OrderOnHold = 2,
            OrderCancelled = 3,
            OrderShipped = 4
        }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime OrderDate { get; set; }
        public status Status { get; set; }
        public string Comments { get; set; }
        /*public double TotalAmount { get
            {
                return OrderProducts.Sum(x => x.Price);
            }
        }*/

        public int TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
            = new List<OrderProduct>();
    }
}
