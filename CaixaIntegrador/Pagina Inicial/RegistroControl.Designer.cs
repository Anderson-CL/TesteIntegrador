namespace CaixaIntegrador.Pagina_Inicial
{
    partial class RegistroControl
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
            olhinhoRegistro2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtRegistroSenha1 = new MaterialSkin.Controls.MaterialTextBox2();
            txtRegistroLogin = new MaterialSkin.Controls.MaterialTextBox2();
            btnVoltar = new MaterialSkin.Controls.MaterialLabel();
            lblEsqueceu = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnRegistro = new MaterialSkin.Controls.MaterialButton();
            txtRegistroSenha2 = new MaterialSkin.Controls.MaterialTextBox2();
            olinhoRegistro1 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblMensagemRegistro = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)olhinhoRegistro2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)olinhoRegistro1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.face_13896971;
            pictureBox3.Location = new Point(215, 195);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // olhinhoRegistro2
            // 
            olhinhoRegistro2.Image = Properties.Resources.OlharNo;
            olhinhoRegistro2.Location = new Point(487, 294);
            olhinhoRegistro2.Margin = new Padding(3, 2, 3, 2);
            olhinhoRegistro2.Name = "olhinhoRegistro2";
            olhinhoRegistro2.Size = new Size(42, 36);
            olhinhoRegistro2.SizeMode = PictureBoxSizeMode.Zoom;
            olhinhoRegistro2.TabIndex = 27;
            olhinhoRegistro2.TabStop = false;
            olhinhoRegistro2.Visible = false;
            olhinhoRegistro2.Click += olhinhoRegistro2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cadeado;
            pictureBox1.Location = new Point(215, 245);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // txtRegistroSenha1
            // 
            txtRegistroSenha1.AnimateReadOnly = false;
            txtRegistroSenha1.BackgroundImageLayout = ImageLayout.None;
            txtRegistroSenha1.CharacterCasing = CharacterCasing.Normal;
            txtRegistroSenha1.Depth = 0;
            txtRegistroSenha1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroSenha1.HideSelection = true;
            txtRegistroSenha1.LeadingIcon = null;
            txtRegistroSenha1.Location = new Point(263, 245);
            txtRegistroSenha1.Margin = new Padding(3, 2, 3, 2);
            txtRegistroSenha1.MaxLength = 32767;
            txtRegistroSenha1.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistroSenha1.Name = "txtRegistroSenha1";
            txtRegistroSenha1.PasswordChar = '●';
            txtRegistroSenha1.PrefixSuffixText = null;
            txtRegistroSenha1.ReadOnly = false;
            txtRegistroSenha1.RightToLeft = RightToLeft.No;
            txtRegistroSenha1.SelectedText = "";
            txtRegistroSenha1.SelectionLength = 0;
            txtRegistroSenha1.SelectionStart = 0;
            txtRegistroSenha1.ShortcutsEnabled = true;
            txtRegistroSenha1.Size = new Size(220, 36);
            txtRegistroSenha1.TabIndex = 25;
            txtRegistroSenha1.TabStop = false;
            txtRegistroSenha1.TextAlign = HorizontalAlignment.Left;
            txtRegistroSenha1.TrailingIcon = null;
            txtRegistroSenha1.UseSystemPasswordChar = false;
            txtRegistroSenha1.UseTallSize = false;
            txtRegistroSenha1.KeyDown += txtRegistroSenha1_KeyDown;
            txtRegistroSenha1.TextChanged += txtRegistroSenha1_TextChanged;
            // 
            // txtRegistroLogin
            // 
            txtRegistroLogin.AnimateReadOnly = false;
            txtRegistroLogin.BackgroundImageLayout = ImageLayout.None;
            txtRegistroLogin.CharacterCasing = CharacterCasing.Normal;
            txtRegistroLogin.Depth = 0;
            txtRegistroLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroLogin.HideSelection = true;
            txtRegistroLogin.LeadingIcon = null;
            txtRegistroLogin.Location = new Point(266, 195);
            txtRegistroLogin.Margin = new Padding(3, 2, 3, 2);
            txtRegistroLogin.MaxLength = 32767;
            txtRegistroLogin.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistroLogin.Name = "txtRegistroLogin";
            txtRegistroLogin.PasswordChar = '\0';
            txtRegistroLogin.PrefixSuffixText = null;
            txtRegistroLogin.ReadOnly = false;
            txtRegistroLogin.RightToLeft = RightToLeft.No;
            txtRegistroLogin.SelectedText = "";
            txtRegistroLogin.SelectionLength = 0;
            txtRegistroLogin.SelectionStart = 0;
            txtRegistroLogin.ShortcutsEnabled = true;
            txtRegistroLogin.Size = new Size(217, 36);
            txtRegistroLogin.TabIndex = 24;
            txtRegistroLogin.TabStop = false;
            txtRegistroLogin.TextAlign = HorizontalAlignment.Left;
            txtRegistroLogin.TrailingIcon = null;
            txtRegistroLogin.UseSystemPasswordChar = false;
            txtRegistroLogin.UseTallSize = false;
            txtRegistroLogin.Click += txtRegistroLogin_Click;
            txtRegistroLogin.KeyDown += txtRegistroLogin_KeyDown;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSize = true;
            btnVoltar.Depth = 0;
            btnVoltar.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoltar.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            btnVoltar.Location = new Point(487, 394);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(55, 24);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Entrar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Depth = 0;
            lblEsqueceu.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEsqueceu.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblEsqueceu.Location = new Point(130, 394);
            lblEsqueceu.MouseState = MaterialSkin.MouseState.HOVER;
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(172, 24);
            lblEsqueceu.TabIndex = 22;
            lblEsqueceu.Text = "Já tem uma conta?";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(290, 142);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(158, 29);
            materialLabel1.TabIndex = 21;
            materialLabel1.Text = "Crie sua Conta";
            materialLabel1.UseAccent = true;
            // 
            // btnRegistro
            // 
            btnRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistro.Depth = 0;
            btnRegistro.HighEmphasis = true;
            btnRegistro.Icon = null;
            btnRegistro.Location = new Point(384, 336);
            btnRegistro.Margin = new Padding(4);
            btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistro.Name = "btnRegistro";
            btnRegistro.NoAccentTextColor = Color.Empty;
            btnRegistro.Size = new Size(99, 36);
            btnRegistro.TabIndex = 20;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistro.UseAccentColor = false;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtRegistroSenha2
            // 
            txtRegistroSenha2.AnimateReadOnly = false;
            txtRegistroSenha2.BackgroundImageLayout = ImageLayout.None;
            txtRegistroSenha2.CharacterCasing = CharacterCasing.Normal;
            txtRegistroSenha2.Depth = 0;
            txtRegistroSenha2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroSenha2.HideSelection = true;
            txtRegistroSenha2.LeadingIcon = null;
            txtRegistroSenha2.Location = new Point(263, 294);
            txtRegistroSenha2.Margin = new Padding(3, 2, 3, 2);
            txtRegistroSenha2.MaxLength = 32767;
            txtRegistroSenha2.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistroSenha2.Name = "txtRegistroSenha2";
            txtRegistroSenha2.PasswordChar = '●';
            txtRegistroSenha2.PrefixSuffixText = null;
            txtRegistroSenha2.ReadOnly = false;
            txtRegistroSenha2.RightToLeft = RightToLeft.No;
            txtRegistroSenha2.SelectedText = "";
            txtRegistroSenha2.SelectionLength = 0;
            txtRegistroSenha2.SelectionStart = 0;
            txtRegistroSenha2.ShortcutsEnabled = true;
            txtRegistroSenha2.Size = new Size(220, 36);
            txtRegistroSenha2.TabIndex = 30;
            txtRegistroSenha2.TabStop = false;
            txtRegistroSenha2.TextAlign = HorizontalAlignment.Left;
            txtRegistroSenha2.TrailingIcon = null;
            txtRegistroSenha2.UseSystemPasswordChar = false;
            txtRegistroSenha2.UseTallSize = false;
            txtRegistroSenha2.KeyDown += txtRegistroSenha2_KeyDown;
            txtRegistroSenha2.TextChanged += txtRegistroSenha2_TextChanged;
            // 
            // olinhoRegistro1
            // 
            olinhoRegistro1.Image = Properties.Resources.OlharNo;
            olinhoRegistro1.Location = new Point(487, 245);
            olinhoRegistro1.Margin = new Padding(3, 2, 3, 2);
            olinhoRegistro1.Name = "olinhoRegistro1";
            olinhoRegistro1.Size = new Size(42, 36);
            olinhoRegistro1.SizeMode = PictureBoxSizeMode.Zoom;
            olinhoRegistro1.TabIndex = 31;
            olinhoRegistro1.TabStop = false;
            olinhoRegistro1.Visible = false;
            olinhoRegistro1.Click += olinhoRegistro1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.cadeado;
            pictureBox6.Location = new Point(215, 294);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(42, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // lblMensagemRegistro
            // 
            lblMensagemRegistro.AutoSize = true;
            lblMensagemRegistro.Depth = 0;
            lblMensagemRegistro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMensagemRegistro.Location = new Point(260, 336);
            lblMensagemRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            lblMensagemRegistro.Name = "lblMensagemRegistro";
            lblMensagemRegistro.Size = new Size(107, 19);
            lblMensagemRegistro.TabIndex = 33;
            lblMensagemRegistro.Text = "materialLabel2";
            lblMensagemRegistro.UseAccent = true;
            lblMensagemRegistro.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblMensagemRegistro);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(olinhoRegistro1);
            panel1.Controls.Add(lblEsqueceu);
            panel1.Controls.Add(txtRegistroSenha2);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtRegistroLogin);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtRegistroSenha1);
            panel1.Controls.Add(olhinhoRegistro2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 480);
            panel1.TabIndex = 34;
            panel1.Paint += panel1_Paint;
            // 
            // RegistroControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroControl";
            Size = new Size(720, 480);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)olhinhoRegistro2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)olinhoRegistro1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox olhinhoRegistro2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegistroSenha1;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegistroLogin;
        private MaterialSkin.Controls.MaterialLabel btnVoltar;
        private MaterialSkin.Controls.MaterialLabel lblEsqueceu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnRegistro;
        private MaterialSkin.Controls.MaterialTextBox2 txtRegistroSenha2;
        private PictureBox olinhoRegistro1;
        private PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialLabel lblMensagemRegistro;
        private Panel panel1;
    }
}
