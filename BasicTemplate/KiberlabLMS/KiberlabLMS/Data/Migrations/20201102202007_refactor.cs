using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStates_UserProfiles_UserProgressId",
                table: "CourseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_AspNetUsers_ApplicationUserId",
                table: "UserProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "UserProgresses");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfiles_ApplicationUserId",
                table: "UserProgresses",
                newName: "IX_UserProgresses_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProgresses",
                table: "UserProgresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStates_UserProgresses_UserProgressId",
                table: "CourseStates",
                column: "UserProgressId",
                principalTable: "UserProgresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgresses_AspNetUsers_ApplicationUserId",
                table: "UserProgresses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStates_UserProgresses_UserProgressId",
                table: "CourseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProgresses_AspNetUsers_ApplicationUserId",
                table: "UserProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProgresses",
                table: "UserProgresses");

            migrationBuilder.RenameTable(
                name: "UserProgresses",
                newName: "UserProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_UserProgresses_ApplicationUserId",
                table: "UserProfiles",
                newName: "IX_UserProfiles_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStates_UserProfiles_UserProgressId",
                table: "CourseStates",
                column: "UserProgressId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_AspNetUsers_ApplicationUserId",
                table: "UserProfiles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
