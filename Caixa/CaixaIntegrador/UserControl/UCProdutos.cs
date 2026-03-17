using CaixaIntegrador.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador
{
    public partial class UCProdutos : UserControl
    {
        public UCProdutos()
        {
            InitializeComponent();
        }
        public event Action<Produto> ProdutoSelecionado;
        public event Action VoltarClick;

        public void CarregarProdutos(List<Produto> produtos)
        {
            FlowProdutos.Controls.Clear();
            FlowProdutos.Controls.Add(btnVoltar);
            foreach (var prod in produtos)
           
            {
                Guna2Button btn = new Guna2Button();
                btn.Text = prod.Nome;
                btn.Width = 120;
                btn.Height = 120;
                btn.Font = new Font("Arial Black", 12);
                btn.BorderRadius = 13;
                btn.BorderThickness = 2;
                btn.BorderColor = Color.Black;

                btn.Click += (s, e) =>
                {
                    ProdutoSelecionado?.Invoke(prod);
                };

                FlowProdutos.Controls.Add(btn);
            }
        }
        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void FlowProdutos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarClick?.Invoke();
        }
    }
}
