using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class goartt5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GoartFormBAgeEqui",
                table: "GoartFormBAgeEqui");

            migrationBuilder.RenameTable(
                name: "GoartFormBAgeEqui",
                newName: "GoartFormBAgeEquis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoartFormBAgeEquis",
                table: "GoartFormBAgeEquis",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GoartFormBAgeEquis",
                table: "GoartFormBAgeEquis");

            migrationBuilder.RenameTable(
                name: "GoartFormBAgeEquis",
                newName: "GoartFormBAgeEqui");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoartFormBAgeEqui",
                table: "GoartFormBAgeEqui",
                column: "Id");
        }
    }
}
