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
            this.Load += FrmAdicionarProduto_Load;
        }
        private void FrmAdicionarProduto_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            using var db = new AppDbContext();
            var categorias = db.Categorias.ToList();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            //Carrega as subcategorias
            if (cmbCategoria.SelectedValue != null)
                FiltrarSubCategorias((int)cmbCategoria.SelectedValue);
        }

        private void cbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validações

            //Nome
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto");
                return;
            }

            //Preço
            if (!decimal.TryParse(txtPreco.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal preco) || preco < 0)
            {
                MessageBox.Show("Informe um preço válido (ex: 9,90).", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            //Quantidade
            /*if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 0)
            {
                MessageBox.Show("Informe uma quantidade válida (número inteiro positivo).", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }*/

            //Subcategoria
            if (cmbSubCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma subcategoria.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Criação do Produto
            ProdutoCriado = new Produto
            {
                Nome = txtNome.Text.Trim(),
                Preco = preco,
                //Quantidade = qtd,
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


        private void FiltrarSubCategorias(int categoriaId)
        {
            using var db = new AppDbContext();
            var subs = db.SubCategorias
                         .Where(s => s.CategoriaId == categoriaId)
                         .ToList();

            cmbSubCategoria.DataSource = subs;
            cmbSubCategoria.DisplayMember = "Nome";
            cmbSubCategoria.ValueMember = "Id";
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem is Categoria cat)
                FiltrarSubCategorias(cat.Id);
        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {

        }
    }
}
