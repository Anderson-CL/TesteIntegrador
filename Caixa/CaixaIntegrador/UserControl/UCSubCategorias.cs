using CaixaIntegrador.Classes;
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
    public partial class UCSubCategorias : UserControl
    {
        public event Action<int> SubCategoriaSelecionada;
        public event Action VoltarClick;

        public void CarregarSubCategorias(List<SubCategoria> lista)
        {
            FlowSubCategorias.Controls.Clear();
            FlowSubCategorias.Controls.Add(btnVoltar);

            foreach (var sub in lista)
            {
                Button btn = new Button();
                btn.Text = sub.Nome;
                btn.Width = 120;
                btn.Height = 120;
                btn.Font = new Font("Arial", 15);

                btn.Click += (s, e) =>
                {
                    SubCategoriaSelecionada?.Invoke(sub.Id);
                };

                FlowSubCategorias.Controls.Add(btn);
            }
        }

        public UCSubCategorias()
        {
            InitializeComponent();
        }

        private void SubCategorias_Load(object sender, EventArgs e)
        {

        }
        //Linka o botão com a ação de voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarClick?.Invoke();
        }
    }
}
