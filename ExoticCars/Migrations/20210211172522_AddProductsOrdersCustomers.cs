using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class AddProductsOrdersCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "FirstName", "LastName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 2, "23 Meerhof Street, Chaleston Hill", "Paarl", "Meredith", "Alonso", "0828948974", "7646" },
                    { 3, "89 School Street, New Orleans", "Paarl", "Arturo", "Anand", "0835548974", "7623" },
                    { 4, "5 Blue Nountain Avenue, Calremont", "Cape Town", "Gytis", "Barzdukas", "0845548974", "8001" },
                    { 5, "3rd Avenue, Boston", "Johannesburg", "Yan", "Li", "0825548800", "7000" },
                    { 6, "74 Macon Street, Lorraine", "Port Elizabeth", "Peggy", "Justice", "0822348974", "6010" },
                    { 7, "54 Main Street, Klein Drakenstein", "East London", "Laura", "Norman", "0815548974", "3558" },
                    { 8, "354 Piccadilly Street, Seaview", "Durban", "Nino", "Olivetto", "0824848974", "4000" },
                    { 9, "48 Butcher Road, Sydenham", "Durban", "Elton", "Daries", "0825333974", "6010" },
                    { 10, "454 Moon Street,Lake Virginia", "Prtoria", "Brian", "Watson", "0825585274", "8954" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Comments", "CustomerID", "OrderDate", "Status" },
                values: new object[] { 1, "Order on hold for customer. Credit check in progress", 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "EngineNo", "Model", "Name", "OrderID", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "L22AM03790", "Defender 90", "Land Rover", null, 15000000, "2018" },
                    { 2, "M22AM08524", "A6GCS/53", "Maserati", null, 3500000, "2020" },
                    { 3, "C22AM03737", "XT5", "Cadillac", null, 3000000, "2019" },
                    { 4, "J22AM07894", "F-Type SVR", "Jaguar", null, 1000000, "2020" },
                    { 5, "B22AM00247", "BMW E36 M3", "BMW", null, 2000000, "2020" },
                    { 6, "P22AM08761", "911 Carrera RS 3.0", "Porsche", null, 3500000, "2020" },
                    { 7, "F22AM08520", "812 GTS", "Ferarri", null, 3800000, "2020" },
                    { 8, "A22AM07419", "Audi Q8", "Audi", null, 2000000, "2020" },
                    { 9, "AL2AM08719", "Giulia Quadrifoglio", "Alfa Romeo", null, 1500000, "2020" },
                    { 10, "MB2AM07531", "AMG GT 63", "Mercedez-Benz", null, 2500000, "2020" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Comments", "CustomerID", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 2, "Customer wating for optional extra", 3, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Car shipped from manufaturer", 4, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, "Order on hold for customer. Credit check in progress", 6, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Car shipped from manufaturer", 7, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9);
        }
    }
}
