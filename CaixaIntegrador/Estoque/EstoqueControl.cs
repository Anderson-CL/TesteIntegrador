using CaixaIntegrador.Classes;
using CaixaIntegrador.Data;
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
    public partial class EstoqueControl : UserControl
    {
        private ControleEstoque controle = new ControleEstoque();
        public event Action VoltarClick;

        public EstoqueControl()
        {
            InitializeComponent();
            txtBuscar.Hint = "Digite aqui!";
        }

        private void EstoqueControl_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarCategorias();
            AtualizarGrid();
        }

        private void ConfigurarGrid()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowPostPaint += ColorirLinhasEstoqueBaixo;
        }

        // linha inteira vermelho claro se Quantidade == 0
        private void ColorirLinhasEstoqueBaixo(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var cell = row.Cells["Quantidade"];

            if (cell?.Value != null && Convert.ToInt32(cell.Value) == 0)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200); // vermelho claro
                row.DefaultCellStyle.ForeColor = Color.DarkRed;
            }
            else
            {
                row.DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            }
        }

        private void CarregarCategorias()
        {
            using var db = new AppDbContext();
            cmbFiltrar.DataSource = db.Categorias.ToList();
            cmbFiltrar.DisplayMember = "Nome";
            cmbFiltrar.ValueMember = "Id";
        }

        private void CarregarDados(IQueryable<Produto> fonte = null)
        {
            using var db = new AppDbContext();

            var query = fonte ?? db.Produtos;

            var dados = db.Produtos
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    SubCategoria = p.SubCategoria.Nome,
                    Categoria = p.SubCategoria.Categoria.Nome,
                    p.Preco,
                    p.Quantidade
                })
                .ToList();

            AplicarDadosNoGrid(dados.Cast<object>().ToList());
        }

        private void btbBuscar_Click(object sender, EventArgs e)
        {
            string termo = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termo))
            {
                AtualizarGrid();
                return;
            }

            using var db = new AppDbContext();

            var dados = db.Produtos
                .Where(p => p.Nome.Contains(termo))
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    SubCategoria = p.SubCategoria.Nome,
                    Categoria = p.SubCategoria.Categoria.Nome,
                    p.Preco,
                    p.Quantidade
                })
                .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dados;

            FormatarColunas();

        }

        private void FormatarColunas()
        {
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns["Nome"] != null)
                dataGridView1.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridView1.Columns["Preco"] != null)
                dataGridView1.Columns["Preco"].DefaultCellStyle.Format = "C2";

            if (dataGridView1.Columns["Quantidade"] != null)
                dataGridView1.Columns["Quantidade"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dataGridView1.Columns["Nome"] != null)
                dataGridView1.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void AplicarDadosNoGrid(System.Collections.Generic.List<object> dados) 
        {
        
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            using (var form = new FrmAdicionarProduto())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    controle.Adicionar(form.ProdutoCriado);

                    AtualizarGrid();

                }
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um produto para remover.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nome = dataGridView1.CurrentRow.Cells["Nome"].Value?.ToString();
                var confirm = MessageBox.Show(
                    $"Deseja remover o produto \"{nome}\"?",
                    "Confirmar remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    controle.Remover(id);
                    AtualizarGrid();
                }

            }
        }

        private void AtualizarGrid()
        {

            using var db = new AppDbContext();

            // O Select projeta strings — nunca objetos — para o grid
            var dados = db.Produtos
                .Select(p => new
                {
                    p.Id,
                    p.Nome,
                    SubCategoria = p.SubCategoria.Nome,          // string, não objeto
                    Categoria = p.SubCategoria.Categoria.Nome, // string, não objeto
                    p.Preco,
                    p.Quantidade
                })
                .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dados;

            FormatarColunas();
        }

        private void BtnAtualizarQtd_Click(object sender, EventArgs e)
        {
            /* if (dataGridView1.CurrentRow == null)
             {
                 MessageBox.Show("Selecione um produto.", "Atenção",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             if (!int.TryParse(txtQuantidade.Text, out int novaQtd) || novaQtd < 0)
             {
                 MessageBox.Show("Informe uma quantidade válida.", "Atenção",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 txtQuantidade.Focus();
                 return;
             }

             int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
             controle.AtualizarQuantidade(id, novaQtd);
             AtualizarGrid();
            */
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedValue != null)
            {
                if (cmbFiltrar.SelectedItem is not Categoria cat) return;

                using var db = new AppDbContext();

                var dados = db.Produtos
                    .Where(p => p.SubCategoria.CategoriaId == cat.Id)
                    .Select(p => new
                    {
                        p.Id,
                        p.Nome,
                        SubCategoria = p.SubCategoria.Nome,
                        Categoria = p.SubCategoria.Categoria.Nome,
                        p.Preco,
                        p.Quantidade
                    })
                    .ToList();

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dados;

                FormatarColunas();
            }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarClick?.Invoke();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para editar.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            using var form = new FrmEditarProduto(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                controle.Editar(form.ProdutoEditado);
                AtualizarGrid();
            }
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para movimentar.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            string nome = dataGridView1.CurrentRow.Cells["Nome"].Value?.ToString();
            int qtdAtual = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantidade"].Value);

            using var form = new FrmMovimentacao(id, nome, qtdAtual);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AtualizarGrid(); // Atualiza o grid após a movimentação
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para ver o histórico.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            using var form = new FrmHistorico(id);
            form.ShowDialog();
        }
    }
}
