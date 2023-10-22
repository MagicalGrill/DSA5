using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mergeTalents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiturgieVerbreitung_Liturgie_LiturgieId",
                table: "LiturgieVerbreitung");

            migrationBuilder.DropForeignKey(
                name: "FK_ZauberVerbreitung_Zauber_ZauberId",
                table: "ZauberVerbreitung");

            migrationBuilder.DropTable(
                name: "Fluch");

            migrationBuilder.DropTable(
                name: "Liturgie");

            migrationBuilder.DropTable(
                name: "Zauber");

            migrationBuilder.AddColumn<bool>(
                name: "ModifiziertDurchSeelenkraft",
                table: "Talent",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ModifiziertDurchZaehigkeit",
                table: "Talent",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TalentArt",
                table: "Talent",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_LiturgieVerbreitung_Talent_LiturgieId",
                table: "LiturgieVerbreitung",
                column: "LiturgieId",
                principalTable: "Talent",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ZauberVerbreitung_Talent_ZauberId",
                table: "ZauberVerbreitung",
                column: "ZauberId",
                principalTable: "Talent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiturgieVerbreitung_Talent_LiturgieId",
                table: "LiturgieVerbreitung");

            migrationBuilder.DropForeignKey(
                name: "FK_ZauberVerbreitung_Talent_ZauberId",
                table: "ZauberVerbreitung");

            migrationBuilder.DropColumn(
                name: "ModifiziertDurchSeelenkraft",
                table: "Talent");

            migrationBuilder.DropColumn(
                name: "ModifiziertDurchZaehigkeit",
                table: "Talent");

            migrationBuilder.DropColumn(
                name: "TalentArt",
                table: "Talent");

            migrationBuilder.CreateTable(
                name: "Liturgie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liturgie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liturgie_Talent_Id",
                        column: x => x.Id,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zauber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiziertDurchSeelenkraft = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiziertDurchZaehigkeit = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zauber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zauber_Talent_Id",
                        column: x => x.Id,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fluch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fluch_Zauber_Id",
                        column: x => x.Id,
                        principalTable: "Zauber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LiturgieVerbreitung_Liturgie_LiturgieId",
                table: "LiturgieVerbreitung",
                column: "LiturgieId",
                principalTable: "Liturgie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ZauberVerbreitung_Zauber_ZauberId",
                table: "ZauberVerbreitung",
                column: "ZauberId",
                principalTable: "Zauber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
