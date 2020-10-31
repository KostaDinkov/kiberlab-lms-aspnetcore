using Microsoft.EntityFrameworkCore.Migrations;

namespace KiberlabLMS.Data.Migrations
{
    public partial class AddSectionsToCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStates_UserProfile_UserProfileId",
                table: "CourseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_AspNetUsers_ApplicationUserId",
                table: "UserProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_CourseInstances_CourseInstanceId",
                table: "UserProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile");

            migrationBuilder.DropColumn(
                name: "HtmlContent",
                table: "Lessons");

            migrationBuilder.RenameTable(
                name: "UserProfile",
                newName: "UserProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfile_CourseInstanceId",
                table: "UserProfiles",
                newName: "IX_UserProfiles_CourseInstanceId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfile_ApplicationUserId",
                table: "UserProfiles",
                newName: "IX_UserProfiles_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Section",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Section_CourseId",
                table: "Section",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStates_UserProfiles_UserProfileId",
                table: "CourseStates",
                column: "UserProfileId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Courses_CourseId",
                table: "Section",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_AspNetUsers_ApplicationUserId",
                table: "UserProfiles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfiles_CourseInstances_CourseInstanceId",
                table: "UserProfiles",
                column: "CourseInstanceId",
                principalTable: "CourseInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStates_UserProfiles_UserProfileId",
                table: "CourseStates");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Courses_CourseId",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_AspNetUsers_ApplicationUserId",
                table: "UserProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfiles_CourseInstances_CourseInstanceId",
                table: "UserProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Section_CourseId",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProfiles",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "UserProfiles",
                newName: "UserProfile");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfiles_CourseInstanceId",
                table: "UserProfile",
                newName: "IX_UserProfile_CourseInstanceId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfiles_ApplicationUserId",
                table: "UserProfile",
                newName: "IX_UserProfile_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "HtmlContent",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProfile",
                table: "UserProfile",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStates_UserProfile_UserProfileId",
                table: "CourseStates",
                column: "UserProfileId",
                principalTable: "UserProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_AspNetUsers_ApplicationUserId",
                table: "UserProfile",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_CourseInstances_CourseInstanceId",
                table: "UserProfile",
                column: "CourseInstanceId",
                principalTable: "CourseInstances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
