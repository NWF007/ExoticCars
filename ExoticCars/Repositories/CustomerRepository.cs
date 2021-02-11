using ExoticCars.DAL;
using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly ExoticCarContext dbContext;

        public CustomerRepository(ExoticCarContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            dbContext.Add(customer);
        }

        public bool CustomerExists(int orderId)
        {
            throw new NotImplementedException();
        }


        public void DeleteCustomer(int customerId)
        {
            var customer = GetCustomerById(customerId);
            if (customer != null)
            {
                dbContext.Customers.Remove(customer);
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            return dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);
        }

        public IEnumerable<Customer> GetCustomers
        {
            get {
                return dbContext.Customers;
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
