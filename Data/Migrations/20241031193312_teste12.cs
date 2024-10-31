using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botas.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Venda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
