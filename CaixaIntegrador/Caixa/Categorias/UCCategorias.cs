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
            //Button btnw = new Button();
            //btnw.Enabled = false;
            //btnw.BackColor = Color.Red;
            //btnw.Width = 120;
            //btnw.Height = 120;
            //FlowCategorias.Controls.Add(btnw);

            //Foreach para criar botões automaticamente
            foreach (var cat in categorias)
            {
               Guna2Button btn = new Guna2Button();
                btn.Text = cat.Nome;
                btn.Width = 120;
                btn.Height = 120;
                btn.Font = new Font("Roboto", 12    , FontStyle.Regular);
                btn.BorderRadius = 8;
                btn.BorderThickness = 2;
                btn.Animated = true;
                btn.FillColor = Color.FromArgb(183, 28, 28);
                btn.ShadowDecoration.Enabled = false;
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
