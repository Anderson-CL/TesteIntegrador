using CaixaIntegrador.Data;
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
    public partial class RelatorioVendasForm : Form
    {
        public RelatorioVendasForm()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var inicio = dtInicio.Value.Date;
                var fim = dtFim.Value.Date;

                var relatorio = context.Vendas
                    .Where(v => v.DataVenda >= inicio && v.DataVenda <= fim)
                    .Join(context.Produtos,
                          v => v.ProdutoId,
                          p => p.Id,
                          (v, p) => new
                          {
                              v.DataVenda,
                              Produto = p.Nome,
                              v.Quantidade,
                              p.Preco,
                              ValorTotal = v.Quantidade * p.Preco
                          })
                    .OrderBy(r => r.DataVenda)
                    .ToList();

                dataGridViewVendas.DataSource = relatorio;
            }
        }
    }
}
