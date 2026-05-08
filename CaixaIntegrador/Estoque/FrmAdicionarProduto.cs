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
    public partial class FrmAdicionarProduto : MaterialForm
    {
        public Produto ProdutoCriado { get; private set; }

        public FrmAdicionarProduto()
        {
            InitializeComponent();
            CarregarSubCategorias();
        }

        private void CarregarSubCategorias()
        {

            using var db = new AppDbContext();
            cmbSubCategoria.DataSource = db.SubCategorias.ToList();
            cmbSubCategoria.DisplayMember = "Nome";
            cmbSubCategoria.ValueMember = "Id";

        }

        private void cbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto");
                return;
            }

            ProdutoCriado = new Produto
            {
                Nome = txtNome.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Quantidade = int.Parse(txtQuantidade.Text),
                SubCategoriaId = (int)cmbSubCategoria.SelectedValue
            };

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void nudPreco1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudQuantidade1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
