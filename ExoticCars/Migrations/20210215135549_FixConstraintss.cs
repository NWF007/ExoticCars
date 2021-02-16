using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class FixConstraintss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "OrderProductID",
                table: "Extras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderProductID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderProductID",
                table: "Extras",
                type: "int",
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
    }
}
