using CaixaIntegrador.Classes;
using CaixaIntegrador.Data;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador.Estoque
{
    public partial class FrmMovimentacao : MaterialForm
    {
        private readonly int _produtoId;
        private readonly string _nomeProduto;
        private readonly int _qtdAtual;

        // Tipo escolhido: "Entrada", "Saida" ou "Ajuste"
        private string _tipoSelecionado = "Entrada";

        public FrmMovimentacao(int produtoId, string nomeProduto, int qtdAtual)
        {
            InitializeComponent();
            _produtoId = produtoId;
            _nomeProduto = nomeProduto;
            _qtdAtual = qtdAtual;
        }

        private void FrmMovimentacao_Load(object sender, EventArgs e)
        {
            // Preenche o cabeçalho com os dados do produto
            lblNomeProduto.Text = _nomeProduto;
            lblEstoqueAtual.Text = $"Estoque atual: {_qtdAtual} un.";

            // Começa com Entrada selecionada
            SelecionarTipo("Entrada");
            AtualizarPreview();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            SelecionarTipo("Entrada");
            AtualizarPreview();

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            SelecionarTipo("Saida");
            AtualizarPreview();
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            SelecionarTipo("Ajuste");
            AtualizarPreview();

        }

        private void SelecionarTipo(string tipo)
        {
            _tipoSelecionado = tipo;

            // Reset visual de todos os botões
            btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnSaida.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btnAjuste.FlatAppearance.BorderColor = System.Drawing.Color.Gray;

            btnEntrada.ForeColor = System.Drawing.Color.Gray;
            btnSaida.ForeColor = System.Drawing.Color.Gray;
            btnAjuste.ForeColor = System.Drawing.Color.Gray;

            // Destaca o selecionado
            switch (tipo)
            {
                case "Entrada":
                    btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(57, 73, 171);
                    btnEntrada.ForeColor = System.Drawing.Color.FromArgb(57, 73, 171);
                    lblQuantidade.Text = "Quantidade a ADICIONAR:";
                    break;
                case "Saida":
                    btnSaida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(233, 30, 99);
                    btnSaida.ForeColor = System.Drawing.Color.FromArgb(233, 30, 99);
                    lblQuantidade.Text = "Quantidade a REMOVER:";
                    break;
                case "Ajuste":
                    btnAjuste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 152, 0);
                    btnAjuste.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);
                    lblQuantidade.Text = "Nova quantidade TOTAL:";
                    break;
            }
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {
            AtualizarPreview();
        }

        private void AtualizarPreview()
        {
            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 0)
            {
                lblPreview.Text = "Digite uma quantidade válida.";
                lblPreview.ForeColor = System.Drawing.Color.Gray;
                return;
            }

            int novaQtd;

            switch (_tipoSelecionado)
            {
                case "Entrada":
                    novaQtd = _qtdAtual + qtd;
                    lblPreview.Text = $"Estoque passará de {_qtdAtual} para {novaQtd} unidades.";
                    lblPreview.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50); // verde
                    break;
                case "Saida":
                    novaQtd = _qtdAtual - qtd;
                    if (novaQtd < 0)
                    {
                        lblPreview.Text = $"Atenção: estoque ficará negativo ({novaQtd}).";
                        lblPreview.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40); // vermelho
                    }
                    else
                    {
                        lblPreview.Text = $"Estoque passará de {_qtdAtual} para {novaQtd} unidades.";
                        lblPreview.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
                    }
                    break;
                case "Ajuste":
                    novaQtd = qtd;
                    lblPreview.Text = $"Estoque será ajustado de {_qtdAtual} para {novaQtd} unidades.";
                    lblPreview.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0); // laranja
                    break;
                default:
                    novaQtd = _qtdAtual;
                    lblPreview.Text = "";
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            if (qtd == 0 && _tipoSelecionado != "Ajuste")
            {
                MessageBox.Show("A quantidade deve ser maior que zero.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            // Calcula a quantidade nova com base no tipo
            int qtdAnterior = _qtdAtual;
            int qtdNova;

            switch (_tipoSelecionado)
            {
                case "Entrada": qtdNova = _qtdAtual + qtd; break;
                case "Saida": qtdNova = _qtdAtual - qtd; break;
                default: qtdNova = qtd; break; // Ajuste
            }

            // Confirmação se ficar negativo
            if (qtdNova < 0)
            {
                var resp = MessageBox.Show(
                    $"O estoque ficará negativo ({qtdNova}). Deseja continuar?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resp == DialogResult.No) return;
            }

            // Grava no banco
            try
            {
                using var db = new AppDbContext();

                // Atualiza a quantidade do produto
                var produto = db.Produtos.Find(_produtoId);
                if (produto == null)
                {
                    MessageBox.Show("Produto não encontrado.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                produto.Quantidade = qtdNova;

                // Grava o histórico na tabela de movimentações
                var movimentacao = new MovimentacaoEstoque
                {
                    ProdutoId = _produtoId,
                    Tipo = _tipoSelecionado,
                    Quantidade = qtd,
                    QuantidadeAnterior = qtdAnterior,
                    QuantidadeNova = qtdNova,
                    Observacao = txtObservacao.Text.Trim(),
                    Data = DateTime.Now
                };

                db.MovimentacoesEstoque.Add(movimentacao);
                db.SaveChanges();

                MessageBox.Show(
                    $"Movimentação registrada!\nEstoque atualizado para {qtdNova} unidades.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtObservacao_Click(object sender, EventArgs e)
        {

        }
    }
}

