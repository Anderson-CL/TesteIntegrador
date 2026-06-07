using CaixaIntegrador.Data;
using MaterialSkin.Controls;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador.Relatorios
{
    public partial class RelatorioVendasForm : MaterialForm
    {
        public RelatorioVendasForm()
        {
            InitializeComponent();
            this.Load += RelatorioVendasForm_Load;
        }

        private void RelatorioVendasForm_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            // Datas padrão: mês atual
            dtInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtFim.Value = DateTime.Now.Date;

            // Já carrega ao abrir
            GerarRelatorio();
        }

        private void ConfigurarGrid()
        {
            dataGridViewVendas.ReadOnly = true;
            dataGridViewVendas.AllowUserToAddRows = false;
            dataGridViewVendas.AllowUserToDeleteRows = false;
            dataGridViewVendas.AllowUserToResizeRows = false;
            dataGridViewVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVendas.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridViewVendas.Font, FontStyle.Bold);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private void GerarRelatorio()
        {
            var inicio = dtInicio.Value.Date;
            var fim = dtFim.Value.Date.AddDays(1).AddSeconds(-1); // até 23:59:59 do dia fim

            // Validação de datas
            if (inicio > dtFim.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new AppDbContext();

            var vendas = context.Vendas.ToList();
            var produtos = context.Produtos.ToList();

            var relatorio = vendas
                .Where(v => v.DataVenda >= inicio && v.DataVenda <= fim)
                .Join(produtos,
                    v => v.ProdutoId,
                    p => p.Id,
                    (v, p) => new
                    {
                        Data = v.DataVenda,
                        Produto = p.Nome,
                        v.Quantidade,
                        Preco = p.Preco,
                        ValorTotal = v.Quantidade * p.Preco
                    })
                .OrderBy(r => r.Data)
                .ToList();

            dataGridViewVendas.AutoGenerateColumns = true;
            dataGridViewVendas.DataSource = relatorio;

            // Formatação das colunas
            if (dataGridViewVendas.Columns["Data"] != null)
            {
                dataGridViewVendas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                dataGridViewVendas.Columns["Data"].HeaderText = "Data";
            }

            if (dataGridViewVendas.Columns["Produto"] != null)
            {
                dataGridViewVendas.Columns["Produto"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewVendas.Columns["Produto"].HeaderText = "Produto";
            }

            if (dataGridViewVendas.Columns["Quantidade"] != null)
            {
                dataGridViewVendas.Columns["Quantidade"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dataGridViewVendas.Columns["Quantidade"].HeaderText = "Qtd";
            }

            if (dataGridViewVendas.Columns["Preco"] != null)
            {
                dataGridViewVendas.Columns["Preco"].DefaultCellStyle.Format = "C2";
                dataGridViewVendas.Columns["Preco"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridViewVendas.Columns["Preco"].HeaderText = "Preço Unit.";
            }

            if (dataGridViewVendas.Columns["ValorTotal"] != null)
            {
                dataGridViewVendas.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
                dataGridViewVendas.Columns["ValorTotal"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
                dataGridViewVendas.Columns["ValorTotal"].HeaderText = "Total";
            }

            dataGridViewVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dataGridViewVendas.Columns["Produto"] != null)
                dataGridViewVendas.Columns["Produto"].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

            // Atualiza rodapé com totais
            if (relatorio.Count == 0)
            {
                lblResumo.Text = "Nenhuma venda encontrada no período.";
                lblResumo.ForeColor = Color.Gray;
            }
            else
            {
                int totalItens = relatorio.Sum(r => r.Quantidade);
                decimal totalGeral = relatorio.Sum(r => r.ValorTotal);
                int totalVendas = relatorio.Count;

                lblResumo.Text =
                    $"{totalVendas} venda(s)  •  {totalItens} item(ns) vendido(s)  •  Total: {totalGeral:C2}";
                lblResumo.ForeColor = Color.FromArgb(27, 94, 32);
            }
        }

        private void RelatorioVendasForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
