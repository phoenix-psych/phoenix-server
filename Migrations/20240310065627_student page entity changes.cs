using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class studentpageentitychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentPage1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q37 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q38 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q39 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q40 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q43 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q44 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPage1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentPage2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPage2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentPage3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPage3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentPage4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q32 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q33 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q34 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q35 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q36 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q37 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q38 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q39 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q40 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q41 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q42 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPage4", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentPage1");

            migrationBuilder.DropTable(
                name: "StudentPage2");

            migrationBuilder.DropTable(
                name: "StudentPage3");

            migrationBuilder.DropTable(
                name: "StudentPage4");
        }
    }
}
