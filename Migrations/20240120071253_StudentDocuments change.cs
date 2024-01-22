using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class StudentDocumentschange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("StudentDocuments");

            migrationBuilder.CreateTable(
               name: "StudentDocuments",
               columns: table => new
               {
                   Id = table.Column<string>(type: "uniqueidentifier", nullable: false),
                   StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   CreatedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   ModifiedUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                   CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_StudentDocuments", x => x.Id);
               });
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "StudentDocuments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
