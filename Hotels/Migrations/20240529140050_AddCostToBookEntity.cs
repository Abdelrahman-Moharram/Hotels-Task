using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotels.Migrations
{
    public partial class AddCostToBookEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "10e837dc-5b36-4a47-a619-8efaecfdfa93");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "aeeb13ec-b419-4456-a567-9f40d8f75eea");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: "be97414e-b8a2-4a47-93db-e4cbb779ab3c");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Books",
                type: "money",
                nullable: false,
                defaultValue: 0m);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "10e837dc-5b36-4a47-a619-8efaecfdfa93", "NorthCoast Address", "NorthCoast" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "aeeb13ec-b419-4456-a567-9f40d8f75eea", "Hurgada Address", "Hurgada" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { "be97414e-b8a2-4a47-93db-e4cbb779ab3c", "Alexandria Address", "Alexandria" });
        }
    }
}
