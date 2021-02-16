using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class FixExtraConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 1,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 2, 165000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 2,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 2, 365000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 3,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 2, 315000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 4,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 2, 115000.0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "TotalAmount",
                value: 960000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 1,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 1, 155000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 2,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 1, 355000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 3,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 1, 305000.0 });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductID",
                keyValue: 4,
                columns: new[] { "ExtraID", "Price" },
                values: new object[] { 1, 105000.0 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "TotalAmount",
                value: 920000);
        }
    }
}
