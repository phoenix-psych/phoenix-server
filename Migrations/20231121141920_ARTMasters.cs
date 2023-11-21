using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class ARTMasters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ARTMasters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Centile = table.Column<int>(type: "int", nullable: true),
                    Standard_score_equivalent = table.Column<int>(type: "int", nullable: true),
                    Aloud_reading_accuracy = table.Column<int>(type: "int", nullable: true),
                    Aloud_reading_comprehension = table.Column<int>(type: "int", nullable: true),
                    Aloud_reading_rate = table.Column<int>(type: "int", nullable: true),
                    Silent_reading_comprehension = table.Column<int>(type: "int", nullable: true),
                    Silent_reading_rate = table.Column<int>(type: "int", nullable: true),
                    Writing_speed = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARTMasters");
        }
    }
}
