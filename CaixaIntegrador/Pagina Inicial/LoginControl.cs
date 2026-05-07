using CaixaIntegrador.Classes;
using CaixaIntegrador.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace CaixaIntegrador.Pagina_Inicial
{
    public partial class LoginControl : UserControl
    {
        private PaginaInicial principal;
        public LoginControl(PaginaInicial principal)
        {
            InitializeComponent();
          
            this.principal = principal;

            txtLogin.Hint = "Usuário ou Email";
            txtSenha.Hint = "Insira aqui sua senha";

        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Validação no banco SQLite
            using (var db = new AppDbContext())
            {
                if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string loginOuEmail = txtLogin.Text.Trim();
                    string senhaCriptografada = Criptografia.CriptografarSenha(txtSenha.Text.Trim());

                    var usuario = db.Usuarios.FirstOrDefault(u =>
                    (u.Login == loginOuEmail || u.Email == loginOuEmail)
                    && u.Senha == senhaCriptografada);

                    if (usuario != null)
                    {
                        MostrarMensagem("Login realizado com sucesso!", true);

                        // Aguarda 1 segundo antes de trocar de tela
                        Task.Delay(1000).ContinueWith(_ =>
                        {
                            this.Invoke((Action)(() => {
                                principal.UsuarioLogado = usuario.Login;
                                principal.MostrarTelaInicial();
                            }));
                        });
                    }
                    else
                    {
                        MostrarMensagem("Usuário ou senha incorretos", false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão ou consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            principal.MostrarRegistro();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void MostrarMensagem(string texto, bool sucesso)
        {
            lblMensagem1.Text = texto;

            lblMensagem1.ForeColor = sucesso
                ? MaterialSkin.MaterialSkinManager.Instance.ColorScheme.AccentColor
                 : Color.Red;

            lblMensagem1.Visible = true;
        }

        private void lblMensagem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == '●') // senha está oculta
            {
                txtSenha.PasswordChar = '\0'; // mostra senha
                olhinhoLogin.Image = Properties.Resources.olhar;
            }
            else
            {
                txtSenha.PasswordChar = '●'; // oculta senha
                olhinhoLogin.Image = Properties.Resources.OlharNo;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            olhinhoLogin.Visible = txtSenha.Text.Length > 0;
        }
    }
}
