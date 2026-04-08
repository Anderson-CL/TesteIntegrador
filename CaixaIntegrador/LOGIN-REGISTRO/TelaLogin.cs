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

namespace CaixaIntegrador.LOGIN_REGISTRO
{
    public partial class TelaLogin : Form
    {
        private bool MostrarSenha = false;

        private MySqlConnection Conexao;
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por favor, Preencha todos os campos!", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string data_source = "datasource=localhost;username=root;password=;database=bd_adega";

                    using (Conexao = new MySqlConnection(data_source))
                    {
                        Conexao.Open();

                        string selectData = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";

                        using (MySqlCommand comando = new MySqlCommand(selectData, Conexao))
                        {
                            comando.Parameters.AddWithValue("@login", txtLogin.Text.Trim());


                            string senhaCriptografada =
                                    Criptografia.CriptografarSenha(txtSenha.Text.Trim());


                            comando.Parameters.AddWithValue("@senha", senhaCriptografada);

                            MySqlDataAdapter adaptacao = new MySqlDataAdapter(comando);
                            DataTable table = new DataTable();
                            adaptacao.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Login realizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                Form1 Caixa = new Form1();
                                Caixa.ShowDialog();

                                Application.Exit();

                            }
                            else
                            {
                                MessageBox.Show("Usuário ou Senha incorretos", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão ou consulta: " + ex.Message, "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

            this.Hide();
            TelaRegistro RegistroForm = new TelaRegistro();
            RegistroForm.ShowDialog();

            this.Show();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {


            txtSenha.UseSystemPasswordChar = true;

            MostrarOcultar.Visible = false;



        }

        private void MostrarOcultar_Click(object sender, EventArgs e)
        {

            {
                MostrarSenha = !MostrarSenha;

                txtSenha.UseSystemPasswordChar = !MostrarSenha;
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            MostrarOcultar.Visible = txtSenha.TextLength > 0;
            if (txtSenha.TextLength == 0)
            {
                MostrarSenha = false;
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
