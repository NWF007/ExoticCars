using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class UpdateOrderProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptionalExtra",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "OrderProductID",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ExtraQuantity",
                table: "OrderProducts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "OrderProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderProductID",
                table: "Extras",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderProductID",
                table: "Products",
                column: "OrderProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_OrderProductID",
                table: "Extras",
                column: "OrderProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_OrderProducts_OrderProductID",
                table: "Extras",
                column: "OrderProductID",
                principalTable: "OrderProducts",
                principalColumn: "OrderProductID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderProducts_OrderProductID",
                table: "Products",
                column: "OrderProductID",
                principalTable: "OrderProducts",
                principalColumn: "OrderProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_OrderProducts_OrderProductID",
                table: "Extras");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderProducts_OrderProductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderProductID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Extras_OrderProductID",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "OrderProductID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ExtraQuantity",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "OrderProductID",
                table: "Extras");

            migrationBuilder.AddColumn<double>(
                name: "OptionalExtra",
                table: "OrderProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
