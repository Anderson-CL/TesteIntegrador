using CaixaIntegrador.Classes;
using CaixaIntegrador.Data;
using MaterialSkin;
using MaterialSkin.Controls;
namespace CaixaIntegrador
{
    public partial class Form1 : MaterialForm
    {
        // Puxa as listas de categorias, subcategorias, produtos e carrinho
        private List<CarrinhoCompra> carrinho = new List<CarrinhoCompra>();
        private List<Pedido> pedidos = new List<Pedido>();
        private List<Pagamento> pagamentosAtuais = new List<Pagamento>();

        // Puxa os user controls
        private UCCategorias ucCategorias = new UCCategorias();
        private UCSubCategorias ucSubCategorias = new UCSubCategorias();
        private UCProdutos ucProdutos = new UCProdutos();

        // Métodos adicionados na inicialização do form
        public Form1()
        {
            InitializeComponent();
            InicializarEventos();
            CarregarDadosIniciais();
            AdicionarUserControlPrincipal();
            TemaFormSkin();
        }

        // Conecta os eventos dos user controls
        private void InicializarEventos()
        {
            ucCategorias.CategoriaSelecionada += CategoriaSelecionada;
            ucSubCategorias.SubCategoriaSelecionada += SubCategoriaSelecionada;
            ucProdutos.ProdutoSelecionado += AdicionarAoCarrinho;
            ucSubCategorias.VoltarClick += VoltarCategorias;
            ucProdutos.VoltarClick += VoltarSubCategorias;
        }

        // Adiciona o user control no painel
        private void AdicionarUserControlPrincipal()
        {
            panelPrincipal.Controls.Add(ucCategorias);
            ucCategorias.Dock = DockStyle.Fill;
        }

        private void TemaFormSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900,    // Cor Principal: Vinho bem escuro (fundo de botões/barras)
                Primary.BlueGrey900, // Tom de contraste profundo para barras de título
                Primary.Red600,    // Tom médio para destaques suaves
                Accent.Orange400,  // Âmbar Pastel (Destaque que não "agride" no escuro)
                TextShade.WHITE    // Texto branco puro
            );
        }
        private void CarregarDadosIniciais()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var categorias = db.Categorias.ToList();
                    ucCategorias.CarregarCategorias(categorias);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar banco: {ex.Message}", "Erro Crítico");
            }
        }

        // Filtra e exibe as subcategorias para categoria selecionada
        private void CategoriaSelecionada(int categoriaId)
        {
            using (var db = new AppDbContext())
            {
                var listaFiltrada = db.SubCategorias
                                      .Where(x => x.CategoriaId == categoriaId)
                                      .ToList();
                ExibirUserControl(ucSubCategorias);
                ucSubCategorias.CarregarSubCategorias(listaFiltrada);
            }
        }

        // Filtra e exibe os produtos para subcategoria selecionada
        private void SubCategoriaSelecionada(int subId)
        {
            using (var db = new AppDbContext())
            {
                var listaFiltrada = db.Produtos
                                      .Where(x => x.SubCategoriaId == subId)
                                      .ToList();
                ExibirUserControl(ucProdutos);
                ucProdutos.CarregarProdutos(listaFiltrada);
            }
        }

        // Volta para a tela de categorias
        private void VoltarCategorias()
        {
            ExibirUserControl(ucCategorias);
        }

        // Volta para a tela de subcategorias
        private void VoltarSubCategorias()
        {
            ExibirUserControl(ucSubCategorias);
        }

        // Limpa o painel principal e mostra o usercontrol
        private void ExibirUserControl(Control userControl)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        // Adiciona um produto no carrinho ou aumenta sua quantidade se já tem
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

        // Deleta os itens do carrinho que estão marcados na checkbox
        private void BtnDeletarMarcados_Click(object sender, EventArgs e)
        {
            var itensDeletar = DataGrid_Produtos.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Column5"].Value is bool marcado && marcado)
                .Select(r => r.Index)
                .OrderByDescending(i => i);

            foreach (var i in itensDeletar)
                carrinho.RemoveAt(i);

            AtualizarCarrinhoUI();
        }

        // Limpa todo o carrinho
        private void BtnLimparCarrinho_Click(object sender, EventArgs e)
        {
            carrinho.Clear();
            AtualizarCarrinhoUI();
        }

        // Atualiza a exibição do carrinho na DataGrid
        private void AtualizarCarrinhoUI()
        {
            DataGrid_Produtos.DataSource = null;
            DataGrid_Produtos.DataSource = carrinho;
            AtualizarTotal();
        }

        // Calcula e exibe o valor total do carrinho
        private void AtualizarTotal()
        {
            decimal totalGeral = carrinho.Sum(c => c.Total);
            lblTotal_Text.Text = $"Total: R$ {totalGeral}";
        }

        // Atualiza a quantidade de um produto quando editado na DataGrid
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

        // Abre o form de pedidos
        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            Order tabOrder = new Order();
            tabOrder.CarregarPedidos(pedidos);
            tabOrder.ShowDialog();
        }

        // Finaliza o pedido atual e o salva na lista de pedidos finalizados
        private void btn_FinalizarPedido_Click(object sender, EventArgs e)
        {
            // Valida se o carrinho está vazio
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Adicione produtos ao carrinho!", "Carrinho vazio");
                return;
            }

            // Valida se há pagamentos registrados
            if (pagamentosAtuais.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos uma forma de pagamento!", "Erro");
                return;
            }

            // Calcula o total do pedido
            decimal totalPedido = carrinho.Sum(c => c.Total);
            decimal totalPago = pagamentosAtuais.Sum(p => p.Valor);
            var troco = totalPago - totalPedido;

            // Valida se o total foi pago
            if (totalPago < totalPedido)
            {
                MessageBox.Show($"Pagamento incompleto. Total: R$ {totalPedido:F2}, Pago: R$ {totalPago:F2}", "Erro");
                return;
            }

            // Cria um novo pedido com status finalizado
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

            // Adiciona o pedido à lista
            pedidos.Add(novoPedido);

            // Exibe mensagem de sucesso
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

            // Limpa o carrinho e pagamentos após finalizar
            carrinho.Clear();
            pagamentosAtuais.Clear();
            AtualizarCarrinhoUI();
            AtualizarLabelPagamentos();
            LimparFormularioPagamento();
            troco_label.Text = "";

            // Volta para a tela de categorias
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

        // Adiciona um pagamento à lista de pagamentos do pedido
        private void btnAdicionarPagamento_Click(object sender, EventArgs e)
        {
            PagamentoGeral();
        }

        private void materialTextBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PagamentoGeral();
        }

        private void PagamentoGeral()
        {
            // Valida se um radio button foi selecionado
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

            // Valida se o valor é válido (aceita "50" ou "50,00")
            string valorTexto = Valores_MaterialTextBox.Text.Trim();
            if (string.IsNullOrEmpty(valorTexto))
            {
                MessageBox.Show("Digite um valor válido!", "Erro");
                return;
            }

            // Tenta converter o valor
            if (!decimal.TryParse(valorTexto, out decimal valorPagamento) || valorPagamento <= 0)
            {
                MessageBox.Show("Digite um valor numérico válido! (Ex: 50 ou 50,50)", "Erro");
                return;
            }

            // Valida se o valor não ultrapassa o saldo
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

                    // Calcula o troco total após adicionar o pagamento
                    decimal trocoTotal = pagamentosAtuais.Sum(p => p.Valor) - totalPedido;

                    // Exibe o troco ANTES de limpar o formulário
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
                    PanelBtnPag.Enabled = false;
                    btnAdicionarPagamento.Enabled = false;
                    Valores_MaterialTextBox.Enabled = false;
                    panelPrincipal.Enabled = false;
                    btnDeletarMarcados.Enabled = false;
                    btnLimparCarrinho.Enabled = false;
                    DataGrid_Produtos.Enabled = false;
                }
                else
                {
                    // Pagamento menor que saldo → adiciona normalmente
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
                // Outras formas de pagamento
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
                    btnAdicionarPagamento.Enabled = false;
                    Valores_MaterialTextBox.Enabled = false;
                    panelPrincipal.Enabled = false;
                    btnDeletarMarcados.Enabled = false;
                    btnLimparCarrinho.Enabled = false;
                    DataGrid_Produtos.Enabled = false;
                    PanelBtnPag.Enabled = false;
                }
            }
        }

        // Atualiza o label com o valor total de pagamentos
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

            // Não mostra valores negativos (já foi pago)
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

        // Limpa o formulário de pagamento
        private void LimparFormularioPagamento()
        {
            // Desseleciona todos os radio buttons
            materialRadioButton1.Checked = false;
            materialRadioButton2.Checked = false;
            materialRadioButton3.Checked = false;
            materialRadioButton4.Checked = false;
            materialRadioButton5.Checked = false;

            // Habilita o botão de adicionar pagamento
            panelPrincipal.Enabled = true;
            btnAdicionarPagamento.Enabled = true;
            Valores_MaterialTextBox.Enabled = true;
            btnDeletarMarcados.Enabled = true;
            btnLimparCarrinho.Enabled = true;
            DataGrid_Produtos.Enabled = true;
            PanelBtnPag.Enabled = true;

            // Limpa o textbox
            Valores_MaterialTextBox.Text = "";
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarValorPadrao();
        }

        private void btn_Limparpag_Click(object sender, EventArgs e)
        {
            LimparFormularioPagamento();
            lblValorPago.Text = "";
            pagamentosAtuais.Clear();
        }
    }
    public interface IImpressora
    {
        void ImprimirNFC(Pedido pedido);
    }
}


