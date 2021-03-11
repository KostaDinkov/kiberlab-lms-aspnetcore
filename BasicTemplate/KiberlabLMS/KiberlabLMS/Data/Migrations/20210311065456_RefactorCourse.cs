using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class RefactorCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "ImageFilePath",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFilePath",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
