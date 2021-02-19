using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class SeedOrderData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "Comments", "CustomerID", "OrderDate", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 7, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 377000 },
                    { 8, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 377000 },
                    { 9, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 377000 },
                    { 10, "Car shipped from manufaturer", 9, new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 377000 }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductID", "ExtraID", "ExtraQuantity", "OrderID", "Price", "ProductID", "ProductQuantity" },
                values: new object[,]
                {
                    { 14, 6, 1.0, 7, 222000.0, 5, 1 },
                    { 15, 6, 1.0, 7, 155000.0, 8, 1 },
                    { 16, 6, 1.0, 8, 222000.0, 5, 1 },
                    { 17, 6, 1.0, 8, 155000.0, 8, 1 },
                    { 18, 6, 1.0, 9, 222000.0, 5, 1 },
                    { 19, 6, 1.0, 9, 155000.0, 8, 1 },
                    { 20, 6, 1.0, 10, 222000.0, 5, 1 },
                    { 21, 6, 1.0, 10, 155000.0, 8, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 10);
        }
    }
}
