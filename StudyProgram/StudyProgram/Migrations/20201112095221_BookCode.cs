using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyProgram.Migrations
{
    public partial class BookCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "BookCode",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCode",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "BookId",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
