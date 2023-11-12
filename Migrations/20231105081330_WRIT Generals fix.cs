using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class WRITGeneralsfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PERCENTILES_FROM",
                table: "WRITGenerals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PERCENTILES_TO",
                table: "WRITGenerals",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PERCENTILES_FROM",
                table: "WRITGenerals");

            migrationBuilder.DropColumn(
                name: "PERCENTILES_TO",
                table: "WRITGenerals");
        }
    }
}
