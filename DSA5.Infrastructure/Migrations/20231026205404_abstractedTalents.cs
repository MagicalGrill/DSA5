using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class abstractedTalents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KulturEmpfiehltTalent_Talent_TalentId",
                table: "KulturEmpfiehltTalent");

            migrationBuilder.DropForeignKey(
                name: "FK_LiturgieVerbreitung_Talent_LiturgieId",
                table: "LiturgieVerbreitung");

            migrationBuilder.DropForeignKey(
                name: "FK_SonderfertigkeitBrauchtTalent_Talent_TalentId",
                table: "SonderfertigkeitBrauchtTalent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf1Id",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf2Id",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf3Id",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Steigerungsfaktor_SteigerungsfaktorId",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_Talent_Talentgruppe_TalentgruppeId",
                table: "Talent");

            migrationBuilder.DropForeignKey(
                name: "FK_ZauberVerbreitung_Talent_ZauberId",
                table: "ZauberVerbreitung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Talent",
                table: "Talent");

            migrationBuilder.RenameTable(
                name: "Talent",
                newName: "Fertigkeit");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_Wurf3Id",
                table: "Fertigkeit",
                newName: "IX_Fertigkeit_Wurf3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_Wurf2Id",
                table: "Fertigkeit",
                newName: "IX_Fertigkeit_Wurf2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_Wurf1Id",
                table: "Fertigkeit",
                newName: "IX_Fertigkeit_Wurf1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_TalentgruppeId",
                table: "Fertigkeit",
                newName: "IX_Fertigkeit_TalentgruppeId");

            migrationBuilder.RenameIndex(
                name: "IX_Talent_SteigerungsfaktorId",
                table: "Fertigkeit",
                newName: "IX_Fertigkeit_SteigerungsfaktorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "TalentgruppeId",
                table: "Fertigkeit",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "BeeinflusstDurchBelastung",
                table: "Fertigkeit",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fertigkeit",
                table: "Fertigkeit",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Segnung_AspektId",
                table: "Segnung",
                column: "AspektId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf1Id",
                table: "Fertigkeit",
                column: "Wurf1Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf2Id",
                table: "Fertigkeit",
                column: "Wurf2Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf3Id",
                table: "Fertigkeit",
                column: "Wurf3Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fertigkeit_Steigerungsfaktor_SteigerungsfaktorId",
                table: "Fertigkeit",
                column: "SteigerungsfaktorId",
                principalTable: "Steigerungsfaktor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fertigkeit_Talentgruppe_TalentgruppeId",
                table: "Fertigkeit",
                column: "TalentgruppeId",
                principalTable: "Talentgruppe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KulturEmpfiehltTalent_Fertigkeit_TalentId",
                table: "KulturEmpfiehltTalent",
                column: "TalentId",
                principalTable: "Fertigkeit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LiturgieVerbreitung_Fertigkeit_LiturgieId",
                table: "LiturgieVerbreitung",
                column: "LiturgieId",
                principalTable: "Fertigkeit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Segnung_Aspekt_AspektId",
                table: "Segnung",
                column: "AspektId",
                principalTable: "Aspekt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SonderfertigkeitBrauchtTalent_Fertigkeit_TalentId",
                table: "SonderfertigkeitBrauchtTalent",
                column: "TalentId",
                principalTable: "Fertigkeit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZauberVerbreitung_Fertigkeit_ZauberId",
                table: "ZauberVerbreitung",
                column: "ZauberId",
                principalTable: "Fertigkeit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf1Id",
                table: "Fertigkeit");

            migrationBuilder.DropForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf2Id",
                table: "Fertigkeit");

            migrationBuilder.DropForeignKey(
                name: "FK_Fertigkeit_Eigenschaft_Wurf3Id",
                table: "Fertigkeit");

            migrationBuilder.DropForeignKey(
                name: "FK_Fertigkeit_Steigerungsfaktor_SteigerungsfaktorId",
                table: "Fertigkeit");

            migrationBuilder.DropForeignKey(
                name: "FK_Fertigkeit_Talentgruppe_TalentgruppeId",
                table: "Fertigkeit");

            migrationBuilder.DropForeignKey(
                name: "FK_KulturEmpfiehltTalent_Fertigkeit_TalentId",
                table: "KulturEmpfiehltTalent");

            migrationBuilder.DropForeignKey(
                name: "FK_LiturgieVerbreitung_Fertigkeit_LiturgieId",
                table: "LiturgieVerbreitung");

            migrationBuilder.DropForeignKey(
                name: "FK_Segnung_Aspekt_AspektId",
                table: "Segnung");

            migrationBuilder.DropForeignKey(
                name: "FK_SonderfertigkeitBrauchtTalent_Fertigkeit_TalentId",
                table: "SonderfertigkeitBrauchtTalent");

            migrationBuilder.DropForeignKey(
                name: "FK_ZauberVerbreitung_Fertigkeit_ZauberId",
                table: "ZauberVerbreitung");

            migrationBuilder.DropIndex(
                name: "IX_Segnung_AspektId",
                table: "Segnung");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fertigkeit",
                table: "Fertigkeit");

            migrationBuilder.RenameTable(
                name: "Fertigkeit",
                newName: "Talent");

            migrationBuilder.RenameIndex(
                name: "IX_Fertigkeit_Wurf3Id",
                table: "Talent",
                newName: "IX_Talent_Wurf3Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fertigkeit_Wurf2Id",
                table: "Talent",
                newName: "IX_Talent_Wurf2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fertigkeit_Wurf1Id",
                table: "Talent",
                newName: "IX_Talent_Wurf1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fertigkeit_TalentgruppeId",
                table: "Talent",
                newName: "IX_Talent_TalentgruppeId");

            migrationBuilder.RenameIndex(
                name: "IX_Fertigkeit_SteigerungsfaktorId",
                table: "Talent",
                newName: "IX_Talent_SteigerungsfaktorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "TalentgruppeId",
                table: "Talent",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeeinflusstDurchBelastung",
                table: "Talent",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Talent",
                table: "Talent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KulturEmpfiehltTalent_Talent_TalentId",
                table: "KulturEmpfiehltTalent",
                column: "TalentId",
                principalTable: "Talent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LiturgieVerbreitung_Talent_LiturgieId",
                table: "LiturgieVerbreitung",
                column: "LiturgieId",
                principalTable: "Talent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SonderfertigkeitBrauchtTalent_Talent_TalentId",
                table: "SonderfertigkeitBrauchtTalent",
                column: "TalentId",
                principalTable: "Talent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf1Id",
                table: "Talent",
                column: "Wurf1Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf2Id",
                table: "Talent",
                column: "Wurf2Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Eigenschaft_Wurf3Id",
                table: "Talent",
                column: "Wurf3Id",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Steigerungsfaktor_SteigerungsfaktorId",
                table: "Talent",
                column: "SteigerungsfaktorId",
                principalTable: "Steigerungsfaktor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talent_Talentgruppe_TalentgruppeId",
                table: "Talent",
                column: "TalentgruppeId",
                principalTable: "Talentgruppe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZauberVerbreitung_Talent_ZauberId",
                table: "ZauberVerbreitung",
                column: "ZauberId",
                principalTable: "Talent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
