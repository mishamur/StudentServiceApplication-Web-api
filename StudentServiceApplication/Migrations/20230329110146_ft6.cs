using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Country_CountryId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countrys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys",
                column: "InteresId");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    InteresId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.InteresId);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguages",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguages", x => new { x.LanguageId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "InteresId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_UserId",
                table: "UserLanguages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countrys_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "InteresId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countrys_CountryId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserLanguages");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys");

            migrationBuilder.RenameTable(
                name: "Countrys",
                newName: "Country");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Country_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "InteresId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
