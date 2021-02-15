using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class SeedExtrasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "ExtraID", "ExtraName", "ExtraPrice" },
                values: new object[,]
                {
                    { 1, "Sunroof", 5000m },
                    { 2, "Sport exhaust", 15000m },
                    { 3, "22 inch Wheels", 20000m },
                    { 4, "Matte Black paint", 7000m },
                    { 5, "Bang & Olufsen sound system", 12000m },
                    { 6, "Carbon Ceramic Brakes", 22000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "ExtraID",
                keyValue: 6);
        }
    }
}
