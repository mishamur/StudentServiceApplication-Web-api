using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentServiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class ft23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_Skill_SkillsSkillId",
                table: "SkillUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser1_Skill_WantedSkillsSkillId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "WantedSkill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WantedSkill",
                table: "WantedSkill",
                column: "SkillId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser_WantedSkill_SkillsSkillId",
                table: "SkillUser");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillUser1_WantedSkill_WantedSkillsSkillId",
                table: "SkillUser1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WantedSkill",
                table: "WantedSkill");

            migrationBuilder.RenameTable(
                name: "WantedSkill",
                newName: "Skill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser_Skill_SkillsSkillId",
                table: "SkillUser",
                column: "SkillsSkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillUser1_Skill_WantedSkillsSkillId",
                table: "SkillUser1",
                column: "WantedSkillsSkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
