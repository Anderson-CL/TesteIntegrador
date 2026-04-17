using MaterialSkin.Controls;

namespace CaixaIntegrador.LOGIN_REGISTRO
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            panel1 = new MaterialCard();
            MostrarOcultar = new PictureBox();
            btnEntrar = new MaterialButton();
            txtSenha = new MaterialTextBox2();
            txtLogin = new MaterialTextBox2();
            lblRegistro = new MaterialLabel();
            lblEsqueceu = new MaterialLabel();
            label1 = new MaterialLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(MostrarOcultar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(lblRegistro);
            panel1.Controls.Add(lblEsqueceu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(245, 103);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(14);
            panel1.Size = new Size(457, 380);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // MostrarOcultar
            // 
            MostrarOcultar.Cursor = Cursors.Hand;
            MostrarOcultar.Location = new Point(299, 169);
            MostrarOcultar.Name = "MostrarOcultar";
            MostrarOcultar.Size = new Size(20, 23);
            MostrarOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarOcultar.TabIndex = 9;
            MostrarOcultar.TabStop = false;
            MostrarOcultar.Click += MostrarOcultar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Density = MaterialButton.MaterialButtonDensity.Default;
            btnEntrar.Depth = 0;
            btnEntrar.HighEmphasis = true;
            btnEntrar.Icon = null;
            btnEntrar.Location = new Point(193, 218);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrar.Name = "btnEntrar";
            btnEntrar.NoAccentTextColor = Color.Empty;
            btnEntrar.Size = new Size(77, 36);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Type = MaterialButton.MaterialButtonType.Contained;
            btnEntrar.UseAccentColor = false;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(183, 169);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(110, 48);
            txtSenha.TabIndex = 7;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Cursor = Cursors.IBeam;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(183, 115);
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
            txtLogin.Size = new Size(110, 48);
            txtLogin.TabIndex = 6;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Depth = 0;
            lblRegistro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRegistro.ForeColor = Color.RoyalBlue;
            lblRegistro.Location = new Point(285, 261);
            lblRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(78, 19);
            lblRegistro.TabIndex = 5;
            lblRegistro.Text = "Registre-se";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Depth = 0;
            lblEsqueceu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEsqueceu.Location = new Point(121, 261);
            lblEsqueceu.MouseState = MaterialSkin.MouseState.HOVER;
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(139, 19);
            lblEsqueceu.TabIndex = 4;
            lblEsqueceu.Text = "Esqueceu a Senha?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(193, 71);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 3;
            label1.Text = "TELA DE LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(124, 169);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 115);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(949, 594);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Location = new Point(245, 103);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaLogin";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialCard panel1;
        private MaterialButton btnEntrar;
        private MaterialTextBox2 txtSenha;
        private MaterialTextBox2 txtLogin;
        private MaterialLabel lblRegistro;
        private MaterialLabel lblEsqueceu;
        private MaterialLabel label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox MostrarOcultar;
    }
}