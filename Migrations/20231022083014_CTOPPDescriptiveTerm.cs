using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class CTOPPDescriptiveTerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTOPPDescriptiveTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScaledScoreTo = table.Column<int>(type: "int", nullable: true),
                    ScaledScoreFrom = table.Column<int>(type: "int", nullable: true),
                    DescriptiveTerm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompositeScoreTo = table.Column<int>(type: "int", nullable: true),
                    CompositeScoreFrom = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTOPPDescriptiveTerms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTOPPDescriptiveTerms");
        }
    }
}
