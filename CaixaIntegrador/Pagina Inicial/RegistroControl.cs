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

namespace CaixaIntegrador.Pagina_Inicial
{
    public partial class RegistroControl : UserControl
    {
        private PaginaInicial principal;
        public RegistroControl(PaginaInicial principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string login = txtRegistroLogin.Text.Trim();
            string senha = txtRegistroSenha1.Text.Trim();
            string confirmarSenha = txtRegistroSenha2.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha))
            {
                MostrarMensagem("Por favor, preencha todos os campos vazios", false);
                return;
            }
            else if (senha != confirmarSenha)
            {
                MostrarMensagem("As senhas não coincidem!", false);
                return;
            }
            else if (senha.Length < 8)
            {
                MostrarMensagem("A senha tem menos de 8 caracteres, por favor crie outra", false);
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    // Verifica se já existe usuário com esse login
                    var existente = db.Usuarios.FirstOrDefault(u => u.Login == login);
                    if (existente != null)
                    {
                        MostrarMensagem("Este usuário já está registrado!", false);
                        return;
                    }

                    // Criptografa a senha
                    string senhaCriptografada = Criptografia.CriptografarSenha(senha);

                    var usuario = new Usuario
                    {
                        Login = login,
                        Senha = senhaCriptografada,
                        Privilegio = "Admin",
                        Status = "Ativo",
                        Data = DateTime.Now
                    };

                    db.Usuarios.Add(usuario);
                    db.SaveChanges();

                    MostrarMensagem("Registro feito com sucesso!", true);

                    // Aguarda 1 segundo antes de voltar para login
                    Task.Delay(1000).ContinueWith(_ =>
                    {
                        this.Invoke((Action)(() => principal.MostrarLogin()));
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMensagem(string texto, bool sucesso)
        {
            lblMensagemRegistro.Text = texto;
            lblMensagemRegistro.ForeColor = sucesso ? Color.Green : Color.Red;
            lblMensagemRegistro.Visible = true;
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.MostrarLogin();
        }

        private void txtRegistroLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistro_Click(sender, e);
            }
        }

        private void txtRegistroSenha1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistro_Click(sender, e);
            }
        }

        private void txtRegistroSenha2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistro_Click(sender, e);
            }
        }

        private void olinhoRegistro1_Click(object sender, EventArgs e)
        {
            if (txtRegistroSenha1.PasswordChar == '●') // senha está oculta
            {
                txtRegistroSenha1.PasswordChar = '\0'; // mostra senha
                olinhoRegistro1.Image = Properties.Resources.olhar;
            }
            else
            {
                txtRegistroSenha1.PasswordChar = '●'; // oculta senha
                olinhoRegistro1.Image = Properties.Resources.OlharNo;
            }
        }

        private void olhinhoRegistro2_Click(object sender, EventArgs e)
        {
            if (txtRegistroSenha2.PasswordChar == '●') // senha está oculta
            {
                txtRegistroSenha2.PasswordChar = '\0'; // mostra senha
                olhinhoRegistro2.Image = Properties.Resources.olhar;
            }
            else
            {
                txtRegistroSenha2.PasswordChar = '●'; // oculta senha
                olhinhoRegistro2.Image = Properties.Resources.OlharNo;
            }

        }

        private void txtRegistroSenha1_TextChanged(object sender, EventArgs e)
        {
            olinhoRegistro1.Visible = txtRegistroSenha1.Text.Length > 0;
        }

        private void txtRegistroSenha2_TextChanged(object sender, EventArgs e)
        {
            olhinhoRegistro2.Visible = txtRegistroSenha2.Text.Length > 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRegistroLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
