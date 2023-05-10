using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_InstituteId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "InstituteId",
                table: "Users",
                newName: "UserProfile_InstituteId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_InstituteId",
                table: "Users",
                newName: "IX_Users_UserProfile_InstituteId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserProfile_InstituteId",
                table: "Users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "InstituteIstituteId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfile_CountryId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InstituteIstituteId",
                table: "Users",
                column: "InstituteIstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users",
                column: "UserProfile_CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Institutes_InstituteIstituteId",
                table: "Users",
                column: "InstituteIstituteId",
                principalTable: "Institutes",
                principalColumn: "IstituteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users",
                column: "UserProfile_InstituteId",
                principalTable: "Institutes",
                principalColumn: "IstituteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserProfile_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserProfile_CountryId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserProfile_InstituteId",
                table: "Users",
                newName: "InstituteId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserProfile_InstituteId",
                table: "Users",
                newName: "IX_Users_InstituteId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "InstituteId",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Institutes_InstituteId",
                table: "Users",
                column: "InstituteId",
                principalTable: "Institutes",
                principalColumn: "IstituteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
