using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaixaIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class Pedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Troco = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true),
                    Privilegio = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TokenRecuperacao = table.Column<string>(type: "TEXT", nullable: true),
                    TokenExpiracao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    DataVenda = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Produto = table.Column<string>(type: "TEXT", nullable: false),
                    Qtd = table.Column<int>(type: "INTEGER", nullable: false),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompra_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Forma = table.Column<int>(type: "INTEGER", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pagamento_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompra_PedidoId",
                table: "CarrinhoCompra",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_PedidoId",
                table: "Pagamento",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutoId",
                table: "Vendas",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompra");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");
        }
    }
}
