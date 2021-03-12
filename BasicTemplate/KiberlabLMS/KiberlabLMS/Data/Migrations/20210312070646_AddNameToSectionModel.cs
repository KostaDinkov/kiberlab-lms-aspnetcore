using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class AddNameToSectionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Section");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Section",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Section");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Section",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
