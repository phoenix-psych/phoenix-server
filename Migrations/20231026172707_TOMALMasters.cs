using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class TOMALMasters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TOMALMasters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeFromYear = table.Column<int>(type: "int", nullable: false),
                    AgeFromMonth = table.Column<int>(type: "int", nullable: false),
                    AgeToYear = table.Column<int>(type: "int", nullable: false),
                    AgeToMonth = table.Column<int>(type: "int", nullable: false),
                    Scaled_Score = table.Column<int>(type: "int", nullable: true),
                    MFS_FROM = table.Column<int>(type: "int", nullable: true),
                    FM_FROM = table.Column<int>(type: "int", nullable: true),
                    FM_TO = table.Column<int>(type: "int", nullable: true),
                    WSR_FROM = table.Column<int>(type: "int", nullable: true),
                    WSR_TO = table.Column<int>(type: "int", nullable: true),
                    AVM_FROM = table.Column<int>(type: "int", nullable: true),
                    AVM_TO = table.Column<int>(type: "int", nullable: true),
                    OR_FROM = table.Column<int>(type: "int", nullable: true),
                    OR_TO = table.Column<int>(type: "int", nullable: true),
                    VSM_FROM = table.Column<int>(type: "int", nullable: true),
                    VSM_TO = table.Column<int>(type: "int", nullable: true),
                    PR_FROM = table.Column<int>(type: "int", nullable: true),
                    PR_TO = table.Column<int>(type: "int", nullable: true),
                    MFL_FROM = table.Column<int>(type: "int", nullable: true),
                    MFLTO = table.Column<int>(type: "int", nullable: true),
                    DF_FROM = table.Column<int>(type: "int", nullable: true),
                    DF_TO = table.Column<int>(type: "int", nullable: true),
                    VSR_FROM = table.Column<int>(type: "int", nullable: true),
                    VSR_TO = table.Column<int>(type: "int", nullable: true),
                    LF_FROM = table.Column<int>(type: "int", nullable: true),
                    LF_TO = table.Column<int>(type: "int", nullable: true),
                    MI_FROM = table.Column<int>(type: "int", nullable: true),
                    MI_TO = table.Column<int>(type: "int", nullable: true),
                    DB_FROM = table.Column<int>(type: "int", nullable: true),
                    DB_TO = table.Column<int>(type: "int", nullable: true),
                    LB_FROM = table.Column<int>(type: "int", nullable: true),
                    LB_TO = table.Column<int>(type: "int", nullable: true),
                    MFSD_FROM = table.Column<int>(type: "int", nullable: true),
                    MFSD_TO = table.Column<int>(type: "int", nullable: true),
                    WSRD = table.Column<int>(type: "int", nullable: true),
                    ile_Rank = table.Column<int>(type: "int", nullable: true),
                    MFS_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOMALMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TOMALMasters");
        }
    }
}
