using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaixaIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_SubCategoriaId",
                table: "Produtos",
                column: "SubCategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_SubCategorias_SubCategoriaId",
                table: "Produtos",
                column: "SubCategoriaId",
                principalTable: "SubCategorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_SubCategorias_SubCategoriaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategorias_Categorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_SubCategoriaId",
                table: "Produtos");
        }
    }
}
