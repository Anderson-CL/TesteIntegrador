using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador.Pagina_Inicial
{
    public partial class TelaInicialControl : UserControl
    {
        private PaginaInicial principal;

        public TelaInicialControl(PaginaInicial principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            principal.CarregarEstoque();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            principal.CarregarCaixa();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            principal.CarregarRelatorio();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicialControl_Load(object sender, EventArgs e)
        {
            // Estilização já feita no Designer
            lblTitulo.Text = "Adega do Alemão";

            string usuarioLogado = principal?.UsuarioLogado ?? "Usuário";
            lblSaudacao.Text = $"Bem-vindo, {usuarioLogado}";

            lblVersao.Text = "Versão 1.0";
            lblData.Text = "Hoje: " + DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
        }

        private void btnSair_CheckedChanged(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
