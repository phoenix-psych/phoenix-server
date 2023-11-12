using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class TOMALIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TOMALIndexs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ind = table.Column<int>(type: "int", nullable: true),
                    VMI = table.Column<int>(type: "int", nullable: true),
                    NMI = table.Column<int>(type: "int", nullable: true),
                    NMI_TO = table.Column<int>(type: "int", nullable: true),
                    CMI = table.Column<int>(type: "int", nullable: true),
                    CMI_TO = table.Column<int>(type: "int", nullable: true),
                    VDRI = table.Column<int>(type: "int", nullable: true),
                    VDRI_1 = table.Column<int>(type: "int", nullable: true),
                    ACI = table.Column<int>(type: "int", nullable: true),
                    SRI = table.Column<int>(type: "int", nullable: true),
                    SRI_TO = table.Column<int>(type: "int", nullable: true),
                    FRI = table.Column<int>(type: "int", nullable: true),
                    FRI_TO = table.Column<int>(type: "int", nullable: true),
                    ARI = table.Column<int>(type: "int", nullable: true),
                    ARI_TO = table.Column<int>(type: "int", nullable: true),
                    LI = table.Column<int>(type: "int", nullable: true),
                    LI_TO = table.Column<int>(type: "int", nullable: true),
                    Percentile = table.Column<int>(type: "int", nullable: true),
                    Percentile_TO = table.Column<int>(type: "int", nullable: true),
                    ACI_TO = table.Column<int>(type: "int", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOMALIndexs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TOMALIndexs");
        }
    }
}
