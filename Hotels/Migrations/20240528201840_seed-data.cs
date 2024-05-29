using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotels.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "0077248b-81ce-4eb7-b2bd-cf6e5bfea2b2", "Alexandria Address", "Alexandria" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "8e947e03-8b17-47d0-bba7-c164e0dcdcf7", "Hurgada Address", "Hurgada" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "f92647c6-bce4-484c-973a-804adf1e8c18", "NorthCoast Address", "NorthCoast" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "0077248b-81ce-4eb7-b2bd-cf6e5bfea2b2");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "8e947e03-8b17-47d0-bba7-c164e0dcdcf7");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "f92647c6-bce4-484c-973a-804adf1e8c18");
        }
    }
}
