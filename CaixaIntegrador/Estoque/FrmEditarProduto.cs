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
    public partial class FrmEditarProduto : MaterialForm
    {
        public Produto ProdutoEditado { get; private set; }

        private readonly int _produtoId;

        public FrmEditarProduto(int produtoId)
        {
            InitializeComponent();
            _produtoId = produtoId;
        }

        private void CarregarCategorias()
        {
            using var db = new AppDbContext();
            var categorias = db.Categorias.ToList();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
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

        private void PreencherCampos()
        {
            using var db = new AppDbContext();
            var produto = db.Produtos.Find(_produtoId);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Busca a categoria pai da subcategoria do produto
            var sub = db.SubCategorias.Find(produto.SubCategoriaId);
            var catId = sub?.CategoriaId ?? 0;

            // Seleciona a categoria correta
            // SelectedIndexChanged e carrega as subcategorias
            cmbCategoria.SelectedValue = catId;

            // seleciona a subcategoria correta
            cmbSubCategoria.SelectedValue = produto.SubCategoriaId;

            txtNome.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString("F2");
            txtQuantidade.Text = produto.Quantidade.ToString();


        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
                FiltrarSubCategorias((int)cmbCategoria.SelectedValue);
        }

        private void cmbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

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

            if (!int.TryParse(txtQuantidade.Text, out int qtd) || qtd < 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            if (cmbSubCategoria.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma subcategoria.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProdutoEditado = new Produto
            {
                Id = _produtoId,
                Nome = txtNome.Text.Trim(),
                Preco = preco,
                Quantidade = qtd,
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
    }
}
