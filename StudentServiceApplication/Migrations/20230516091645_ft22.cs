using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_Users_UsersUserId",
                table: "SkillUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser_UsersUserId",
                table: "SkillUser");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "SkillUser",
                newName: "HavingUsersUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser",
                columns: new[] { "HavingUsersUserId", "SkillsSkillId" });

            migrationBuilder.CreateTable(
                name: "SkillUser1",
                columns: table => new
                {
                    NeedingUsersUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    WantedSkillsSkillId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillUser1", x => new { x.NeedingUsersUserId, x.WantedSkillsSkillId });
                    table.ForeignKey(
                        name: "FK_SkillUser1_Skill_WantedSkillsSkillId",
                        column: x => x.WantedSkillsSkillId,
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillUser1_Users_NeedingUsersUserId",
                        column: x => x.NeedingUsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_SkillsSkillId",
                table: "SkillUser",
                column: "SkillsSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser1_WantedSkillsSkillId",
                table: "SkillUser1",
                column: "WantedSkillsSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_Users_HavingUsersUserId",
                table: "SkillUser",
                column: "HavingUsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_Users_HavingUsersUserId",
                table: "SkillUser");

            migrationBuilder.DropTable(
                name: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser_SkillsSkillId",
                table: "SkillUser");

            migrationBuilder.RenameColumn(
                name: "HavingUsersUserId",
                table: "SkillUser",
                newName: "UsersUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser",
                columns: new[] { "SkillsSkillId", "UsersUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_UsersUserId",
                table: "SkillUser",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_Users_UsersUserId",
                table: "SkillUser",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
