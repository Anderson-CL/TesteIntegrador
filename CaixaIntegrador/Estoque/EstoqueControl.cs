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
        }

        private void EstoqueControl_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

            dataGridView1.AutoGenerateColumns = true;

            using var db = new AppDbContext();
            cmbFiltrar.DataSource = db.Categorias.ToList();
            cmbFiltrar.DisplayMember = "Nome";   // o que aparece na lista
            cmbFiltrar.ValueMember = "Id";       // valor interno usado no filtro
        }



        private void btbBuscar_Click(object sender, EventArgs e)
        {
            string termo = txtBuscar.Text;
            dataGridView1.DataSource = controle.Buscar(termo);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var novo = new Produto
            {
                Nome = "Novo Produto",
                SubCategoriaId = 1, // exemplo
                Preco = 10.00M,
                Quantidade = 100
            };

            controle.Adicionar(novo);
            AtualizarGrid();
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controle.Listar();
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
    }
}
