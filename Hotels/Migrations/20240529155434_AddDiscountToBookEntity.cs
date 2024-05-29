using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotels.Migrations
{
    public partial class AddDiscountToBookEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "4113ae8b-cf47-4cad-8e1f-392ad439cb02");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "4c4e51d9-0d6e-4784-8a44-d1f56def57ee");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "f3be6dc0-acc5-4b22-b5bd-44042c62c8f7");

            migrationBuilder.AddColumn<int>(
                name: "discount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "9ccf64c0-2a17-46e6-9ac1-feed42000048", "Hurgada Address", "Hurgada" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "a2e5385b-1c9a-4e98-8198-f62096375960", "NorthCoast Address", "NorthCoast" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "b109b21e-2763-4b41-9d9b-9192fa1aebd1", "Alexandria Address", "Alexandria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "9ccf64c0-2a17-46e6-9ac1-feed42000048");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "a2e5385b-1c9a-4e98-8198-f62096375960");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "b109b21e-2763-4b41-9d9b-9192fa1aebd1");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "4113ae8b-cf47-4cad-8e1f-392ad439cb02", "Hurgada Address", "Hurgada" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "4c4e51d9-0d6e-4784-8a44-d1f56def57ee", "Alexandria Address", "Alexandria" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "f3be6dc0-acc5-4b22-b5bd-44042c62c8f7", "NorthCoast Address", "NorthCoast" });
        }
    }
}
