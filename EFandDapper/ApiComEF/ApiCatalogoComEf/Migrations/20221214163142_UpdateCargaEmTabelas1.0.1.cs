using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCargaEmTabelas101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "DataCadastro", "Descricao", "Estoque", "ImagemURL", "Nome", "Preco" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 14, 13, 31, 42, 100, DateTimeKind.Local).AddTicks(542), "2LT de puro refresco", 20f, "sucoLaranja.png", "Suco de laranja", 7.50m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1);
        }
    }
}
