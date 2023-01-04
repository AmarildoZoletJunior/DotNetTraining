using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste.Migrations
{
    /// <inheritdoc />
    public partial class TesteBanco12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceitas_Un_Medida_IngredientesReceitasId",
                table: "IngredientesReceitas");

            migrationBuilder.DropIndex(
                name: "IX_IngredientesReceitas_IngredientesReceitasId",
                table: "IngredientesReceitas");

            migrationBuilder.DropColumn(
                name: "IngredientesReceitasId",
                table: "IngredientesReceitas");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceitas_Un_MedidaId",
                table: "IngredientesReceitas",
                column: "Un_MedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceitas_Un_Medida_Un_MedidaId",
                table: "IngredientesReceitas",
                column: "Un_MedidaId",
                principalTable: "Un_Medida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientesReceitas_Un_Medida_Un_MedidaId",
                table: "IngredientesReceitas");

            migrationBuilder.DropIndex(
                name: "IX_IngredientesReceitas_Un_MedidaId",
                table: "IngredientesReceitas");

            migrationBuilder.AddColumn<int>(
                name: "IngredientesReceitasId",
                table: "IngredientesReceitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceitas_IngredientesReceitasId",
                table: "IngredientesReceitas",
                column: "IngredientesReceitasId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientesReceitas_Un_Medida_IngredientesReceitasId",
                table: "IngredientesReceitas",
                column: "IngredientesReceitasId",
                principalTable: "Un_Medida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
