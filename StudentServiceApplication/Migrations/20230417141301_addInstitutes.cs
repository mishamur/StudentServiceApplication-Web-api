using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class addInstitutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InstituteIstituteId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfile_InstituteId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Institutes",
                columns: table => new
                {
                    IstituteId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutes", x => x.IstituteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_InstituteIstituteId",
                table: "Users",
                column: "InstituteIstituteId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserProfile_InstituteId",
                table: "Users",
                column: "UserProfile_InstituteId");

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
                name: "FK_Users_Institutes_InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Institutes_UserProfile_InstituteId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Institutes");

            migrationBuilder.DropIndex(
                name: "IX_Users_InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserProfile_InstituteId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InstituteIstituteId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserProfile_InstituteId",
                table: "Users");
        }
    }
}
