using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botas.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientStatus",
                table: "Cliente",
                newName: "clientStatus");

            migrationBuilder.AlterColumn<int>(
                name: "clientStatus",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "clientStatus",
                table: "Cliente",
                newName: "ClientStatus");

            migrationBuilder.AlterColumn<string>(
                name: "ClientStatus",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
