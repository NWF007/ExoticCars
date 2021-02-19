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
        /*[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]*/
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public status Status { get; set; } = status.OrderPlaced;
        public string Comments { get; set; } = "Order was placed successfully";
        /*public double TotalAmount { get
            {
                return OrderProducts.Sum(x => x.Price);
            }
        }*/

        public int TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
            = new List<OrderProduct>();

        public virtual List<string> Statuses()
        {
            string[] names = Enum.GetNames(typeof(status));
            return names.ToList();
        }
    }
}
