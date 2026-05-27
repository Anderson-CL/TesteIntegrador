namespace CaixaIntegrador.Pagina_Inicial
{
    partial class EsqueciSenhaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            btnEnviarCodigo = new MaterialSkin.Controls.MaterialButton();
            btnVoltar = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            lblMensagem = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(118, 172);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(352, 48);
            txtEmail.TabIndex = 0;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.Click += txtEmail_Click;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnviarCodigo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnviarCodigo.Depth = 0;
            btnEnviarCodigo.HighEmphasis = true;
            btnEnviarCodigo.Icon = null;
            btnEnviarCodigo.Location = new Point(260, 235);
            btnEnviarCodigo.Margin = new Padding(4);
            btnEnviarCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.NoAccentTextColor = Color.Empty;
            btnEnviarCodigo.Size = new Size(210, 36);
            btnEnviarCodigo.TabIndex = 1;
            btnEnviarCodigo.Text = "Enviar código por email";
            btnEnviarCodigo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnviarCodigo.UseAccentColor = false;
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.Location = new Point(118, 235);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(77, 36);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVoltar.UseAccentColor = false;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(118, 92);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(352, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Informe o email cadastrado para receber o código";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(212, 52);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(162, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Redefinir Minha Senha";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Depth = 0;
            lblMensagem.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMensagem.Location = new Point(194, 133);
            lblMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(1, 0);
            lblMensagem.TabIndex = 6;
            lblMensagem.Click += materialLabel4_Click;
            // 
            // EsqueciSenhaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMensagem);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(btnVoltar);
            Controls.Add(btnEnviarCodigo);
            Controls.Add(txtEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EsqueciSenhaControl";
            Size = new Size(630, 360);
            Load += EsqueciSenhaControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialButton btnEnviarCodigo;
        private MaterialSkin.Controls.MaterialButton btnVoltar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblMensagem;
    }
}
