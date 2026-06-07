using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaixaIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Pedidos_PedidoId",
                table: "Pagamento");

            migrationBuilder.DropTable(
                name: "CarrinhoCompra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento");

            migrationBuilder.RenameTable(
                name: "Pagamento",
                newName: "PedidoPagamentos");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PedidoPagamentos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Pagamento_PedidoId",
                table: "PedidoPagamentos",
                newName: "IX_PedidoPagamentos_PedidoId");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Vendas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitario",
                table: "Vendas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "Vendas",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Pedidos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoPagamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Forma",
                table: "PedidoPagamentos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoPagamentos",
                table: "PedidoPagamentos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MovimentacoesEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantidadeAnterior = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantidadeNova = table.Column<int>(type: "INTEGER", nullable: false),
                    Observacao = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentacoesEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentacoesEstoque_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_PedidoId",
                table: "Vendas",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentacoesEstoque_ProdutoId",
                table: "MovimentacoesEstoque",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoPagamentos_Pedidos_PedidoId",
                table: "PedidoPagamentos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Pedidos_PedidoId",
                table: "Vendas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoPagamentos_Pedidos_PedidoId",
                table: "PedidoPagamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Pedidos_PedidoId",
                table: "Vendas");

            migrationBuilder.DropTable(
                name: "MovimentacoesEstoque");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_PedidoId",
                table: "Vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoPagamentos",
                table: "PedidoPagamentos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "Vendas");

            migrationBuilder.RenameTable(
                name: "PedidoPagamentos",
                newName: "Pagamento");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pagamento",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoPagamentos_PedidoId",
                table: "Pagamento",
                newName: "IX_Pagamento_PedidoId");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "Pagamento",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "Forma",
                table: "Pagamento",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento",
                column: "id");

            migrationBuilder.CreateTable(
                name: "CarrinhoCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    Produto = table.Column<string>(type: "TEXT", nullable: false),
                    Qtd = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompra_PedidoId",
                table: "CarrinhoCompra",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Pedidos_PedidoId",
                table: "Pagamento",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }
    }
}
