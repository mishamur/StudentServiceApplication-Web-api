using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users",
                column: "UserProfile_InstituteId",
                principalTable: "Institutes",
                principalColumn: "IstituteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users",
                column: "UserProfile_InstituteId",
                principalTable: "Institutes",
                principalColumn: "IstituteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
