using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotels.Migrations
{
    public partial class MakeAddressNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "13334801-b84c-44d1-bef4-4d4ab768e50f", "Alexandria Address", "Alexandria" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "181067b1-530d-4b7c-b473-b33d21825b60", "NorthCoast Address", "NorthCoast" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "20390f56-50e3-47b9-9d38-53bcfaba5fa0", "Hurgada Address", "Hurgada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "13334801-b84c-44d1-bef4-4d4ab768e50f");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "181067b1-530d-4b7c-b473-b33d21825b60");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "20390f56-50e3-47b9-9d38-53bcfaba5fa0");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
