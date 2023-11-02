using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kampftechnikWithLeiteigenschaft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
