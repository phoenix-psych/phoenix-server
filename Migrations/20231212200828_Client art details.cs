using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class Clientartdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientARTDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Second1 = table.Column<int>(type: "int", nullable: true),
                    Second2 = table.Column<int>(type: "int", nullable: true),
                    Second3 = table.Column<int>(type: "int", nullable: true),
                    Second4 = table.Column<int>(type: "int", nullable: true),
                    Second5 = table.Column<int>(type: "int", nullable: true),
                    Second6 = table.Column<int>(type: "int", nullable: true),
                    Second7 = table.Column<int>(type: "int", nullable: true),
                    Second8 = table.Column<int>(type: "int", nullable: true),
                    PrErr1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrAcc1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrCom1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrErr2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrAcc2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrCom2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrErr3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrAcc3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrCom3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrErr4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrAcc4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrCom4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrComp5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrComp6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrComp7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrComp8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrSpd8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmAccuracy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreAloud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedAloud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreSilent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedSilent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmWritingSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmAccuracyCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmAccuracyStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreAloudCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreAloudStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedAloudCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedAloudStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreSilentCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmCompreSilentStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedSilentCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmSpeedSilentStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmWritingSpeedCentile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmWritingSpeedStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientARTDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientARTDetails");
        }
    }
}
