using ExoticCars.DAL;
using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
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
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        public bool CustomerExists(int orderId)
        {
            throw new NotImplementedException();
        }


        public void DeleteCustomer(Customer customer)
        {
            if (customer != null)
            {
                dbContext.Customers.Remove(customer);
                dbContext.SaveChanges();
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
            /*var entity = dbContext.Customers.Attach(customer);*/
            
            dbContext.Entry(customer).State = EntityState.Modified;
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
