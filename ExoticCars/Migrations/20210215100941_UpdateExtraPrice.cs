using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class UpdateExtraPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExtraPrice",
                table: "Extras",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 1,
                column: "ExtraPrice",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 2,
                column: "ExtraPrice",
                value: 15000);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 3,
                column: "ExtraPrice",
                value: 20000);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 4,
                column: "ExtraPrice",
                value: 7000);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 5,
                column: "ExtraPrice",
                value: 12000);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 6,
                column: "ExtraPrice",
                value: 22000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ExtraPrice",
                table: "Extras",
                type: "decimal(18,2)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 1,
                column: "ExtraPrice",
                value: 5000m);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 2,
                column: "ExtraPrice",
                value: 15000m);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 3,
                column: "ExtraPrice",
                value: 20000m);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 4,
                column: "ExtraPrice",
                value: 7000m);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 5,
                column: "ExtraPrice",
                value: 12000m);

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 6,
                column: "ExtraPrice",
                value: 22000m);
        }
    }
}
