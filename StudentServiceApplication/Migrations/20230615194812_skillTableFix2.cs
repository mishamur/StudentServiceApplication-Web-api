using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class skillTableFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_WantedSkill_SkillsSkillId",
                table: "SkillUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser1_WantedSkill_WantedSkillsSkillId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser1",
                table: "SkillUser1");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser1_WantedSkillsSkillId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser_SkillsSkillId",
                table: "SkillUser");

            migrationBuilder.RenameColumn(
                name: "WantedSkillsSkillId",
                table: "SkillUser1",
                newName: "NeedingSkillsSkillId");

            migrationBuilder.RenameColumn(
                name: "SkillsSkillId",
                table: "SkillUser",
                newName: "HavingSkillsSkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser1",
                table: "SkillUser1",
                columns: new[] { "NeedingSkillsSkillId", "NeedingUsersUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser",
                columns: new[] { "HavingSkillsSkillId", "HavingUsersUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser1_NeedingUsersUserId",
                table: "SkillUser1",
                column: "NeedingUsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_HavingUsersUserId",
                table: "SkillUser",
                column: "HavingUsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_WantedSkill_HavingSkillsSkillId",
                table: "SkillUser",
                column: "HavingSkillsSkillId",
                principalTable: "WantedSkill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser1_WantedSkill_NeedingSkillsSkillId",
                table: "SkillUser1",
                column: "NeedingSkillsSkillId",
                principalTable: "WantedSkill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_WantedSkill_HavingSkillsSkillId",
                table: "SkillUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser1_WantedSkill_NeedingSkillsSkillId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser1",
                table: "SkillUser1");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser1_NeedingUsersUserId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser");

            migrationBuilder.DropIndex(
                name: "IX_SkillUser_HavingUsersUserId",
                table: "SkillUser");

            migrationBuilder.RenameColumn(
                name: "NeedingSkillsSkillId",
                table: "SkillUser1",
                newName: "WantedSkillsSkillId");

            migrationBuilder.RenameColumn(
                name: "HavingSkillsSkillId",
                table: "SkillUser",
                newName: "SkillsSkillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser1",
                table: "SkillUser1",
                columns: new[] { "NeedingUsersUserId", "WantedSkillsSkillId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillUser",
                table: "SkillUser",
                columns: new[] { "HavingUsersUserId", "SkillsSkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser1_WantedSkillsSkillId",
                table: "SkillUser1",
                column: "WantedSkillsSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillUser_SkillsSkillId",
                table: "SkillUser",
                column: "SkillsSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_WantedSkill_SkillsSkillId",
                table: "SkillUser",
                column: "SkillsSkillId",
                principalTable: "WantedSkill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser1_WantedSkill_WantedSkillsSkillId",
                table: "SkillUser1",
                column: "WantedSkillsSkillId",
                principalTable: "WantedSkill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
