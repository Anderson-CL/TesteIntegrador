using CaixaIntegrador.Caixa;
using CaixaIntegrador.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador
{
    public partial class Order : Form
    {
        // Armazena a lista de pedidos finalizados
        private List<Pedido> pedidosFinalizados = new List<Pedido>();
        // Armazena a lista de pedidos em aberto
        private List<Pedido> pedidosAbertos = new List<Pedido>();

        public Order()
        {
            InitializeComponent();
        }

        // Carrega a lista de pedidos (abertos e finalizados) do formulário principal
        public void CarregarPedidos(List<Pedido> todosPedidos)
        {
            pedidosAbertos = todosPedidos.Where(p => p.Status == PedidoStatus.Aberto).ToList();
            pedidosFinalizados = todosPedidos.Where(p => p.Status == PedidoStatus.Finalizado).ToList();

            AtualizarDataGridFinalizados();
            AtualizarDataGridAbertos();
        }

        // Atualiza a exibição dos pedidos finalizados na DataGrid
        private void AtualizarDataGridFinalizados()
        {
            GridViewFinalizados.Rows.Clear();

            foreach (var pedido in pedidosFinalizados)
            {
                GridViewFinalizados.Rows.Add(
                    pedido.Id,
                    pedido.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss"),
                    $"R$ {pedido.Total:F2}",
                    string.Join(", ", pedido.Pagamentos.Select(p => $"{p.Forma}")),
                    string.Join(", ", pedido.Itens.Select(i => $"{i.Produto} x{i.Qtd}")),
                    "Nota");

                //pedido.Troco != 0 ? $"Troco: R$ {pedido.Troco:F2}" : "");

            }
        }

        // Atualiza a exibição dos pedidos abertos na DataGrid
        private void AtualizarDataGridAbertos()
        {

        }

        // Abre a aba de pedidos finalizados
        public void AbrirAbaPedidosFinalizados()
        {
            materialTabControl1.SelectedIndex = 1; // Índice da aba de finalizados
        }

        // Adiciona um pedido finalizado à lista e atualiza a exibição
        public void AdicionarPedidoFinalizado(Pedido pedido)
        {
            pedidosFinalizados.Add(pedido);
            AtualizarDataGridFinalizados();
        }

        private void GridViewFinalizados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou na coluna de botão existente
            if (GridViewFinalizados.Columns[e.ColumnIndex].Name == "btnNFC" && e.RowIndex >= 0)
            {
                var pedido = pedidosFinalizados[e.RowIndex];
                if (pedido != null)
                    AbrirNFC(pedido);
            }
        }

        private void AbrirNFC(Pedido pedido)
        {
            var formNFC = new NFCtela(pedido);
            formNFC.ShowDialog();
        }
    }
}