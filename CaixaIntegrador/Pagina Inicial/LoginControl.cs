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
    public partial class LoginControl : UserControl
    {
        private PaginaInicial principal;
        public LoginControl(PaginaInicial principal)
        {
            InitializeComponent();
            this.principal = principal;
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
                    string login = txtLogin.Text.Trim();
                    string senhaCriptografada = Criptografia.CriptografarSenha(txtSenha.Text.Trim());

                    var usuario = db.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senhaCriptografada);

                    if (usuario != null)
                    {
                        MessageBox.Show("Login realizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        principal.CarregarCaixa(); // troca para tela de login ou menu inicial
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
