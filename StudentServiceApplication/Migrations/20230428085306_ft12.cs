using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InteresUser_Users_UsersProfilesUserId",
                table: "InteresUser");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageUser_Users_UsersProfilesUserId",
                table: "LanguageUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_Users_UsersProfilesUserId",
                table: "SkillUser");

            migrationBuilder.RenameColumn(
                name: "UsersProfilesUserId",
                table: "SkillUser",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillUser_UsersProfilesUserId",
                table: "SkillUser",
                newName: "IX_SkillUser_UsersUserId");

            migrationBuilder.RenameColumn(
                name: "UsersProfilesUserId",
                table: "LanguageUser",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageUser_UsersProfilesUserId",
                table: "LanguageUser",
                newName: "IX_LanguageUser_UsersUserId");

            migrationBuilder.RenameColumn(
                name: "UsersProfilesUserId",
                table: "InteresUser",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InteresUser_UsersProfilesUserId",
                table: "InteresUser",
                newName: "IX_InteresUser_UsersUserId");

            migrationBuilder.RenameColumn(
                name: "InteresId",
                table: "Countries",
                newName: "CountryId");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InteresUser_Users_UsersUserId",
                table: "InteresUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageUser_Users_UsersUserId",
                table: "LanguageUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_Users_UsersUserId",
                table: "SkillUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InteresUser_Users_UsersUserId",
                table: "InteresUser");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageUser_Users_UsersUserId",
                table: "LanguageUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_Users_UsersUserId",
                table: "SkillUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "SkillUser",
                newName: "UsersProfilesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SkillUser_UsersUserId",
                table: "SkillUser",
                newName: "IX_SkillUser_UsersProfilesUserId");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "LanguageUser",
                newName: "UsersProfilesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageUser_UsersUserId",
                table: "LanguageUser",
                newName: "IX_LanguageUser_UsersProfilesUserId");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "InteresUser",
                newName: "UsersProfilesUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InteresUser_UsersUserId",
                table: "InteresUser",
                newName: "IX_InteresUser_UsersProfilesUserId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Countries",
                newName: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_InteresUser_Users_UsersProfilesUserId",
                table: "InteresUser",
                column: "UsersProfilesUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageUser_Users_UsersProfilesUserId",
                table: "LanguageUser",
                column: "UsersProfilesUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_Users_UsersProfilesUserId",
                table: "SkillUser",
                column: "UsersProfilesUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
