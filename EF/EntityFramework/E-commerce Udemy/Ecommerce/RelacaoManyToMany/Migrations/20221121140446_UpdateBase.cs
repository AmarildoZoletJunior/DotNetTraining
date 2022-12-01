using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RelacaoManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colaboradores",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Amarildo" },
                    { 2, "Maria" }
                });

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Engenharia" },
                    { 2, "Logística" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colaboradores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
