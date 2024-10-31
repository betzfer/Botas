using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botas.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Venda",
                newName: "OrderStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "Venda",
                newName: "Status");
        }
    }
}
