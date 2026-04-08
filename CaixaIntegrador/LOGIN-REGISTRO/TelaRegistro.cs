using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaIntegrador.LOGIN_REGISTRO;

namespace CaixaIntegrador.LOGIN_REGISTRO
{

    public partial class TelaRegistro : Form
    {
        private bool MostrarSenha1 = false;
        private bool MostrarSenha2 = false;

        MySqlConnection Conexao;
        public TelaRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            if (txtRegistroLogin.Text == "" || txtRegistroSenha1.Text == "" || txtRegistroSenha2.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos vazios", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRegistroSenha1.Text != txtRegistroSenha2.Text)
            {
                MessageBox.Show("As Senhas não coincidem!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRegistroSenha1.Text.Length < 8)
            {
                MessageBox.Show("A senha tem menos de 8 caracteres, por favor crie outra", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checarConexao())
                {
                    try
                    {
                        string data_source = "datasource=localhost;username=root;password=;database=bd_adega";

                        using (Conexao = new MySqlConnection(data_source))
                        {
                            Conexao.Open();

                            // Verificar se o login já existe
                            string VerificarUsuario = "SELECT COUNT(*) FROM usuarios WHERE login = @login";
                            using (MySqlCommand verificarComando = new MySqlCommand(VerificarUsuario, Conexao))
                            {
                                verificarComando.Parameters.AddWithValue("@login", txtRegistroLogin.Text.Trim());
                                int usuarioExistente = Convert.ToInt32(verificarComando.ExecuteScalar());

                                if (usuarioExistente > 0)
                                {
                                    MessageBox.Show("Este usuário já está registrado!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            // Inserir novo usuário
                            string InserirDados = "INSERT INTO usuarios (login, senha, privilegio, status, data) " +
                                                  "VALUES (@login, @senha, @privilegio, @status, @data)";

                            using (MySqlCommand comando = new MySqlCommand(InserirDados, Conexao))
                            {
                                comando.Parameters.AddWithValue("@login", txtRegistroLogin.Text.Trim());

                                // Criptografar senha

                                string senhaCriptografada = Criptografia.CriptografarSenha(
                                    txtRegistroSenha1.Text.Trim()
                                );


                                // Antigo sem Criptografia
                                // comando.Parameters.AddWithValue("@senha", txtRegistroSenha1.Text.Trim());

                                comando.Parameters.AddWithValue("@senha", senhaCriptografada);
                                comando.Parameters.AddWithValue("@privilegio", "Admin");
                                comando.Parameters.AddWithValue("@status", "Ativo");
                                comando.Parameters.AddWithValue("@data", DateTime.Now);

                                int LinhasAfetadas = comando.ExecuteNonQuery(); 

                                if (LinhasAfetadas > 0)
                                {
                                    MessageBox.Show("Registro Feito com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao registrar, Tente novamente!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public bool checarConexao()
        {
            return Conexao == null || Conexao.State == ConnectionState.Closed;
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void MostrarOcultar1_Click(object sender, EventArgs e)
        {
            MostrarSenha1 = !MostrarSenha1;

            txtRegistroSenha1.UseSystemPasswordChar = !MostrarSenha1;

            MostrarOcultar1.Image = MostrarSenha1
                ? Properties.Resources.invisivel
                : Properties.Resources.visivel;
        }

        private void MostrarOcultar2_Click(object sender, EventArgs e)
        {
            MostrarSenha2 = !MostrarSenha2;

            txtRegistroSenha2.UseSystemPasswordChar = !MostrarSenha2;

            MostrarOcultar2.Image = MostrarSenha2
                ? Properties.Resources.invisivel
                : Properties.Resources.visivel;
        }

        private void txtRegistroSenha1_TextChanged(object sender, EventArgs e)
        {
            MostrarOcultar1.Visible = txtRegistroSenha1.TextLength > 0;
            if (txtRegistroSenha1.TextLength == 0)
            {
                MostrarSenha1 = false;
                txtRegistroSenha1.UseSystemPasswordChar = true;
                MostrarOcultar1.Image = Properties.Resources.visivel;
            }
        }

        private void txtRegistroSenha2_TextChanged(object sender, EventArgs e)
        {
            MostrarOcultar2.Visible = txtRegistroSenha2.TextLength > 0;
            if (txtRegistroSenha2.TextLength == 0)
            {
                MostrarSenha2 = false;
                txtRegistroSenha2.UseSystemPasswordChar = true;
                MostrarOcultar2.Image = Properties.Resources.visivel;
            }
        }

        private void TelaRegistro_Load(object sender, EventArgs e)
        {

            txtRegistroSenha1.UseSystemPasswordChar = true;
            txtRegistroSenha2.UseSystemPasswordChar = true;

            MostrarOcultar1.Visible = false;
            MostrarOcultar2.Visible = false;

            MostrarOcultar1.Image = Properties.Resources.visivel;
            MostrarOcultar2.Image = Properties.Resources.visivel;

        }
    }
}
