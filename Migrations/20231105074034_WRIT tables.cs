using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class WRITtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WRITGenerals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUM_OF_ALL_SUBTEST_STD_SCORE_FROM = table.Column<int>(type: "int", nullable: false),
                    SUM_OF_ALL_SUBTEST_STD_SCORE_TO = table.Column<int>(type: "int", nullable: false),
                    IQ_SCORES_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IQ_SCORE_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INETRVAL_90_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INETRVAL_90_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INETRVAL_95_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INETRVAL_95_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRITGenerals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRITSubtests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AGE_YEAR_FROM = table.Column<int>(type: "int", nullable: false),
                    AGE_MONTH_FROM = table.Column<int>(type: "int", nullable: false),
                    AGE_YEAR_TO = table.Column<int>(type: "int", nullable: false),
                    AGE_MONTH_TO = table.Column<int>(type: "int", nullable: false),
                    Raw_Scores = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Matrices_Standard_Scores = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Verbal_Analogies_Std_Scores = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Diamonds_Standard_scores = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Vocabulary_Standard_Scores = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRITSubtests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRITVerbals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUM_OF_VERBAL_STD_SCORES_FROM = table.Column<int>(type: "int", nullable: false),
                    SUM_OF_VERBAL_STD_SCORES_TO = table.Column<int>(type: "int", nullable: false),
                    IQ_SCORES_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IQ_SCORES_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PERCENTILES_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_90_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_90_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    INTERVALS_95_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    INTERVALS_95_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRITVerbals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WRITVisuals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SUM_OF_VISUAL_STD_SCORES_FROM = table.Column<int>(type: "int", nullable: false),
                    SUM_OF_VISUAL_STD_SCORES_TO = table.Column<int>(type: "int", nullable: false),
                    IQ_SCORES_FREOM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IQ_SCORES_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PERCENTILES_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INTERVALS90_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INTERVALS90_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INTERVAL_95_FROM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CONFIDENCE_INTERVAL_95_TO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WRITVisuals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WRITGenerals");

            migrationBuilder.DropTable(
                name: "WRITSubtests");

            migrationBuilder.DropTable(
                name: "WRITVerbals");

            migrationBuilder.DropTable(
                name: "WRITVisuals");
        }
    }
}
