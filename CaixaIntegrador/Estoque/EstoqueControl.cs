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

        public EstoqueControl()
        {
            InitializeComponent();
            txtBuscar.Hint = "Digite aqui!";
            txtQuantidade.Hint = "Nova Qantidade";
        }

        private void EstoqueControl_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            dataGridView1.AutoGenerateColumns = true;

            using var db = new AppDbContext();
            cmbFiltrar.DataSource = db.Categorias.ToList();
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.ReadOnly = true;

            cmbFiltrar.DisplayMember = "Nome";   // o que aparece na lista
            cmbFiltrar.ValueMember = "Id";       // valor interno usado no filtro
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //  dataGridView1.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["preco"].DefaultCellStyle.Format = "C2";
        }



        private void btbBuscar_Click(object sender, EventArgs e)
        {
            string termo = txtBuscar.Text;
            dataGridView1.DataSource = controle.Buscar(termo);
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
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                controle.Remover(id);
                AtualizarGrid();
            }
        }

        private void AtualizarGrid()
        {

            using var db = new AppDbContext();

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

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dados;

        }

        private void BtnAtualizarQtd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                int novaQtd = Convert.ToInt32(txtQuantidade.Text);

                controle.AtualizarQuantidade(id, novaQtd);
                AtualizarGrid();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedValue != null)
            {
                int categoriaId = (int)cmbFiltrar.SelectedValue;
                dataGridView1.DataSource = controle.ListarPorCategoria(categoriaId);
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
    }
}
