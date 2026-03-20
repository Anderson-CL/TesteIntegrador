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
    using CaixaIntegrador.Classes;
    using Guna.UI2.WinForms;

    public partial class UCCategorias : UserControl
    {
    
    public event Action<int> CategoriaSelecionada;
        //Método para chamar a lista de Categoria
        public void CarregarCategorias(List<Categoria> categorias)
        {
            //Limpar controles
            FlowCategorias.Controls.Clear();
            // botão invisivel para manter o layout
            Button btnw = new Button();
            btnw.Enabled = false;
            btnw.BackColor = this.BackColor;
            btnw.Width = 120;
            btnw.Height = 120;
            FlowCategorias.Controls.Add(btnw);

            //Foreach para criar botões automaticamente
            foreach (var cat in categorias)
            {
               Guna2Button btn = new Guna2Button();
                btn.Text = cat.Nome;
                btn.Width = 120;
                btn.Height = 120;
                btn.Font = new Font("Arial Black", 12);
                btn.BorderRadius = 13;
                btn.BorderThickness = 2;
                btn.BorderColor = Color.Black;
                //Evento para o botão quando clicado
                btn.Click += (s, e) =>
                {
                    CategoriaSelecionada?.Invoke(cat.Id);
                };
                //Adiciona os botões crianos no painel
                FlowCategorias.Controls.Add(btn);
            }
        }

        public UCCategorias()
        {
            InitializeComponent();

        }

        private void FlowCategorias_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
