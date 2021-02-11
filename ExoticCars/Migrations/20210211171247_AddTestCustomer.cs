using Microsoft.EntityFrameworkCore.Migrations;

namespace ExoticCars.Migrations
{
    public partial class AddTestCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "FirstName", "LastName", "Phone", "PostalCode" },
                values: new object[] { 1, "41 Phylli Street, Mount Pleasant", "Port Elizabeth", "Carson", "Alexander", "0825548974", "6010" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);
        }
    }
}
