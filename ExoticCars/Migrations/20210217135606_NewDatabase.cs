using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 25, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    ExtraID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExtraName = table.Column<string>(maxLength: 50, nullable: false),
                    ExtraPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.ExtraID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    SellingPrice = table.Column<int>(nullable: false),
                    CostPrice = table.Column<int>(nullable: false),
                    Year = table.Column<string>(maxLength: 50, nullable: false),
                    EngineNo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    ExtraID = table.Column<int>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ExtraQuantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.OrderProductID);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Extras_ExtraID",
                        column: x => x.ExtraID,
                        principalTable: "Extras",
                        principalColumn: "ExtraID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "FirstName", "LastName", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, "41 Phylli Street, Mount Pleasant", "Port Elizabeth", "Carson", "Alexander", "0825548974", "6010" },
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
                table: "Extras",
                columns: new[] { "ExtraID", "ExtraName", "ExtraPrice" },
                values: new object[,]
                {
                    { 6, "Carbon Ceramic Brakes", 22000 },
                    { 5, "Bang & Olufsen sound system", 12000 },
                    { 4, "Matte Black paint", 7000 },
                    { 3, "22 inch Wheels", 20000 },
                    { 2, "Sport exhaust", 15000 },
                    { 1, "Sunroof", 5000 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CostPrice", "EngineNo", "Model", "Name", "SellingPrice", "Year" },
                values: new object[,]
                {
                    { 1, 100000, "L22AM03790", "Defender 90", "Land Rover", 150000, "2018" },
                    { 2, 250000, "M22AM08524", "A6GCS/53", "Maserati", 350000, "2020" },
                    { 3, 270000, "C22AM03737", "XT5", "Cadillac", 300000, "2019" },
                    { 4, 90000, "J22AM07894", "F-Type SVR", "Jaguar", 100000, "2020" },
                    { 5, 150000, "B22AM00247", "BMW E36 M3", "BMW", 200000, "2020" },
                    { 6, 280000, "P22AM08761", "911 Carrera RS 3.0", "Porsche", 350000, "2020" },
                    { 7, 350000, "F22AM08520", "812 GTS", "Ferarri", 380000, "2020" },
                    { 8, 150000, "A22AM07419", "Audi Q8", "Audi", 200000, "2020" },
                    { 9, 120000, "AL2AM08719", "Giulia Quadrifoglio", "Alfa Romeo", 150000, "2020" },
                    { 10, 220000, "MB2AM07531", "AMG GT 63", "Mercedez-Benz", 250000, "2020" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Comments", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Order on hold for customer. Credit check in progress", 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 960000 },
                    { 2, "Customer wating for optional extra", 3, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 545000 },
                    { 3, "Car shipped from manufaturer", 4, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 270000 },
                    { 4, "Order on hold for customer. Credit check in progress", 6, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 157000 },
                    { 5, "Car shipped from manufaturer", 7, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 754000 },
                    { 6, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 377000 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductID", "ExtraID", "ExtraQuantity", "OrderID", "Price", "ProductID", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, 2, 1.0, 1, 165000.0, 1, 1 },
                    { 2, 2, 1.0, 1, 365000.0, 2, 1 },
                    { 3, 2, 1.0, 1, 315000.0, 3, 1 },
                    { 4, 2, 1.0, 1, 115000.0, 4, 1 },
                    { 5, 2, 1.0, 2, 165000.0, 1, 1 },
                    { 6, 2, 1.0, 2, 215000.0, 8, 1 },
                    { 7, 2, 1.0, 2, 165000.0, 9, 1 },
                    { 8, 3, 1.0, 3, 270000.0, 10, 1 },
                    { 9, 4, 1.0, 4, 157000.0, 1, 1 },
                    { 10, 5, 1.0, 5, 362000.0, 6, 1 },
                    { 11, 5, 1.0, 5, 392000.0, 7, 1 },
                    { 12, 6, 1.0, 6, 222000.0, 5, 1 },
                    { 13, 6, 1.0, 6, 155000.0, 8, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ExtraID",
                table: "OrderProducts",
                column: "ExtraID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderID",
                table: "OrderProducts",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductID",
                table: "OrderProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
