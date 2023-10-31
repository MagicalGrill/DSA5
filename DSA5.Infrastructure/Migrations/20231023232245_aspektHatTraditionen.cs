using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class aspektHatTraditionen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspektGehoertZuTradition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AspektId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspektGehoertZuTradition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspektGehoertZuTradition_Aspekt_AspektId",
                        column: x => x.AspektId,
                        principalTable: "Aspekt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspektGehoertZuTradition_Tradition_TraditionId",
                        column: x => x.TraditionId,
                        principalTable: "Tradition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspektGehoertZuTradition_AspektId",
                table: "AspektGehoertZuTradition",
                column: "AspektId");

            migrationBuilder.CreateIndex(
                name: "IX_AspektGehoertZuTradition_TraditionId",
                table: "AspektGehoertZuTradition",
                column: "TraditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspektGehoertZuTradition");
        }
    }
}
