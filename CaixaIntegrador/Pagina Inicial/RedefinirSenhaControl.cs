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

namespace CaixaIntegrador.Pagina_Inicial
{
    public partial class RedefinirSenhaControl : UserControl
    {
        private PaginaInicial principal;
        private string emailRecuperacao;

        public RedefinirSenhaControl(PaginaInicial principal, string email)
        {
            InitializeComponent();
            this.principal = principal;
            this.emailRecuperacao = email;
            txtNovaSenha.Hint = "Nova senha (mínimo 8 caracteres)";
            txtConfirmar.Hint = "Confirme a nova senha";
        }

        private void MostrarMensagem(string texto, bool sucesso)
        {
            lblMensagem.Text = texto;
            lblMensagem.ForeColor = sucesso ? Color.DodgerBlue : Color.Red;
            lblMensagem.Visible = true;
        }

        private async void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            if (novaSenha.Length < 8)
            {
                MostrarMensagem("A senha deve ter pelo menos 8 caracteres.", false);
                return;
            }

            if (novaSenha != confirmar)
            {
                MostrarMensagem("As senhas não coincidem.", false);
                return;
            }

            btnSalvar.Enabled = false;

            bool ok = ServicoDeRecuperacao.RedefinirSenha(emailRecuperacao, novaSenha);

            if (ok)
            {
                MostrarMensagem("Senha alterada com sucesso!", true);
                await Task.Delay(1500);
                this.Invoke((Action)(() => principal.MostrarLogin()));
            }
            else
            {
                MostrarMensagem("Erro ao salvar senha. Tente novamente.", false);
                btnSalvar.Enabled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) =>
        principal.MostrarLogin();
    }
}
