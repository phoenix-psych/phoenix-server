using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class WRAT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WRAT_Blues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    year_from = table.Column<int>(type: "int", nullable: true),
                    month_from = table.Column<int>(type: "int", nullable: true),
                    year_to = table.Column<int>(type: "int", nullable: true),
                    month_to = table.Column<int>(type: "int", nullable: true),
                    Standard_score = table.Column<int>(type: "int", nullable: true),
                    Word_Reading_FROM = table.Column<int>(type: "int", nullable: true),
                    Word_Reading_TO = table.Column<int>(type: "int", nullable: true),
                    Spelling_FROM = table.Column<int>(type: "int", nullable: true),
                    SpellingTO = table.Column<int>(type: "int", nullable: true),
                    Math_Computation_FROM = table.Column<int>(type: "int", nullable: true),
                    Math_Computation_TO = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite_FROM = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite_TO = table.Column<int>(type: "int", nullable: true),
                    Sentence_Comprehension_FROM = table.Column<int>(type: "int", nullable: true),
                    Sentence_ComprehensionTO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRAT_Blues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRAT_CI_Blues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: true),
                    AgeToYear = table.Column<int>(type: "int", nullable: true),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: true),
                    AgeToMonth = table.Column<int>(type: "int", nullable: true),
                    Word_Reading = table.Column<int>(type: "int", nullable: true),
                    Spelling = table.Column<int>(type: "int", nullable: true),
                    Math_Computation = table.Column<int>(type: "int", nullable: true),
                    Sentence_Comprehension = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRAT_CI_Blues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRAT_CI_Greens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: true),
                    AgeToYear = table.Column<int>(type: "int", nullable: true),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: true),
                    AgeToMonth = table.Column<int>(type: "int", nullable: true),
                    Word_Reading = table.Column<int>(type: "int", nullable: true),
                    Spelling = table.Column<int>(type: "int", nullable: true),
                    Math_Computation = table.Column<int>(type: "int", nullable: true),
                    Sentence_Comprehension = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRAT_CI_Greens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRAT_Greens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    year_from = table.Column<int>(type: "int", nullable: true),
                    month_from = table.Column<int>(type: "int", nullable: true),
                    year_to = table.Column<int>(type: "int", nullable: true),
                    month_to = table.Column<int>(type: "int", nullable: true),
                    Standard_score = table.Column<int>(type: "int", nullable: true),
                    Word_Reading_FROM = table.Column<int>(type: "int", nullable: true),
                    Word_Reading_TO = table.Column<int>(type: "int", nullable: true),
                    Spelling_FROM = table.Column<int>(type: "int", nullable: true),
                    Spelling_TO = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite_FROM = table.Column<int>(type: "int", nullable: true),
                    Reading_Composite_TO = table.Column<int>(type: "int", nullable: true),
                    Math_Computation_FROM = table.Column<int>(type: "int", nullable: true),
                    Math_Computation_TO = table.Column<int>(type: "int", nullable: true),
                    Sentence_Comprehension_FROM = table.Column<int>(type: "int", nullable: true),
                    Sentence_Comprehension_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRAT_Greens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WRAT_Blues");

            migrationBuilder.DropTable(
                name: "WRAT_CI_Blues");

            migrationBuilder.DropTable(
                name: "WRAT_CI_Greens");

            migrationBuilder.DropTable(
                name: "WRAT_Greens");
        }
    }
}
