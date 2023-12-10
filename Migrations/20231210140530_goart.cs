using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class goart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoartFormAAccuracys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    year_from = table.Column<int>(type: "int", nullable: true),
                    month_from = table.Column<int>(type: "int", nullable: true),
                    year_to = table.Column<int>(type: "int", nullable: true),
                    month_to = table.Column<int>(type: "int", nullable: true),
                    ile_Rank = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    Accuracy_from = table.Column<int>(type: "int", nullable: true),
                    Accuracy_to = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormAAccuracys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormAAgeEquis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age_equiv = table.Column<int>(type: "int", nullable: true),
                    Rate_FROM = table.Column<int>(type: "int", nullable: true),
                    Rate_TO = table.Column<int>(type: "int", nullable: true),
                    Accuracy_FROM = table.Column<int>(type: "int", nullable: true),
                    Accuracy_TO = table.Column<int>(type: "int", nullable: true),
                    Fluency_FROM = table.Column<int>(type: "int", nullable: true),
                    Comprehension_FROM = table.Column<int>(type: "int", nullable: true),
                    Comprehension_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormAAgeEquis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormAComprehensions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age_year_from = table.Column<int>(type: "int", nullable: true),
                    Age_month_from = table.Column<int>(type: "int", nullable: true),
                    Age_year_to = table.Column<int>(type: "int", nullable: true),
                    Age_month_to = table.Column<int>(type: "int", nullable: true),
                    PercentileRank = table.Column<int>(type: "int", nullable: true),
                    Comprehension_from = table.Column<int>(type: "int", nullable: true),
                    Comprehension_to = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormAComprehensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormAFluencys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: true),
                    age_month_from = table.Column<int>(type: "int", nullable: true),
                    age_year_to = table.Column<int>(type: "int", nullable: true),
                    age_month_to = table.Column<int>(type: "int", nullable: true),
                    ile_Rank = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    Fluency_from = table.Column<int>(type: "int", nullable: true),
                    Fluency_to = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormAFluencys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormAGradeEquis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade_equiv = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Rate_FROM = table.Column<int>(type: "int", nullable: true),
                    Rate_TO = table.Column<int>(type: "int", nullable: true),
                    Accuracy_FROM = table.Column<int>(type: "int", nullable: true),
                    Accuracy_TO = table.Column<int>(type: "int", nullable: true),
                    Fluency_FROM = table.Column<int>(type: "int", nullable: true),
                    Fluency_TO = table.Column<int>(type: "int", nullable: true),
                    Comprehension_FROM = table.Column<int>(type: "int", nullable: true),
                    Comprehension_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormAGradeEquis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormARates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: true),
                    age_month_from = table.Column<int>(type: "int", nullable: true),
                    age_year_to = table.Column<int>(type: "int", nullable: true),
                    age_month_to = table.Column<int>(type: "int", nullable: true),
                    percentile_Rank = table.Column<int>(type: "int", nullable: true),
                    Rate_from = table.Column<int>(type: "int", nullable: true),
                    Rate_to = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormARates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBAccuracys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: true),
                    age_month_from = table.Column<int>(type: "int", nullable: true),
                    age_year_to = table.Column<int>(type: "int", nullable: true),
                    age_month_to = table.Column<int>(type: "int", nullable: true),
                    percentile_Rank = table.Column<int>(type: "int", nullable: true),
                    Accuracy_from = table.Column<int>(type: "int", nullable: true),
                    Accuracy_to = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBAccuracys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBAgeEqui",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age_equiv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate_FROM = table.Column<int>(type: "int", nullable: false),
                    Rate_TO = table.Column<int>(type: "int", nullable: false),
                    Accuracy_FROM = table.Column<int>(type: "int", nullable: false),
                    Accuracy_TO = table.Column<int>(type: "int", nullable: false),
                    Fluency_FROM = table.Column<int>(type: "int", nullable: false),
                    Fluency_TO = table.Column<int>(type: "int", nullable: false),
                    Comprehension_FROM = table.Column<int>(type: "int", nullable: false),
                    Comprehension_TO = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBAgeEqui", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBComprehensions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: true),
                    age_month_from = table.Column<int>(type: "int", nullable: true),
                    age_year_to = table.Column<int>(type: "int", nullable: true),
                    age_month_to = table.Column<int>(type: "int", nullable: true),
                    percentile_Rank = table.Column<int>(type: "int", nullable: true),
                    Comprehension_from = table.Column<int>(type: "int", nullable: true),
                    Comprehension_to = table.Column<int>(type: "int", nullable: true),
                    scaled_score = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBComprehensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBFluencys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: false),
                    age_month_from = table.Column<int>(type: "int", nullable: false),
                    age_year_to = table.Column<int>(type: "int", nullable: false),
                    age_month_to = table.Column<int>(type: "int", nullable: false),
                    ile_Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fluency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fluency_from = table.Column<int>(type: "int", nullable: false),
                    Fluency_to = table.Column<int>(type: "int", nullable: false),
                    scaled_score = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBFluencys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBGradeEquis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade_Equiv = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Rate_FROM = table.Column<int>(type: "int", nullable: true),
                    Rate_TO = table.Column<int>(type: "int", nullable: true),
                    Accuracy_FROM = table.Column<int>(type: "int", nullable: true),
                    Accuracy_TO = table.Column<int>(type: "int", nullable: true),
                    Fluency_FROM = table.Column<int>(type: "int", nullable: true),
                    Fluency_TO = table.Column<int>(type: "int", nullable: true),
                    Comprehension_FROM = table.Column<int>(type: "int", nullable: true),
                    Comprehension_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBGradeEquis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartFormBRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    age_year_from = table.Column<int>(type: "int", nullable: false),
                    age_month_from = table.Column<int>(type: "int", nullable: false),
                    age_year_to = table.Column<int>(type: "int", nullable: false),
                    age_month_to = table.Column<int>(type: "int", nullable: false),
                    percentile_Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scaled_score = table.Column<int>(type: "int", nullable: false),
                    rate_from = table.Column<int>(type: "int", nullable: false),
                    rate_to = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartFormBRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoartRanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percentile_rank = table.Column<int>(type: "int", nullable: true),
                    Sum_of_scaled_scores_Fluency_Comprehension = table.Column<int>(type: "int", nullable: true),
                    Oral_Reading_Index = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoartRanks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoartFormAAccuracys");

            migrationBuilder.DropTable(
                name: "GoartFormAAgeEquis");

            migrationBuilder.DropTable(
                name: "GoartFormAComprehensions");

            migrationBuilder.DropTable(
                name: "GoartFormAFluencys");

            migrationBuilder.DropTable(
                name: "GoartFormAGradeEquis");

            migrationBuilder.DropTable(
                name: "GoartFormARates");

            migrationBuilder.DropTable(
                name: "GoartFormBAccuracys");

            migrationBuilder.DropTable(
                name: "GoartFormBAgeEqui");

            migrationBuilder.DropTable(
                name: "GoartFormBComprehensions");

            migrationBuilder.DropTable(
                name: "GoartFormBFluencys");

            migrationBuilder.DropTable(
                name: "GoartFormBGradeEquis");

            migrationBuilder.DropTable(
                name: "GoartFormBRates");

            migrationBuilder.DropTable(
                name: "GoartRanks");
        }
    }
}
