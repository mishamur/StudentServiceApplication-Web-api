using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslatePhotoUser_TranslatePhoto_TranslatePhotosId",
                table: "TranslatePhotoUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TranslatePhoto",
                table: "TranslatePhoto");

            migrationBuilder.RenameTable(
                name: "TranslatePhoto",
                newName: "TranslatePhotos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TranslatePhotos",
                table: "TranslatePhotos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslatePhotoUser_TranslatePhotos_TranslatePhotosId",
                table: "TranslatePhotoUser",
                column: "TranslatePhotosId",
                principalTable: "TranslatePhotos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranslatePhotoUser_TranslatePhotos_TranslatePhotosId",
                table: "TranslatePhotoUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TranslatePhotos",
                table: "TranslatePhotos");

            migrationBuilder.RenameTable(
                name: "TranslatePhotos",
                newName: "TranslatePhoto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TranslatePhoto",
                table: "TranslatePhoto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TranslatePhotoUser_TranslatePhoto_TranslatePhotosId",
                table: "TranslatePhotoUser",
                column: "TranslatePhotosId",
                principalTable: "TranslatePhoto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
