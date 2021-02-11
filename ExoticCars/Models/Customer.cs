using System.Collections.Generic;

namespace ExoticCars.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}