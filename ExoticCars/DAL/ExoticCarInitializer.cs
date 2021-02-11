/*using ExoticCars.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ExoticCars.DAL
{
    public class ExoticCarInitializer : DropCreateDatabaseIfModelChanges<ExoticCarContext>
    {
        protected override void Seed(ExoticCarContext _context)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName="Carson",LastName="Alexander",Phone="0825548974",Address="41 Phylli Street, Mount Pleasant",City="Port Elizabeth",PostalCode="6010" },
                new Customer{FirstName="Meredith",LastName="Alonso",Phone="0828948974",Address="23 Meerhof Street, Chaleston Hill",City="Paarl",PostalCode="7646" },
                new Customer{FirstName="Arturo",LastName="Anand",Phone="0835548974",Address="89 School Street, New Orleans",City="Paarl",PostalCode="7623" },
                new Customer{FirstName="Gytis",LastName="Barzdukas",Phone="0845548974",Address="5 Blue Nountain Avenue, Calremont",City="Cape Town",PostalCode="8001" },
                new Customer{FirstName="Yan",LastName="Li",Phone="0825548800",Address="3rd Avenue, Boston",City="Johannesburg",PostalCode="7000" },
                new Customer{FirstName="Peggy",LastName="Justice",Phone="0822348974",Address="74 Macon Street, Lorraine",City="Port Elizabeth",PostalCode="6010" },
                new Customer{FirstName="Laura",LastName="Norman",Phone="0815548974",Address="54 Main Street, Klein Drakenstein",City="East London",PostalCode="3558" },
                new Customer{FirstName="Nino",LastName="Olivetto",Phone="0824848974",Address="354 Piccadilly Street, Seaview",City="Durban",PostalCode="4000" },
                new Customer{FirstName="Elton",LastName="Daries",Phone="0825333974",Address="48 Butcher Road, Sydenham",City="Durban",PostalCode="6010" },
                new Customer{FirstName="Brian",LastName="Watson",Phone="0825585274",Address="454 Moon Street,Lake Virginia",City="Prtoria",PostalCode="8954" },
        };
            customers.ForEach(c => _context.Customers.Add(c));
            _context.SaveChanges();
            var orders = new List<Order>
            {
                new Order{CustomerID =1,OrderDate =DateTime.Parse("2020-09-01"),Status=Order.status.OrderOnHold,Comments="Order on hold for customer. Credit check in progress"},
                new Order{CustomerID =3,OrderDate =DateTime.Parse("2020-10-12"),Status=Order.status.OrderPlaced,Comments="Customer wating for optional extra"},
                new Order{CustomerID =4,OrderDate =DateTime.Parse("2020-08-15"),Status=Order.status.OrderShipped,Comments="Car shipped from manufaturer"},
                new Order{CustomerID =6,OrderDate =DateTime.Parse("2020-07-03"),Status=Order.status.OrderOnHold,Comments="Order on hold for customer. Credit check in progress"},
                new Order{CustomerID =7,OrderDate =DateTime.Parse("2020-05-14"),Status=Order.status.OrderPlaced,Comments="Car shipped from manufaturer"},
                new Order{CustomerID =9,OrderDate =DateTime.Parse("2020-03-17"),Status=Order.status.OrderPlaced,Comments="Car shipped from manufaturer"},
            };
            orders.ForEach(o => _context.Orders.Add(o));
            _context.SaveChanges();
            var products = new List<Product>
            {
                new Product{Name="Land Rover",Model="Defender 90",Price=15000000,Year="2018",EngineNo="L22AM03790"},
                new Product{Name="Maserati",Model="A6GCS/53",Price=3500000,Year="2020",EngineNo="M22AM08524"},
                new Product{Name="Cadillac",Model="XT5",Price=3000000,Year="2019",EngineNo="C22AM03737"},
                new Product{Name="Jaguar",Model="F-Type SVR",Price=1000000,Year="2020",EngineNo="J22AM07894"},
                new Product{Name="BMW",Model="BMW E36 M3",Price=2000000,Year="2020",EngineNo="B22AM00247"},
                new Product{Name="Porsche",Model="911 Carrera RS 3.0",Price=3500000,Year="2020",EngineNo="P22AM08761"},
                new Product{Name="Ferarri",Model="812 GTS",Price=3800000,Year="2020",EngineNo="F22AM08520"},
                new Product{Name="Audi",Model="Audi Q8",Price=2000000,Year="2020",EngineNo="A22AM07419"},
                new Product{Name="Alfa Romeo",Model="Giulia Quadrifoglio",Price=1500000,Year="2020",EngineNo="AL2AM08719"},
                new Product{Name="Mercedez-Benz",Model="AMG GT 63",Price=2500000,Year="2020",EngineNo="MB2AM07531"},
            };
            products.ForEach(p => _context.Products.Add(p));
            _context.SaveChanges();
        } 
    }
}
*/