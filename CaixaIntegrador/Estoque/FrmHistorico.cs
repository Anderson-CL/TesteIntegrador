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
    public partial class FrmHistorico : MaterialForm
    {

        private readonly int _produtoIdInicial;


        public FrmHistorico(int produtoIdInicial = 0)
        {
            InitializeComponent();
            _produtoIdInicial = produtoIdInicial;
            this.Load += FrmHistorico_Load;
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarComboTipo();
            CarregarFiltros();

            // Seleciona o produto no combo se veio de um produto específico
            if (_produtoIdInicial > 0)
            {
                for (int i = 0; i < cmbFiltroProduto.Items.Count; i++)
                {
                    dynamic item = cmbFiltroProduto.Items[i];
                    if (item.Id == _produtoIdInicial)
                    {
                        cmbFiltroProduto.SelectedIndex = i;
                        return; // o SelectedIndexChanged já chama CarregarHistorico
                    }
                }
            }

            // Se não achou produto ou veio sem filtro, carrega tudo
            CarregarHistorico();
        }

        private void CarregarComboTipo()
        {
            // Desliga evento para não disparar ao popular
            cmbFiltroTipo.SelectedIndexChanged -= cmbFiltroTipo_SelectedIndexChanged;

            cmbFiltroTipo.Items.Clear();
            cmbFiltroTipo.Items.Add("Todos");
            cmbFiltroTipo.Items.Add("Entrada");
            cmbFiltroTipo.Items.Add("Saida");
            cmbFiltroTipo.Items.Add("Ajuste");
            cmbFiltroTipo.SelectedIndex = 0;

            cmbFiltroTipo.SelectedIndexChanged += cmbFiltroTipo_SelectedIndexChanged;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Colorir linhas por tipo de movimentação
            dataGridView1.RowPostPaint += ColorirLinhasPorTipo;
        }

        private void ColorirLinhasPorTipo(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var tipo = row.Cells["Tipo"]?.Value?.ToString();

            switch (tipo)
            {
                case "Entrada":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233); // verde claro
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(27, 94, 32);
                    break;
                case "Saida":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238); // vermelho claro
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);
                    break;
                case "Ajuste":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224); // laranja claro
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);
                    break;
                default:
                    row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                    break;
            } 
        }

            private void CarregarFiltros()
        {
            {
                using var db = new AppDbContext();

                // Busca IDs dos produtos que têm movimentações
                var idsComMov = db.MovimentacoesEstoque
                    .Select(m => m.ProdutoId)
                    .Distinct()
                    .ToList();

                // Busca os nomes desses produtos
                var produtos = db.Produtos
                    .Where(p => idsComMov.Contains(p.Id))
                    .OrderBy(p => p.Nome)
                    .Select(p => new { p.Id, p.Nome })
                    .ToList();

                var lista = new[] { new { Id = 0, Nome = "— Todos os produtos —" } }
                    .Concat(produtos)
                    .ToList();

                // Desliga evento para não disparar ao setar DataSource
                cmbFiltroProduto.SelectedIndexChanged -= cmbFiltroProduto_SelectedIndexChanged;

                cmbFiltroProduto.DataSource = lista;
                cmbFiltroProduto.DisplayMember = "Nome";
                cmbFiltroProduto.ValueMember = "Id";
                cmbFiltroProduto.SelectedIndex = 0;

                cmbFiltroProduto.SelectedIndexChanged += cmbFiltroProduto_SelectedIndexChanged;
            }
        }

        private void CarregarHistorico(int produtoId = 0, string tipo = "Todos")
        {
            using var db = new AppDbContext();

            // Traz tudo em memória primeiro para evitar problemas de tradução LINQ
            var movs = db.MovimentacoesEstoque.ToList();
            var prods = db.Produtos.ToList();

            // Join em memória — garante que Produto sempre vira string
            var resultado = movs
                .Join(prods,
                    m => m.ProdutoId,
                    p => p.Id,
                    (m, p) => new
                    {
                        m.Id,
                        Produto = p.Nome,              // string — nunca objeto
                        ProdutoId = p.Id,                // usado no filtro abaixo
                        m.Tipo,
                        m.Quantidade,
                        Antes = m.QuantidadeAnterior,
                        Depois = m.QuantidadeNova,
                        m.Observacao,
                        Data = m.Data
                    })
                .Where(x => produtoId == 0 || x.ProdutoId == produtoId)
                .Where(x => tipo == "Todos" || x.Tipo == tipo)
                .OrderByDescending(x => x.Data)
                .Select(x => new              // remove ProdutoId do grid
                {
                    x.Id,
                    x.Produto,
                    x.Tipo,
                    x.Quantidade,
                    x.Antes,
                    x.Depois,
                    x.Observacao,
                    x.Data
                })
                .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = resultado;

            // Esconde Id, expande Produto
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns["Produto"] != null)
                dataGridView1.Columns["Produto"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridView1.Columns["Data"] != null)
                dataGridView1.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            foreach (var col in new[] { "Quantidade", "Antes", "Depois" })
                if (dataGridView1.Columns[col] != null)
                    dataGridView1.Columns[col].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dataGridView1.Columns["Produto"] != null)
                dataGridView1.Columns["Produto"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

            lblTotal.Text = $"Total: {resultado.Count} movimentação(ões)";

        }

        private void AplicarFiltros()
        {
            int produtoId = 0;
            if (cmbFiltroProduto.SelectedValue is int val)
                produtoId = val;

            string tipo = cmbFiltroTipo.SelectedItem?.ToString() ?? "Todos";
            CarregarHistorico(produtoId, tipo);
        }


        private void cmbFiltroProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
