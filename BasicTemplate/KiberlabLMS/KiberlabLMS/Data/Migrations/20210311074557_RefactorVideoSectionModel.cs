using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class RefactorVideoSectionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Section",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Section",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Section");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Section");
        }
    }
}
