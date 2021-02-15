using ExoticCars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.DAL
{
    public class ExoticCarContext : DbContext
    {
        /*public ExoticCarContext() : base("ExoticCarContext")
        {
            Database.SetInitializer<ExoticCarContext>(null);
        }*/
        public ExoticCarContext(DbContextOptions<ExoticCarContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Extra> Extras { get; set; }
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            // seed customers
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 1, FirstName = "Carson", LastName = "Alexander", Phone = "0825548974", Address = "41 Phylli Street, Mount Pleasant", City = "Port Elizabeth", PostalCode = "6010" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 2, FirstName = "Meredith", LastName = "Alonso", Phone = "0828948974", Address = "23 Meerhof Street, Chaleston Hill", City = "Paarl", PostalCode = "7646" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 3, FirstName = "Arturo", LastName = "Anand", Phone = "0835548974", Address = "89 School Street, New Orleans", City = "Paarl", PostalCode = "7623" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 4, FirstName = "Gytis", LastName = "Barzdukas", Phone = "0845548974", Address = "5 Blue Nountain Avenue, Calremont", City = "Cape Town", PostalCode = "8001" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 5, FirstName = "Yan", LastName = "Li", Phone = "0825548800", Address = "3rd Avenue, Boston", City = "Johannesburg", PostalCode = "7000" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 6, FirstName = "Peggy", LastName = "Justice", Phone = "0822348974", Address = "74 Macon Street, Lorraine", City = "Port Elizabeth", PostalCode = "6010" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 7, FirstName = "Laura", LastName = "Norman", Phone = "0815548974", Address = "54 Main Street, Klein Drakenstein", City = "East London", PostalCode = "3558" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 8, FirstName = "Nino", LastName = "Olivetto", Phone = "0824848974", Address = "354 Piccadilly Street, Seaview", City = "Durban", PostalCode = "4000" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 9, FirstName = "Elton", LastName = "Daries", Phone = "0825333974", Address = "48 Butcher Road, Sydenham", City = "Durban", PostalCode = "6010" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerID = 10, FirstName = "Brian", LastName = "Watson", Phone = "0825585274", Address = "454 Moon Street,Lake Virginia", City = "Prtoria", PostalCode = "8954" });

            // seed orders
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 1, CustomerID = 1, OrderDate = DateTime.Parse("2020-09-01"), Status = Order.status.OrderOnHold, Comments = "Order on hold for customer. Credit check in progress" });
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 2, CustomerID = 3, OrderDate = DateTime.Parse("2020-10-12"), Status = Order.status.OrderPlaced, Comments = "Customer wating for optional extra" });
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 3, CustomerID = 4, OrderDate = DateTime.Parse("2020-08-15"), Status = Order.status.OrderShipped, Comments = "Car shipped from manufaturer" });
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 4, CustomerID = 6, OrderDate = DateTime.Parse("2020-07-03"), Status = Order.status.OrderOnHold, Comments = "Order on hold for customer. Credit check in progress" });
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 5, CustomerID = 7, OrderDate = DateTime.Parse("2020-05-14"), Status = Order.status.OrderPlaced, Comments = "Car shipped from manufaturer" });
            modelBuilder.Entity<Order>().HasData(new Order { OrderID = 6, CustomerID = 9, OrderDate = DateTime.Parse("2020-03-17"), Status = Order.status.OrderPlaced, Comments = "Car shipped from manufaturer" });

            // seed products
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 1, Name = "Land Rover", Model = "Defender 90", SellingPrice = 15000000, CostPrice = 10000000, Year = "2018", EngineNo = "L22AM03790" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 2, Name = "Maserati", Model = "A6GCS/53", SellingPrice = 3500000, CostPrice = 25000000, Year = "2020", EngineNo = "M22AM08524" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 3, Name = "Cadillac", Model = "XT5", SellingPrice = 3000000, CostPrice = 27000000, Year = "2019", EngineNo = "C22AM03737" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 4, Name = "Jaguar", Model = "F-Type SVR", SellingPrice = 1000000, CostPrice = 9000000, Year = "2020", EngineNo = "J22AM07894" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 5, Name = "BMW", Model = "BMW E36 M3", SellingPrice = 2000000, CostPrice = 15000000, Year = "2020", EngineNo = "B22AM00247" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 6, Name = "Porsche", Model = "911 Carrera RS 3.0", SellingPrice = 3500000, CostPrice = 28000000, Year = "2020", EngineNo = "P22AM08761" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 7, Name = "Ferarri", Model = "812 GTS", SellingPrice = 3800000, CostPrice = 35000000, Year = "2020", EngineNo = "F22AM08520" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 8, Name = "Audi", Model = "Audi Q8", SellingPrice = 2000000, CostPrice = 15000000, Year = "2020", EngineNo = "A22AM07419" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 9, Name = "Alfa Romeo", Model = "Giulia Quadrifoglio", SellingPrice = 1500000, CostPrice = 12000000, Year = "2020", EngineNo = "AL2AM08719" });
            modelBuilder.Entity<Product>().HasData(new Product { ProductID = 10, Name = "Mercedez-Benz", Model = "AMG GT 63", SellingPrice = 2500000, CostPrice = 22000000, Year = "2020", EngineNo = "MB2AM07531" });

            // seed extras
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 1, ExtraName = "Sunroof", ExtraPrice = 5000 });
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 2, ExtraName = "Sport exhaust", ExtraPrice = 15000 });
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 3, ExtraName = "22 inch Wheels", ExtraPrice = 20000 });
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 4, ExtraName = "Matte Black paint", ExtraPrice = 7000 });
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 5, ExtraName = "Bang & Olufsen sound system", ExtraPrice = 12000 });
            modelBuilder.Entity<Extra>().HasData(new Extra { ExtraID = 6, ExtraName = "Carbon Ceramic Brakes", ExtraPrice = 22000 });

        }

    }
}
