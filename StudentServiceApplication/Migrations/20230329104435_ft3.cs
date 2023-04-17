using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres");

            migrationBuilder.DropIndex(
                name: "IX_UsersInteres_InteresId",
                table: "UsersInteres");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UsersInteres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres",
                columns: new[] { "InteresId", "UserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UsersInteres",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersInteres",
                table: "UsersInteres",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsersInteres_InteresId",
                table: "UsersInteres",
                column: "InteresId");
        }
    }
}
