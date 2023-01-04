using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoReceitas.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Usuario_UsuarioId",
                table: "Receita");

            migrationBuilder.DropTable(
                name: "IngredientesReceitas");

            migrationBuilder.DropTable(
                name: "Un_Medida");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Receita",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Rendimento",
                table: "Receita",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "IngredienteReceita",
                columns: table => new
                {
                    ListaIngredientesId = table.Column<int>(type: "int", nullable: false),
                    ListaReceitasReceitaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredienteReceita", x => new { x.ListaIngredientesId, x.ListaReceitasReceitaId });
                    table.ForeignKey(
                        name: "FK_IngredienteReceita_Ingrediente_ListaIngredientesId",
                        column: x => x.ListaIngredientesId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredienteReceita_Receita_ListaReceitasReceitaId",
                        column: x => x.ListaReceitasReceitaId,
                        principalTable: "Receita",
                        principalColumn: "ReceitaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredienteReceita_ListaReceitasReceitaId",
                table: "IngredienteReceita",
                column: "ListaReceitasReceitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Usuario_UsuarioId",
                table: "Receita",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receita_Usuario_UsuarioId",
                table: "Receita");

            migrationBuilder.DropTable(
                name: "IngredienteReceita");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Receita",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rendimento",
                table: "Receita",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Un_Medida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medida = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Un_Medida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientesReceitas",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(type: "int", nullable: false),
                    IngredienteId = table.Column<int>(type: "int", nullable: false),
                    UnMedidaId = table.Column<int>(name: "Un_MedidaId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesReceitas", x => new { x.ReceitaId, x.IngredienteId, x.UnMedidaId });
                    table.ForeignKey(
                        name: "FK_IngredientesReceitas_Ingrediente_IngredienteId",
                        column: x => x.IngredienteId,
                        principalTable: "Ingrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesReceitas_Receita_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receita",
                        principalColumn: "ReceitaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesReceitas_Un_Medida_Un_MedidaId",
                        column: x => x.UnMedidaId,
                        principalTable: "Un_Medida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceitas_IngredienteId",
                table: "IngredientesReceitas",
                column: "IngredienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesReceitas_Un_MedidaId",
                table: "IngredientesReceitas",
                column: "Un_MedidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receita_Usuario_UsuarioId",
                table: "Receita",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
