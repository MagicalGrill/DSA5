using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class splitTraditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TraditionArt",
                table: "Tradition",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraditionArt",
                table: "Tradition");
        }
    }
}
