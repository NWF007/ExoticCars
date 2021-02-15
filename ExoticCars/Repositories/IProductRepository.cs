using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductId(int productId);
        void DeleteProduct(Product product);
        bool ProductExists(int productId);
        IEnumerable<Product> GetProducts { get; }
    }
}
