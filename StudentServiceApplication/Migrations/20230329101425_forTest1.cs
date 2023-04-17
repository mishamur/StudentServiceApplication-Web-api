using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class forTest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInteres_Interests_InteresId",
                table: "UserInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInteres_Users_UserId",
                table: "UserInteres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInteres",
                table: "UserInteres");

            migrationBuilder.RenameTable(
                name: "UserInteres",
                newName: "UsersInteres");

            migrationBuilder.RenameIndex(
                name: "IX_UserInteres_UserId",
                table: "UsersInteres",
                newName: "IX_UsersInteres_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInteres_InteresId",
                table: "UsersInteres",
                newName: "IX_UsersInteres_InteresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersInteres_Interests_InteresId",
                table: "UsersInteres",
                column: "InteresId",
                principalTable: "Interests",
                principalColumn: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersInteres_Users_UserId",
                table: "UsersInteres",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersInteres_Interests_InteresId",
                table: "UsersInteres");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersInteres_Users_UserId",
                table: "UsersInteres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres");

            migrationBuilder.RenameTable(
                name: "UsersInteres",
                newName: "UserInteres");

            migrationBuilder.RenameIndex(
                name: "IX_UsersInteres_UserId",
                table: "UserInteres",
                newName: "IX_UserInteres_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UsersInteres_InteresId",
                table: "UserInteres",
                newName: "IX_UserInteres_InteresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInteres",
                table: "UserInteres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInteres_Interests_InteresId",
                table: "UserInteres",
                column: "InteresId",
                principalTable: "Interests",
                principalColumn: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInteres_Users_UserId",
                table: "UserInteres",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
