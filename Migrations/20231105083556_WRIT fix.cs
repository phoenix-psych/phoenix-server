using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class WRITfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PERCENTILES_TO",
                table: "WRITVisuals",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PERCENTILES_FROM",
                table: "WRITVerbals",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PERCENTILES_TO",
                table: "WRITVisuals");

            migrationBuilder.DropColumn(
                name: "PERCENTILES_FROM",
                table: "WRITVerbals");
        }
    }
}
