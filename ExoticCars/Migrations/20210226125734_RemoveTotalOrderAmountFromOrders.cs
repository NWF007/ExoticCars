using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class RemoveTotalOrderAmountFromOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "TotalAmount",
                value: 960000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "TotalAmount",
                value: 545000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3,
                column: "TotalAmount",
                value: 270000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4,
                column: "TotalAmount",
                value: 157000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5,
                column: "TotalAmount",
                value: 754000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 6,
                column: "TotalAmount",
                value: 377000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 7,
                column: "TotalAmount",
                value: 377000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 8,
                column: "TotalAmount",
                value: 377000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 9,
                column: "TotalAmount",
                value: 377000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 10,
                column: "TotalAmount",
                value: 377000.0);
        }
    }
}
