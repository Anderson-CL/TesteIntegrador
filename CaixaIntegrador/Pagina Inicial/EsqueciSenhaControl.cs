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
        }

        private async void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
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
                // Roda em background para não travar a UI
                bool encontrado = await Task.Run(() =>
                    ServicoDeRecuperacao.SolicitarRecuperacao(email));

                if (!encontrado)
                {
                    // ⚠️ Segurança: não revelar se email existe ou não
                    MostrarMensagem("Se o email existir, o código será enviado.", true);
                }
                else
                {
                    MostrarMensagem("Código enviado! Verifique seu email.", true);
                }

                // Aguarda 1,5s e avança para a tela de verificação
               // await Task.Delay(1500);
               // this.Invoke((Action)(() =>
               //     principal.MostrarVerificacaoCodigo(email))); 
            }
            catch (Exception ex)
            {
                MostrarMensagem("Erro ao enviar email: " + ex.Message, false);
                btnEnviarCodigo.Enabled = true;
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
    }
}
}
