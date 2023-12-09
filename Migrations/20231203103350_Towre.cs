using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class Towre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TowreAgeEqui",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age_equivalent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sight_Word_Efficiency_raw_score_FROM = table.Column<int>(type: "int", nullable: true),
                    Sight_Word_Efficiency_raw_score_TO = table.Column<int>(type: "int", nullable: true),
                    Phonemic_Decoding_Efficiency_raw_score_FROM = table.Column<int>(type: "int", nullable: true),
                    Phonemic_Decoding_Efficiency_raw_score_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowreAgeEqui", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowreGradeEquis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sight_Word_Efficiency_raw_score_FROM = table.Column<int>(type: "int", nullable: true),
                    Sight_Word_Efficiency_raw_score_TO = table.Column<int>(type: "int", nullable: true),
                    Phonemic_Decoding_Efficiency_raw_score_FROM = table.Column<int>(type: "int", nullable: true),
                    Phonemic_Decoding_Efficiency_raw_score_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowreGradeEquis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowrePdes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: true),
                    AgeToYear = table.Column<int>(type: "int", nullable: true),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: true),
                    AgeToMonth = table.Column<int>(type: "int", nullable: true),
                    Raw_score = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowrePdes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowreRanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: true),
                    Percentile_rank_FROM = table.Column<int>(type: "int", nullable: true),
                    Percentile_rank_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowreRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowreSwes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: true),
                    AgeToYear = table.Column<int>(type: "int", nullable: true),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: true),
                    AgeToMonth = table.Column<int>(type: "int", nullable: true),
                    Raw_score = table.Column<int>(type: "int", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowreSwes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TowreWRs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: true),
                    Sum_of_SWE_PDE_FROM = table.Column<int>(type: "int", nullable: true),
                    Sum_of_SWE_PDE_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TowreWRs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TowreAgeEqui");

            migrationBuilder.DropTable(
                name: "TowreGradeEquis");

            migrationBuilder.DropTable(
                name: "TowrePdes");

            migrationBuilder.DropTable(
                name: "TowreRanks");

            migrationBuilder.DropTable(
                name: "TowreSwes");

            migrationBuilder.DropTable(
                name: "TowreWRs");
        }
    }
}
