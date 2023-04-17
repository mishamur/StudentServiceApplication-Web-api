using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserProfile_CountryId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "InteresId",
                table: "Languages",
                newName: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Languages",
                newName: "InteresId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfile_CountryId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId",
                principalTable: "Countries",
                principalColumn: "InteresId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
