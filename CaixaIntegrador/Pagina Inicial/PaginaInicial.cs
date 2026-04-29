using CaixaIntegrador.Caixa;
using CaixaIntegrador.Pagina_Inicial;
using MaterialSkin;
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

namespace CaixaIntegrador
{
    public partial class PaginaInicial : MaterialForm
    {
        public string UsuarioLogado { get; set; }
        public PaginaInicial()
        {
            InitializeComponent();
            TemaFormSkin();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            MostrarLogin();
        }

        private void CentralizarControl(UserControl control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
            control.Top = (this.ClientSize.Height - control.Height) / 2;
        }

        public void MostrarLogin()
        {
            panelPrincipal.Controls.Clear();
            var login = new LoginControl(this);
            panelPrincipal.Controls.Add(login);
          // CentralizarControl(login);
            Anchor = AnchorStyles.None;
            //Dock = DockStyle.Fill;
        }

        public void MostrarRegistro()
        {
            panelPrincipal.Controls.Clear();
            var registro = new RegistroControl(this);
            panelPrincipal.Controls.Add(registro);
            CentralizarControl(registro);
        }

        public void CarregarCaixa()
        {
            panelPrincipal.Controls.Clear();
            var caixaControl = new CaixaControl();
            panelPrincipal.Controls.Add(caixaControl);
            CentralizarControl(caixaControl);
           
        }

        public void MostrarTelaInicial()
        {
            panelPrincipal.Controls.Clear();
            var telaInicial = new TelaInicialControl(this);
            panelPrincipal.Controls.Add(telaInicial);
            CentralizarControl(telaInicial);
           
        }

        public void CarregarEstoque()
        {
            panelPrincipal.Controls.Clear();
            var estoqueControl = new Estoque.EstoqueControl();
            panelPrincipal.Controls.Add(estoqueControl);
            CentralizarControl(estoqueControl);
        }


        public void CarregarRelatorio() //Dessa forma o relatório abre em uma janela separada, sem substituir o conteúdo do painel principal
        {
            var relatorio = new Relatorios.RelatorioVendasForm();
            relatorio.Show(); // abre como janela separada
        }

        /*
         
         
        public void CarregarRelatorio() //Dessa forma o relatório é carregado dentro do painel principal, substituindo o conteúdo atual
        {
            panelPrincipal.Controls.Clear();
            var relatorio = new Relatorios.RelatorioVendasForm();
            relatorio.TopLevel = false;          // importante: não será janela independente
            relatorio.FormBorderStyle = FormBorderStyle.None;
            relatorio.Dock = DockStyle.Fill;     // ocupa todo o painel
            panelPrincipal.Controls.Add(relatorio);
            relatorio.Show();
        }
        
         */

        private void TemaFormSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900,    // Cor Principal: Vinho bem escuro (fundo de botões/barras)
                Primary.BlueGrey900, // Tom de contraste profundo para barras de título
                Primary.Red600,    // Tom médio para destaques suaves
                Accent.Blue700,
                TextShade.WHITE    // Texto branco puro
            );
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
