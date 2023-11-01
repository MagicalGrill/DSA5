using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class anwendungsgebietWithoutDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beschreibung",
                table: "Anwendungsgebiet");

            migrationBuilder.CreateIndex(
                name: "IX_Anwendungsgebiet_TalentId",
                table: "Anwendungsgebiet",
                column: "TalentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anwendungsgebiet_Fertigkeit_TalentId",
                table: "Anwendungsgebiet",
                column: "TalentId",
                principalTable: "Fertigkeit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anwendungsgebiet_Fertigkeit_TalentId",
                table: "Anwendungsgebiet");

            migrationBuilder.DropIndex(
                name: "IX_Anwendungsgebiet_TalentId",
                table: "Anwendungsgebiet");

            migrationBuilder.AddColumn<string>(
                name: "Beschreibung",
                table: "Anwendungsgebiet",
                type: "text",
                nullable: true);
        }
    }
}
