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
                MessageBox.Show("Por favor, preencha todos os campos vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (senha.Length < 8)
            {
                MessageBox.Show("A senha tem menos de 8 caracteres, por favor crie outra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Este usuário já está registrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    MessageBox.Show("Registro feito com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    principal.MostrarLogin(); // volta para login
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            principal.MostrarLogin();
        }
    }
}
