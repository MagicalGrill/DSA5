using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class renamedConsecratedTraditionIdPropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TraditionEmpfiehltAspekt_Tradition_TraditionId",
                table: "TraditionEmpfiehltAspekt");

            migrationBuilder.RenameColumn(
                name: "TraditionId",
                table: "TraditionEmpfiehltAspekt",
                newName: "GeweihtentraditionId");

            migrationBuilder.RenameIndex(
                name: "IX_TraditionEmpfiehltAspekt_TraditionId",
                table: "TraditionEmpfiehltAspekt",
                newName: "IX_TraditionEmpfiehltAspekt_GeweihtentraditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TraditionEmpfiehltAspekt_Tradition_GeweihtentraditionId",
                table: "TraditionEmpfiehltAspekt",
                column: "GeweihtentraditionId",
                principalTable: "Tradition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TraditionEmpfiehltAspekt_Tradition_GeweihtentraditionId",
                table: "TraditionEmpfiehltAspekt");

            migrationBuilder.RenameColumn(
                name: "GeweihtentraditionId",
                table: "TraditionEmpfiehltAspekt",
                newName: "TraditionId");

            migrationBuilder.RenameIndex(
                name: "IX_TraditionEmpfiehltAspekt_GeweihtentraditionId",
                table: "TraditionEmpfiehltAspekt",
                newName: "IX_TraditionEmpfiehltAspekt_TraditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TraditionEmpfiehltAspekt_Tradition_TraditionId",
                table: "TraditionEmpfiehltAspekt",
                column: "TraditionId",
                principalTable: "Tradition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
