﻿using ExoticCars.DAL;
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

        public void DeleteProduct(Product product)
        {
            
            if (product != null)
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
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
            if(product != null)
            {
                dbContext.Entry(product).State = EntityState.Modified;
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
}
