using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int orderId);
        void DeleteCustomer(int customerId);
        bool CustomerExists(int orderId);
        IEnumerable<Customer> GetCustomers { get; }
    }
}
