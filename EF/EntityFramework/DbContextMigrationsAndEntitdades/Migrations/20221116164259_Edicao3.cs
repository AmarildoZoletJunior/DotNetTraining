using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbContextMigrationsAndEntitdades.Migrations
{
    /// <inheritdoc />
    public partial class Edicao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClientesId",
                table: "Produtos",
                column: "ClientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClientesId",
                table: "Produtos",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClientesId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ClientesId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Produtos");
        }
    }
}
