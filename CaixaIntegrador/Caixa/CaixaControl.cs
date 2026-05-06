using CaixaIntegrador.Classes;
using CaixaIntegrador.Data;
using CaixaIntegrador.Pagina_Inicial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CaixaIntegrador.Caixa
{
    public partial class CaixaControl : UserControl
    {
        // Listas de dados
        private List<CarrinhoCompra> carrinho = new List<CarrinhoCompra>();
        private List<Pedido> pedidos = new List<Pedido>();
        private List<Pagamento> pagamentosAtuais = new List<Pagamento>();

        // UserControls auxiliares
        private UCCategorias ucCategorias = new UCCategorias();
        private UCSubCategorias ucSubCategorias = new UCSubCategorias();
        private UCProdutos ucProdutos = new UCProdutos();
        private AppDbContext db = new AppDbContext();

        public CaixaControl()
        {
            InitializeComponent();
            InicializarEventos();
            CarregarDadosIniciais();
            AdicionarUserControlPrincipal();
        }

        #region User Controls e navegação
        private void InicializarEventos()
        {
            ucCategorias.CategoriaSelecionada += CategoriaSelecionada;
            ucSubCategorias.SubCategoriaSelecionada += SubCategoriaSelecionada;
            ucProdutos.ProdutoSelecionado += AdicionarAoCarrinho;
            ucSubCategorias.VoltarClick += VoltarCategorias;
            ucProdutos.VoltarClick += VoltarSubCategorias;
        }

        private void AdicionarUserControlPrincipal()
        {
            panelPrincipal.Controls.Add(ucCategorias);
            ucCategorias.Dock = DockStyle.Fill;
        }

        private void VoltarCategorias()
        {
            ExibirUserControl(ucCategorias);
        }

        private void VoltarSubCategorias()
        {
            ExibirUserControl(ucSubCategorias);
        }

        private void ExibirUserControl(Control userControl)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
        #endregion

        #region Banco de Dados
        private void CarregarDadosIniciais()
        {
            try
            {
                var categorias = db.Categorias.ToList();
                ucCategorias.CarregarCategorias(categorias);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar banco: {ex.Message}", "Erro Crítico");
            }
        }

        private void CategoriaSelecionada(int categoriaId)
        {
            var listaFiltrada = db.SubCategorias
                                  .Where(x => x.CategoriaId == categoriaId)
                                  .ToList();
            ExibirUserControl(ucSubCategorias);
            ucSubCategorias.CarregarSubCategorias(listaFiltrada);
        }

        private void SubCategoriaSelecionada(int subId)
        {
            var listaFiltrada = db.Produtos
                                  .Where(x => x.SubCategoriaId == subId)
                                  .ToList();
            ExibirUserControl(ucProdutos);
            ucProdutos.CarregarProdutos(listaFiltrada);
        }
        #endregion

        #region Carrinho
        private void AdicionarAoCarrinho(Produto produto)
        {
            var itemExistente = carrinho.FirstOrDefault(c => c.Produto == produto.Nome);
            if (itemExistente != null)
            {
                itemExistente.Qtd++;
            }
            else
            {
                carrinho.Add(new CarrinhoCompra { Produto = produto.Nome, Qtd = 1, Preco = produto.Preco });
            }
            AtualizarCarrinhoUI();
        }

        private void BtnDeletarMarcados_Click(object sender, EventArgs e)
        {
            // garantir que qualquer edição pendente (checkbox sendo editado) seja confirmada
            DataGrid_Produtos.EndEdit();
            DataGrid_Produtos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var itensDeletar = DataGrid_Produtos.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Column5"].Value is bool marcado && marcado)
                .Select(r => r.Index)
                .OrderByDescending(i => i);

            foreach (var i in itensDeletar)
                carrinho.RemoveAt(i);

            AtualizarCarrinhoUI();
        }

        private void BtnLimparCarrinho_Click(object sender, EventArgs e)
        {
            carrinho.Clear();
            AtualizarCarrinhoUI();
        }

        private void AtualizarCarrinhoUI()
        {
            DataGrid_Produtos.DataSource = null;
            DataGrid_Produtos.DataSource = carrinho;

            if (DataGrid_Produtos.Columns["Preco"] != null)
                DataGrid_Produtos.Columns["Preco"].DefaultCellStyle.Format = "C2";

            if (DataGrid_Produtos.Columns["Total"] != null)
                DataGrid_Produtos.Columns["Total"].DefaultCellStyle.Format = "C2";
            // Garantir que a coluna de checkbox tenha valores padrão (false) após rebind
            if (DataGrid_Produtos.Columns.Contains("Column5"))
            {
                DataGrid_Produtos.Columns["Column5"].DefaultCellStyle.NullValue = false;
                foreach (DataGridViewRow row in DataGrid_Produtos.Rows)
                {
                    if (row.Cells["Column5"].Value == null)
                        row.Cells["Column5"].Value = false;
                }
            }
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            decimal totalGeral = carrinho.Sum(c => c.Total);
            lblTotal_Text.Text = $"Total: R$ {totalGeral}";
        }

        private void DataGrid_Produtos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid_Produtos.Columns[e.ColumnIndex].Name == "Qtd")
            {
                var row = DataGrid_Produtos.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["Qtd"].Value?.ToString(), out int novaQuantidade))
                {
                    var item = carrinho[e.RowIndex];
                    item.Qtd = novaQuantidade;
                    row.Cells["Total"].Value = item.Total;
                    AtualizarTotal();
                    DataGrid_Produtos.Refresh();
                }
            }
        }
        #endregion

        #region Pedido e Pagamento
        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            // Se Order for um Form, pode manter ShowDialog, senão adapte para UserControl
            Order tabOrder = new Order();
            tabOrder.CarregarPedidos(pedidos);
            tabOrder.ShowDialog();
        }

        private void materialTextBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PagamentoGeral();
        }

        private void PagamentoGeral()
        {
            FormaPagamento? formaSelecionada = null;

            if (materialRadioButton1.Checked) formaSelecionada = FormaPagamento.Credito;
            else if (materialRadioButton2.Checked) formaSelecionada = FormaPagamento.Debito;
            else if (materialRadioButton3.Checked) formaSelecionada = FormaPagamento.Pix;
            else if (materialRadioButton4.Checked) formaSelecionada = FormaPagamento.Voucher;
            else if (materialRadioButton5.Checked) formaSelecionada = FormaPagamento.Dinheiro;

            if (formaSelecionada == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento!", "Erro");
                return;
            }

            string valorTexto = Valores_MaterialTextBox.Text.Trim();
            if (string.IsNullOrEmpty(valorTexto))
            {
                MessageBox.Show("Digite um valor válido!", "Erro");
                return;
            }

            if (!decimal.TryParse(valorTexto, out decimal valorPagamento) || valorPagamento <= 0)
            {
                MessageBox.Show("Digite um valor numérico válido! (Ex: 50 ou 50,50)", "Erro");
                return;
            }

            decimal totalPedido = carrinho.Sum(c => c.Total);
            decimal valorPago = pagamentosAtuais.Sum(p => p.Valor);
            decimal saldo = totalPedido - valorPago;
            if (formaSelecionada == FormaPagamento.Dinheiro)
            {
                if (valorPagamento >= saldo)
                {
                    var novoPagamento = new Pagamento
                    {
                        Forma = FormaPagamento.Dinheiro,
                        Valor = valorPagamento
                    };
                    pagamentosAtuais.Add(novoPagamento);

                    AtualizarLabelPagamentos();

                    decimal trocoTotal = pagamentosAtuais.Sum(p => p.Valor) - totalPedido;

                    if (trocoTotal > 0)
                    {
                        MessageBox.Show($"Troco de {trocoTotal.ToString("C")}", "Troco");
                        troco_label.Text = $"Troco: {trocoTotal.ToString("C")}";
                        troco_label.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Pagamento completo! Clique em 'Finalizar Pedido'.", "Sucesso");
                    }

                    LimparFormularioPagamento();
                    DesativarCampos();
                }
                else
                {
                    var novoPagamento = new Pagamento
                    {
                        Forma = FormaPagamento.Dinheiro,
                        Valor = valorPagamento
                    };
                    pagamentosAtuais.Add(novoPagamento);

                    AtualizarLabelPagamentos();
                    LimparFormularioPagamento();
                }
            }
            else
            {
                if (valorPagamento > saldo)
                {
                    MessageBox.Show($"Valor não pode ser superior ao saldo de R$ {saldo:F2}!", "Erro");
                    return;
                }

                var novoPagamento = new Pagamento
                {
                    Forma = (FormaPagamento)formaSelecionada,
                    Valor = valorPagamento
                };
                pagamentosAtuais.Add(novoPagamento);

                AtualizarLabelPagamentos();
                LimparFormularioPagamento();

                if (saldo - valorPagamento <= 0)
                {
                    MessageBox.Show("Pagamento completo! Clique em 'Finalizar Pedido'.", "Sucesso");
                    DesativarCampos();
                }
            }
        }
        #endregion

        #region Atualização de valores e labels
        private void AtualizarLabelPagamentos()
        {
            decimal totalPago = pagamentosAtuais.Sum(p => p.Valor);
            lblValorPago.Text = $"Pagamentos: R$ {totalPago:F2}";
        }

        private void AtualizarValorPadrao()
        {
            decimal totalPedido = carrinho.Sum(c => c.Total);
            decimal valorPago = pagamentosAtuais.Sum(p => p.Valor);
            decimal saldo = totalPedido - valorPago;

            if (saldo <= 0)
            {
                Valores_MaterialTextBox.Text = "";
                Valores_MaterialTextBox.ForeColor = Color.Black;
                return;
            }

            if (string.IsNullOrWhiteSpace(Valores_MaterialTextBox.Text)
                || Valores_MaterialTextBox.ForeColor == Color.Gray)
            {
                Valores_MaterialTextBox.Text = saldo.ToString("F2");
                Valores_MaterialTextBox.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Ativar/Desativar campos de pagamento
        private void DesativarCampos()
        {
            panelPrincipal.Enabled = false;
            btnAdicionarPagamento.Enabled = false;
            Valores_MaterialTextBox.Enabled = false;
            btnDeletarMarcados.Enabled = false;
            btnLimparCarrinho.Enabled = false;
            DataGrid_Produtos.Enabled = false;
            PanelBtnPag.Enabled = false;
        }

        private void LimparFormularioPagamento()
        {
            materialRadioButton1.Checked = false;
            materialRadioButton2.Checked = false;
            materialRadioButton3.Checked = false;
            materialRadioButton4.Checked = false;
            materialRadioButton5.Checked = false;

            panelPrincipal.Enabled = true;
            btnAdicionarPagamento.Enabled = true;
            Valores_MaterialTextBox.Enabled = true;
            btnDeletarMarcados.Enabled = true;
            btnLimparCarrinho.Enabled = true;
            DataGrid_Produtos.Enabled = true;
            PanelBtnPag.Enabled = true;

            Valores_MaterialTextBox.Text = "";
        }
        #endregion

        private void btnLimparCarrinho_Click_1(object sender, EventArgs e)
        {
            carrinho.Clear();
            AtualizarCarrinhoUI();
        }

        private void btnDeletarMarcados_Click_1(object sender, EventArgs e)
        {
            // confirmar edição pendente de checkbox
            DataGrid_Produtos.EndEdit();
            DataGrid_Produtos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            var itensDeletar = DataGrid_Produtos.Rows
                  .Cast<DataGridViewRow>()
                  .Where(r => r.Cells["Column5"].Value is bool marcado && marcado)
                  .Select(r => r.Index)
                  .OrderByDescending(i => i);

            foreach (var i in itensDeletar)
                carrinho.RemoveAt(i);

            AtualizarCarrinhoUI();
        }

        private void btn_Pedido_Click_1(object sender, EventArgs e)
        {
            Order tabOrder = new Order();
            tabOrder.CarregarPedidos(pedidos);
            tabOrder.ShowDialog();
        }

        private void btn_Limparpag_Click_1(object sender, EventArgs e)
        {
            LimparFormularioPagamento();
            lblValorPago.Text = "";
            pagamentosAtuais.Clear();
        }

        private void DataGrid_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void btnAdicionarPagamento_Click_1(object sender, EventArgs e)
        {
            PagamentoGeral();
        }

        private void btn_FinalizarPedido_Click_1(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Adicione produtos ao carrinho!", "Carrinho vazio");
                return;
            }

            if (pagamentosAtuais.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos uma forma de pagamento!", "Erro");
                return;
            }

            decimal totalPedido = carrinho.Sum(c => c.Total);
            decimal totalPago = pagamentosAtuais.Sum(p => p.Valor);
            var troco = totalPago - totalPedido;

            if (totalPago < totalPedido)
            {
                MessageBox.Show($"Pagamento incompleto. Total: R$ {totalPedido:F2}, Pago: R$ {totalPago:F2}", "Erro");
                return;
            }

            var novoPedido = new Pedido
            {
                Id = pedidos.Count > 0 ? pedidos.Max(p => p.Id) + 1 : 1,
                DataCriacao = DateTime.Now,
                Itens = new List<CarrinhoCompra>(carrinho),
                Total = totalPedido,
                Status = PedidoStatus.Finalizado,
                Pagamentos = new List<Pagamento>(pagamentosAtuais),
                Troco = troco
            };

            pedidos.Add(novoPedido);

            string formasPagamento = string.Join(" + ", novoPedido.Pagamentos.Select(p =>
                $"{p.Forma} (R$ {p.Valor:F2})"));
            MessageBox.Show(
                $"Pedido #{novoPedido.Id} finalizado com sucesso!\n\n" +
                $"Total: R$ {novoPedido.Total:F2}\n" +
                $"Pagamentos: {formasPagamento}\n" +
                (novoPedido.Troco != 0 ? $"Troco: R$ {novoPedido.Troco:F2}" : ""),
                $"Pedido Finalizado");

            var resultado = MessageBox.Show(
                "Deseja Imprimir Nota Fiscal?",
                "Nota Fiscal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                var impressora = new ImpressoraNormal();
                impressora.ImprimirNFC(novoPedido);
            }

            carrinho.Clear();
            pagamentosAtuais.Clear();
            AtualizarCarrinhoUI();
            AtualizarLabelPagamentos();
            LimparFormularioPagamento();
            troco_label.Text = "";

            ExibirUserControl(ucCategorias);
        }

        private void materialTextBox21_Leave(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialTextBox21_Enter(object sender, EventArgs e)
        {
            decimal totalPedido = carrinho.Sum(c => c.Total);
            decimal valorPago = pagamentosAtuais.Sum(p => p.Valor);
            decimal saldo = totalPedido - valorPago;

            if (Valores_MaterialTextBox.Text == saldo.ToString("F2") &&
                Valores_MaterialTextBox.ForeColor == Color.Gray)
            {
                Valores_MaterialTextBox.Text = "";
                Valores_MaterialTextBox.ForeColor = Color.Black;
            }
        }

        private void btn_PedidoAberto_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBtnPag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Valores_MaterialTextBox_Click(object sender, EventArgs e)
        {

        }

      
    }
    public interface IImpressora
    {
        void ImprimirNFC(Pedido pedido);
    }
}
