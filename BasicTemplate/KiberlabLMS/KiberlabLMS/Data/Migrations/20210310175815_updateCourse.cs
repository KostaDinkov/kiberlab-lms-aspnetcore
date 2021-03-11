using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class updateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LessonViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Position = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonViewModel");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Courses");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Courses",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
