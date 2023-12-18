using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class Ctoppdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientCTOPPDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElRawScore = table.Column<int>(type: "int", nullable: true),
                    ElScaleScore = table.Column<int>(type: "int", nullable: true),
                    ElPercentageRank = table.Column<int>(type: "int", nullable: true),
                    BwRawScore = table.Column<int>(type: "int", nullable: true),
                    BwScaleScore = table.Column<int>(type: "int", nullable: true),
                    BwPercentageRank = table.Column<int>(type: "int", nullable: true),
                    PlRawScore = table.Column<int>(type: "int", nullable: true),
                    PlScaleScore = table.Column<int>(type: "int", nullable: true),
                    PlPercentageRank = table.Column<int>(type: "int", nullable: true),
                    MdRawScore = table.Column<int>(type: "int", nullable: true),
                    MdScaleScore = table.Column<int>(type: "int", nullable: true),
                    MdPercentageRank = table.Column<int>(type: "int", nullable: true),
                    NrRawScore = table.Column<int>(type: "int", nullable: true),
                    NrScaleScore = table.Column<int>(type: "int", nullable: true),
                    NrPercentageRank = table.Column<int>(type: "int", nullable: true),
                    RdRawScore = table.Column<int>(type: "int", nullable: true),
                    RdScaleScore = table.Column<int>(type: "int", nullable: true),
                    RdPercentageRank = table.Column<int>(type: "int", nullable: true),
                    RlRawScore = table.Column<int>(type: "int", nullable: true),
                    RlScaleScore = table.Column<int>(type: "int", nullable: true),
                    RlPercentageRank = table.Column<int>(type: "int", nullable: true),
                    BnRawScore = table.Column<int>(type: "int", nullable: true),
                    BnScaleScore = table.Column<int>(type: "int", nullable: true),
                    BnPercentageRank = table.Column<int>(type: "int", nullable: true),
                    snRawScore = table.Column<int>(type: "int", nullable: true),
                    snScaleScore = table.Column<int>(type: "int", nullable: true),
                    snPercentageRank = table.Column<int>(type: "int", nullable: true),
                    selected = table.Column<int>(type: "int", nullable: true),
                    PaSum = table.Column<int>(type: "int", nullable: true),
                    PmSum = table.Column<int>(type: "int", nullable: true),
                    RsnSum = table.Column<int>(type: "int", nullable: true),
                    apaSum = table.Column<int>(type: "int", nullable: true),
                    PAScore = table.Column<int>(type: "int", nullable: true),
                    PACI = table.Column<int>(type: "int", nullable: true),
                    PADesc = table.Column<int>(type: "int", nullable: true),
                    PARank = table.Column<int>(type: "int", nullable: true),
                    PMScore = table.Column<int>(type: "int", nullable: true),
                    PMCI = table.Column<int>(type: "int", nullable: true),
                    PMDesc = table.Column<int>(type: "int", nullable: true),
                    PMRank = table.Column<int>(type: "int", nullable: true),
                    RSNScore = table.Column<int>(type: "int", nullable: true),
                    RSNCI = table.Column<int>(type: "int", nullable: true),
                    RSNDesc = table.Column<int>(type: "int", nullable: true),
                    RSNRank = table.Column<int>(type: "int", nullable: true),
                    APAScore = table.Column<int>(type: "int", nullable: true),
                    APACI = table.Column<int>(type: "int", nullable: true),
                    APADesc = table.Column<int>(type: "int", nullable: true),
                    APARank = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCTOPPDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCTOPPDetails");
        }
    }
}
