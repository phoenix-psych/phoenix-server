using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class clientfix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Service",
                table: "Clients",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service",
                table: "Clients");
        }
    }
}
