using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class aspectBelongsToTradition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GeweihtentraditionId",
                table: "Aspekt",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aspekt_GeweihtentraditionId",
                table: "Aspekt",
                column: "GeweihtentraditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aspekt_Tradition_GeweihtentraditionId",
                table: "Aspekt",
                column: "GeweihtentraditionId",
                principalTable: "Tradition",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aspekt_Tradition_GeweihtentraditionId",
                table: "Aspekt");

            migrationBuilder.DropIndex(
                name: "IX_Aspekt_GeweihtentraditionId",
                table: "Aspekt");

            migrationBuilder.DropColumn(
                name: "GeweihtentraditionId",
                table: "Aspekt");
        }
    }
}
