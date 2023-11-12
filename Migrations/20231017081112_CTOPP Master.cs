using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class CTOPPMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTOPPMasters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: true),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: true),
                    AgeToYear = table.Column<int>(type: "int", nullable: true),
                    AgeToMonth = table.Column<int>(type: "int", nullable: true),
                    PercentageRankFrom = table.Column<int>(type: "int", nullable: true),
                    PercentageRankTo = table.Column<int>(type: "int", nullable: true),
                    ElisionFrom = table.Column<int>(type: "int", nullable: true),
                    ElisionTo = table.Column<int>(type: "int", nullable: true),
                    BlendingWordsFrom = table.Column<int>(type: "int", nullable: true),
                    BlendingWordsTo = table.Column<int>(type: "int", nullable: true),
                    PhonemeIsolationFrom = table.Column<int>(type: "int", nullable: true),
                    PhonemeIsolationTo = table.Column<int>(type: "int", nullable: true),
                    SoundMatchingFrom = table.Column<int>(type: "int", nullable: true),
                    SoundMatchingTo = table.Column<int>(type: "int", nullable: true),
                    MemoryForDigitsFrom = table.Column<int>(type: "int", nullable: true),
                    MemoryForDigitsTo = table.Column<int>(type: "int", nullable: true),
                    NonwordRepetitionFrom = table.Column<int>(type: "int", nullable: true),
                    NonwordRepetitionTo = table.Column<int>(type: "int", nullable: true),
                    RapidDigitNamingFrom = table.Column<int>(type: "int", nullable: true),
                    RapidDigitNamingTo = table.Column<int>(type: "int", nullable: true),
                    RapidLetterNamingFrom = table.Column<int>(type: "int", nullable: true),
                    RapidLetterNamingTo = table.Column<int>(type: "int", nullable: true),
                    RapidColorNamingFrom = table.Column<int>(type: "int", nullable: true),
                    RapidColorNamingTo = table.Column<int>(type: "int", nullable: true),
                    RapidObjectNamingFrom = table.Column<int>(type: "int", nullable: true),
                    RapidObjectNamingTo = table.Column<int>(type: "int", nullable: true),
                    BlendingNonwordsFrom = table.Column<int>(type: "int", nullable: true),
                    BlendingNonwordsTo = table.Column<int>(type: "int", nullable: true),
                    SegmentingNonwordsFrom = table.Column<int>(type: "int", nullable: true),
                    SegmentingNonwordsTo = table.Column<int>(type: "int", nullable: true),
                    ScaledScore = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTOPPMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTOPPMasters");
        }
    }
}
