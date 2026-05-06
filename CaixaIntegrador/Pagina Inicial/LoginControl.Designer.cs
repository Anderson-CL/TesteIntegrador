namespace CaixaIntegrador.Pagina_Inicial
{
    partial class LoginControl
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            olhinhoLogin = new PictureBox();
            lblMensagem = new PictureBox();
            txtSenha = new MaterialSkin.Controls.MaterialTextBox2();
            txtLogin = new MaterialSkin.Controls.MaterialTextBox2();
            lblRegistro = new MaterialSkin.Controls.MaterialLabel();
            lblEsqueceu = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnEntrar = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            lblMensagem1 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)olhinhoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblMensagem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Mascote_elegante_par;
            pictureBox4.Location = new Point(260, 0);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(220, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.face_13896971;
            pictureBox3.Location = new Point(195, 195);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // olhinhoLogin
            // 
            olhinhoLogin.Image = Properties.Resources.OlharNo;
            olhinhoLogin.Location = new Point(486, 248);
            olhinhoLogin.Margin = new Padding(3, 2, 3, 2);
            olhinhoLogin.Name = "olhinhoLogin";
            olhinhoLogin.Size = new Size(42, 36);
            olhinhoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            olhinhoLogin.TabIndex = 17;
            olhinhoLogin.TabStop = false;
            olhinhoLogin.Visible = false;
            olhinhoLogin.Click += pictureBox2_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.Image = Properties.Resources.cadeado;
            lblMensagem.Location = new Point(195, 248);
            lblMensagem.Margin = new Padding(3, 2, 3, 2);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(42, 36);
            lblMensagem.SizeMode = PictureBoxSizeMode.Zoom;
            lblMensagem.TabIndex = 16;
            lblMensagem.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(260, 248);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(220, 36);
            txtSenha.TabIndex = 15;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            txtSenha.UseTallSize = false;
            txtSenha.KeyDown += txtSenha_KeyDown;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(263, 195);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(217, 36);
            txtLogin.TabIndex = 14;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            txtLogin.UseTallSize = false;
            txtLogin.KeyDown += txtLogin_KeyDown;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Depth = 0;
            lblRegistro.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblRegistro.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblRegistro.Location = new Point(464, 402);
            lblRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(75, 24);
            lblRegistro.TabIndex = 13;
            lblRegistro.Text = "Registro";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Depth = 0;
            lblEsqueceu.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEsqueceu.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblEsqueceu.Location = new Point(102, 402);
            lblEsqueceu.MouseState = MaterialSkin.MouseState.HOVER;
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(174, 24);
            lblEsqueceu.TabIndex = 12;
            lblEsqueceu.Text = "Esqueceu a Senha?";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(265, 142);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(193, 29);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Adega do Alemão";
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEntrar.Depth = 0;
            btnEntrar.HighEmphasis = true;
            btnEntrar.Icon = null;
            btnEntrar.Location = new Point(403, 290);
            btnEntrar.Margin = new Padding(4);
            btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrar.Name = "btnEntrar";
            btnEntrar.NoAccentTextColor = Color.Empty;
            btnEntrar.Size = new Size(77, 36);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEntrar.UseAccentColor = false;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(227, 194);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 19);
            materialLabel2.TabIndex = 21;
            materialLabel2.Text = "materialLabel2";
            // 
            // lblMensagem1
            // 
            lblMensagem1.AutoSize = true;
            lblMensagem1.Depth = 0;
            lblMensagem1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMensagem1.ForeColor = SystemColors.ControlText;
            lblMensagem1.Location = new Point(260, 290);
            lblMensagem1.MouseState = MaterialSkin.MouseState.HOVER;
            lblMensagem1.Name = "lblMensagem1";
            lblMensagem1.Size = new Size(107, 19);
            lblMensagem1.TabIndex = 20;
            lblMensagem1.Text = "materialLabel3";
            lblMensagem1.Visible = false;
            lblMensagem1.Click += lblMensagem1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblMensagem1);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblEsqueceu);
            panel1.Controls.Add(olhinhoLogin);
            panel1.Controls.Add(lblRegistro);
            panel1.Controls.Add(lblMensagem);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 480);
            panel1.TabIndex = 34;
            // 
            // LoginControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginControl";
            Size = new Size(720, 480);
            Load += LoginControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)olhinhoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblMensagem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox olhinhoLogin;
        private PictureBox lblMensagem;
        private MaterialSkin.Controls.MaterialTextBox2 txtSenha;
        private MaterialSkin.Controls.MaterialTextBox2 txtLogin;
        private MaterialSkin.Controls.MaterialLabel lblRegistro;
        private MaterialSkin.Controls.MaterialLabel lblEsqueceu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnEntrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblMensagem1;
        private Panel panel1;
    }
}
