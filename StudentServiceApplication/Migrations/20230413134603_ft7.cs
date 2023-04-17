using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countrys_CountryId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys");

            migrationBuilder.RenameTable(
                name: "Countrys",
                newName: "Countries");

            migrationBuilder.RenameColumn(
                name: "ProfileImage",
                table: "Users",
                newName: "UserProfile_ProfileImage");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "UserProfile_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Users",
                newName: "UserProfile_Lastname");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "UserProfile_Gender");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Users",
                newName: "UserProfile_Firstname");

            migrationBuilder.RenameColumn(
                name: "DateOfBirthday",
                table: "Users",
                newName: "UserProfile_DateOfBirthday");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Users",
                newName: "UserProfile_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                newName: "IX_Users_UserProfile_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId",
                principalTable: "Countries",
                principalColumn: "InteresId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Countrys");

            migrationBuilder.RenameColumn(
                name: "UserProfile_ProfileImage",
                table: "Users",
                newName: "ProfileImage");

            migrationBuilder.RenameColumn(
                name: "UserProfile_PhoneNumber",
                table: "Users",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "UserProfile_Lastname",
                table: "Users",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "UserProfile_Gender",
                table: "Users",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "UserProfile_Firstname",
                table: "Users",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "UserProfile_DateOfBirthday",
                table: "Users",
                newName: "DateOfBirthday");

            migrationBuilder.RenameColumn(
                name: "UserProfile_CountryId",
                table: "Users",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserProfile_CountryId",
                table: "Users",
                newName: "IX_Users_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrys",
                table: "Countrys",
                column: "InteresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countrys_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countrys",
                principalColumn: "InteresId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
