using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TranslatePhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OriginalImage = table.Column<byte[]>(type: "bytea", nullable: false),
                    TranslateImage = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatePhoto", x => x.Id);
                });

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
                        name: "FK_TranslatePhotoUser_TranslatePhoto_TranslatePhotosId",
                        column: x => x.TranslatePhotosId,
                        principalTable: "TranslatePhoto",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslatePhotoUser");

            migrationBuilder.DropTable(
                name: "TranslatePhoto");
        }
    }
}
