using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class UpdateOrderProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Extras_ExtraID",
                table: "OrderProducts");

            migrationBuilder.AlterColumn<double>(
                name: "ExtraQuantity",
                table: "OrderProducts",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ExtraID",
                table: "OrderProducts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Extras_ExtraID",
                table: "OrderProducts",
                column: "ExtraID",
                principalTable: "Extras",
                principalColumn: "ExtraID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Extras_ExtraID",
                table: "OrderProducts");

            migrationBuilder.AlterColumn<double>(
                name: "ExtraQuantity",
                table: "OrderProducts",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExtraID",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Extras_ExtraID",
                table: "OrderProducts",
                column: "ExtraID",
                principalTable: "Extras",
                principalColumn: "ExtraID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
