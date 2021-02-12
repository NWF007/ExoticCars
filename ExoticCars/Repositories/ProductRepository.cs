using ExoticCars.DAL;
using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ExoticCarContext dbContext;

        public ProductRepository(ExoticCarContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Product> GetProducts
        {
            get
            {
                return dbContext.Products;
            }
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = GetProductId(productId);
            if (product != null)
            {
                dbContext.Products.Remove(product);
            }
        }

        public Product GetProductId(int productId)
        {
            return dbContext.Products.FirstOrDefault(c => c.ProductID == productId);
        }

        public bool ProductExists(int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            dbContext.Entry(product).State = EntityState.Modified;
            dbContext.SaveChanges();
            
        }
    }
}
