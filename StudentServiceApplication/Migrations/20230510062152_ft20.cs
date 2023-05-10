using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslatePhotoUser");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TranslatePhotos",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TranslatePhotos_UserId",
                table: "TranslatePhotos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslatePhotos_Users_UserId",
                table: "TranslatePhotos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslatePhotos_Users_UserId",
                table: "TranslatePhotos");

            migrationBuilder.DropIndex(
                name: "IX_TranslatePhotos_UserId",
                table: "TranslatePhotos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TranslatePhotos");

            migrationBuilder.CreateTable(
                name: "TranslatePhotoUser",
                columns: table => new
                {
                    TranslatePhotosId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsersUserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatePhotoUser", x => new { x.TranslatePhotosId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_TranslatePhotoUser_TranslatePhotos_TranslatePhotosId",
                        column: x => x.TranslatePhotosId,
                        principalTable: "TranslatePhotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslatePhotoUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TranslatePhotoUser_UsersUserId",
                table: "TranslatePhotoUser",
                column: "UsersUserId");
        }
    }
}
