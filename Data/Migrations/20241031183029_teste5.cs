using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botas.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Venda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Venda",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
