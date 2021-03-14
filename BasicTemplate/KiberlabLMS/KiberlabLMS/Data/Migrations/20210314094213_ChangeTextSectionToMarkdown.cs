using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class ChangeTextSectionToMarkdown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HtmlString",
                table: "Section");

            migrationBuilder.AddColumn<string>(
                name: "Markdown",
                table: "Section",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VideoSectionViewModel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    VideoUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LessonId = table.Column<string>(nullable: true),
                    SectionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoSectionViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoSectionViewModel");

            migrationBuilder.DropColumn(
                name: "Markdown",
                table: "Section");

            migrationBuilder.AddColumn<string>(
                name: "HtmlString",
                table: "Section",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
