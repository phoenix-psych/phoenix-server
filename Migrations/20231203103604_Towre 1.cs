using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class Towre1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TowreAgeEqui",
                table: "TowreAgeEqui");

            migrationBuilder.RenameTable(
                name: "TowreAgeEqui",
                newName: "TowreAgeEquis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TowreAgeEquis",
                table: "TowreAgeEquis",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TowreAgeEquis",
                table: "TowreAgeEquis");

            migrationBuilder.RenameTable(
                name: "TowreAgeEquis",
                newName: "TowreAgeEqui");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TowreAgeEqui",
                table: "TowreAgeEqui",
                column: "Id");
        }
    }
}
