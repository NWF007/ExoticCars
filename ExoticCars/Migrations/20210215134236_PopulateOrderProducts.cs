using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class PopulateOrderProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalAmount",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductID", "ExtraID", "ExtraQuantity", "OrderID", "Price", "ProductID", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1.0, 1, 155000.0, 1, 1 },
                    { 13, 6, 1.0, 6, 155000.0, 8, 1 },
                    { 12, 6, 1.0, 6, 222000.0, 5, 1 },
                    { 11, 5, 1.0, 5, 392000.0, 7, 1 },
                    { 10, 5, 1.0, 5, 362000.0, 6, 1 },
                    { 8, 3, 1.0, 3, 270000.0, 10, 1 },
                    { 9, 4, 1.0, 4, 157000.0, 1, 1 },
                    { 6, 2, 1.0, 2, 215000.0, 8, 1 },
                    { 5, 2, 1.0, 2, 165000.0, 1, 1 },
                    { 4, 1, 1.0, 1, 105000.0, 4, 1 },
                    { 3, 1, 1.0, 1, 305000.0, 3, 1 },
                    { 2, 1, 1.0, 1, 355000.0, 2, 1 },
                    { 7, 2, 1.0, 2, 165000.0, 9, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "TotalAmount",
                value: 920000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "TotalAmount",
                value: 545000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "TotalAmount",
                value: 270000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "TotalAmount",
                value: 157000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "TotalAmount",
                value: 754000);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 6,
                column: "TotalAmount",
                value: 377000);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 100000, 150000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 250000, 350000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 270000, 300000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 90000, 100000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 150000, 200000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 280000, 350000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 350000, 380000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 150000, 200000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 120000, 150000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 220000, 250000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 10000000, 15000000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 25000000, 3500000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 27000000, 3000000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 9000000, 1000000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 15000000, 2000000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 28000000, 3500000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 35000000, 3800000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 15000000, 2000000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 12000000, 1500000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CostPrice", "SellingPrice" },
                values: new object[] { 22000000, 2500000 });
        }
    }
}
