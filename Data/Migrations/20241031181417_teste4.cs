using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Botas.Data.Migrations
{
    /// <inheritdoc />
    public partial class teste4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "clientStatus",
                table: "Cliente",
                newName: "ClientStatus");

            migrationBuilder.AlterColumn<bool>(
                name: "ClientStatus",
                table: "Cliente",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
