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

            barProgresso.Minimum = 0;
            barProgresso.Maximum = 100;
            barProgresso.Value = 0;


            txtNovaSenha.KeyDown += txtCampos_KeyDown;
            txtConfirmar.KeyDown += txtCampos_KeyDown;

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

            MostrarMensagem("Salvando...", true);


            barProgresso.Value = 0;

            for (int i = 0; i <= 100; i += 10)
            {
                barProgresso.Value = i;
                await Task.Delay(100); // controla velocidade da barra
            }

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

        private void barProgresso_Click(object sender, EventArgs e)
        {

        }


        private void txtCampos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txtNovaSenha)
                {
                    txtConfirmar.Focus();
                }
                else
                {
                    btnSalvar_Click_1(this, EventArgs.Empty);
                }

                e.SuppressKeyPress = true;
            }
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            picNovaSenha.Visible = txtNovaSenha.Text.Length > 0;
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            picConfirmar.Visible = txtConfirmar.Text.Length > 0;
        }

        private void picNovaSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.PasswordChar != '\0') // senha está oculta
            {
                txtNovaSenha.PasswordChar = '\0'; // mostra senha
                picNovaSenha.Image = Properties.Resources.Olhar;
            }
            else
            {
                txtNovaSenha.PasswordChar = '●'; // oculta senha
                picNovaSenha.Image = Properties.Resources.OlharNo;
            }
        }

        private void picConfirmar_Click(object sender, EventArgs e)
        {
            if (txtConfirmar.PasswordChar != '\0') // senha está oculta
            {
                txtConfirmar.PasswordChar = '\0'; // mostra senha
                picConfirmar.Image = Properties.Resources.Olhar;
            }
            else
            {
                txtConfirmar.PasswordChar = '●'; // oculta senha
                picConfirmar.Image = Properties.Resources.OlharNo;
            }
        }

        private void txtConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void txtNovaSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
