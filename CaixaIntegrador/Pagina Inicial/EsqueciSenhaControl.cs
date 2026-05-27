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
    public partial class EsqueciSenhaControl : UserControl
    {
        private PaginaInicial principal;

        public EsqueciSenhaControl(PaginaInicial principal)
        {
            InitializeComponent();
            this.principal = principal;
            txtEmail.Hint = "Digite seu email cadastrado";

            txtEmail.KeyDown += txtEmail_KeyDown;
        }

        private bool enviando = false; 

        private async void btnEnviarCodigo_Click(object sender, EventArgs e)
        {

            if (enviando) return; // ✅ bloqueia duplicação
            enviando = true;

            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MostrarMensagem("Informe um email válido.", false);
                return;
            }

            btnEnviarCodigo.Enabled = false;
            MostrarMensagem("Enviando código...", true);

            try
            {
                bool encontrado = await ServicoDeRecuperacao.SolicitarRecuperacaoAsync(email);

                // Resposta genérica por segurança (não revela se email existe)
                MostrarMensagem("Se o email existir, o código será enviado.", true);

                await Task.Delay(1500);

                // Avança para verificação independente — o usuário saberá se chegou ou não
                principal.MostrarVerificacaoCodigo(email);
            }
            catch (Exception ex)
            {
                MostrarMensagem("Erro ao enviar email: " + ex.Message, false);
                btnEnviarCodigo.Enabled = true;
            }

            finally
            {
                enviando = false; // ✅ libera novamente
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e) =>
            principal.MostrarLogin();

        private void MostrarMensagem(string texto, bool sucesso)
        {
            lblMensagem.Text = texto;
            lblMensagem.ForeColor = sucesso ? Color.DodgerBlue : Color.Red;
            lblMensagem.Visible = true;
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnEnviarCodigo_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }

        }

        private void EsqueciSenhaControl_Load(object sender, EventArgs e)
        {

        }
    }
}
