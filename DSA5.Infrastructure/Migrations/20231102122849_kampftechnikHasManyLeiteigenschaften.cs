using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kampftechnikHasManyLeiteigenschaften : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kampftechnik_Eigenschaft_LeiteigenschaftId",
                table: "Kampftechnik");

            migrationBuilder.DropIndex(
                name: "IX_Kampftechnik_LeiteigenschaftId",
                table: "Kampftechnik");

            migrationBuilder.DropColumn(
                name: "LeiteigenschaftId",
                table: "Kampftechnik");

            migrationBuilder.CreateTable(
                name: "KampftechnikHatLeiteigenschaft",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KampftechnikId = table.Column<Guid>(type: "uuid", nullable: false),
                    LeiteigenschaftId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KampftechnikHatLeiteigenschaft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KampftechnikHatLeiteigenschaft_Eigenschaft_LeiteigenschaftId",
                        column: x => x.LeiteigenschaftId,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KampftechnikHatLeiteigenschaft_Kampftechnik_KampftechnikId",
                        column: x => x.KampftechnikId,
                        principalTable: "Kampftechnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KampftechnikHatLeiteigenschaft_KampftechnikId",
                table: "KampftechnikHatLeiteigenschaft",
                column: "KampftechnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KampftechnikHatLeiteigenschaft_LeiteigenschaftId",
                table: "KampftechnikHatLeiteigenschaft",
                column: "LeiteigenschaftId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KampftechnikHatLeiteigenschaft");

            migrationBuilder.AddColumn<Guid>(
                name: "LeiteigenschaftId",
                table: "Kampftechnik",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Kampftechnik_LeiteigenschaftId",
                table: "Kampftechnik",
                column: "LeiteigenschaftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kampftechnik_Eigenschaft_LeiteigenschaftId",
                table: "Kampftechnik",
                column: "LeiteigenschaftId",
                principalTable: "Eigenschaft",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
