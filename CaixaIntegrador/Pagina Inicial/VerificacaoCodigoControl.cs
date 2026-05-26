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
using MaterialSkin.Controls;

namespace CaixaIntegrador.Pagina_Inicial
{

    public partial class VerificacaoCodigoControl : UserControl
    {
        private PaginaInicial principal;
        private string emailRecuperacao;
        private MaterialTextBox[] _digitBoxes;

        public VerificacaoCodigoControl(PaginaInicial principal, string email)
        {
            InitializeComponent();
            this.principal = principal;
            this.emailRecuperacao = email;
            lblInfo.Text = $"Código enviado para: {email}";

            _digitBoxes = new MaterialTextBox[]
{
                txtCodigo1, txtCodigo2, txtCodigo3,
                txtCodigo4, txtCodigo5, txtCodigo6
};

            foreach (var tb in _digitBoxes)
            {
                tb.MaxLength = 1;
                //tb.TextAlign = HorizontalAlignment.Center;
                tb.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                tb.KeyDown += Digit_KeyDown;
                tb.TextChanged += Digit_TextChanged;
                tb.KeyPress += Digit_KeyPress;
            }

            txtCodigo1.Focus();
        }

        private void VerificacaoCodigoControl_Load(object sender, EventArgs e)
        {

        }

        // ── Eventos dos dígitos ────────────────────────────────────────

        private void Digit_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == (char)Keys.Back;
            bool isPaste = e.KeyChar == (char)22
                            && (ModifierKeys & Keys.Control) != 0;

            if (!isDigit && !isBackspace && !isPaste)
                e.Handled = true;
        }

        private void Digit_TextChanged(object sender, EventArgs e)
        {
            var tb = (MaterialTextBox)sender; // ← MaterialTextBox, não TextBox
            int idx = Array.IndexOf(_digitBoxes, tb);

            if (tb.Text.Length == 1 && idx < 5)
                _digitBoxes[idx + 1].Focus();
        }

        private void Digit_KeyDown(object sender, KeyEventArgs e)
        {
            var tb = (MaterialTextBox)sender; // ← MaterialTextBox, não TextBox
            int idx = Array.IndexOf(_digitBoxes, tb);

            if (e.KeyCode == Keys.Back && tb.Text.Length == 0 && idx > 0)
            {
                var prev = _digitBoxes[idx - 1];
                prev.Clear();
                prev.Focus();
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter && idx == 5)
                btnValidar_Click_1(this, EventArgs.Empty);

            if (e.Control && e.KeyCode == Keys.V)
            {
                string clip = Clipboard.GetText()
                    .Replace(" ", "").Trim();

                if (clip.Length == 6 && clip.All(char.IsDigit))
                {
                    for (int i = 0; i < 6; i++)
                        _digitBoxes[i].Text = clip[i].ToString();
                    _digitBoxes[5].Focus();
                }
                e.Handled = true;
            }
        }

        private string ObterCodigo() =>
            string.Concat(_digitBoxes.Select(t => t.Text));

        // ── Botões ─────────────────────────────────────────────────────

        private void btnVoltar_Click(object sender, EventArgs e) =>
            principal.MostrarLogin();

        private void MostrarMensagem(string texto, bool sucesso)
        {
            lblMensagem.Text = texto;
            lblMensagem.ForeColor = sucesso ? Color.DodgerBlue : Color.Red;
            lblMensagem.Visible = true;
        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {
            string codigo = ObterCodigo();

            if (codigo.Length != 6)
            {
                MostrarMensagem("O código deve ter 6 dígitos.", false);
                return;
            }

            bool valido = ServicoDeRecuperacao.ValidarCodigo(emailRecuperacao, codigo);

            if (valido)
            {
                MostrarMensagem("Código válido!", true);
                principal.MostrarRedefinirSenha(emailRecuperacao);
            }
            else
            {
                MostrarMensagem("Código inválido ou expirado. Tente novamente.", false);
                foreach (var tb in _digitBoxes) tb.Clear();
                txtCodigo1.Focus();
            }
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private async void btnReenviar_Click_1(object sender, EventArgs e)
        {
            btnReenviar.Enabled = false;
            MostrarMensagem("Reenviando código...", true);

            try
            {
                await ServicoDeRecuperacao.SolicitarRecuperacaoAsync(emailRecuperacao);
                MostrarMensagem("Novo código enviado!", true);
                foreach (var tb in _digitBoxes) tb.Clear();
                txtCodigo1.Focus();
            }
            catch
            {
                MostrarMensagem("Erro ao reenviar. Verifique sua conexão.", false);
            }
            finally
            {
                btnReenviar.Enabled = true;
            }
        }
    }
}
