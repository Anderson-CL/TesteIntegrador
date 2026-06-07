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
            btnEntrar00 = new MaterialButton();
            txtSenha00 = new MaterialTextBox2();
            txtLogin00 = new MaterialTextBox2();
            lblRegistro00 = new MaterialLabel();
            lblEsqueceu00 = new MaterialLabel();
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
            panel1.Controls.Add(btnEntrar00);
            panel1.Controls.Add(txtSenha00);
            panel1.Controls.Add(txtLogin00);
            panel1.Controls.Add(lblRegistro00);
            panel1.Controls.Add(lblEsqueceu00);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(280, 137);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 19, 16, 19);
            panel1.Size = new Size(522, 507);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // MostrarOcultar
            // 
            MostrarOcultar.Cursor = Cursors.Hand;
            MostrarOcultar.Location = new Point(342, 225);
            MostrarOcultar.Margin = new Padding(3, 4, 3, 4);
            MostrarOcultar.Name = "MostrarOcultar";
            MostrarOcultar.Size = new Size(23, 31);
            MostrarOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarOcultar.TabIndex = 9;
            MostrarOcultar.TabStop = false;
            MostrarOcultar.Click += MostrarOcultar_Click;
            // 
            // btnEntrar00
            // 
            btnEntrar00.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrar00.Cursor = Cursors.Hand;
            btnEntrar00.Density = MaterialButton.MaterialButtonDensity.Default;
            btnEntrar00.Depth = 0;
            btnEntrar00.HighEmphasis = true;
            btnEntrar00.Icon = null;
            btnEntrar00.Location = new Point(221, 291);
            btnEntrar00.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrar00.Name = "btnEntrar00";
            btnEntrar00.NoAccentTextColor = Color.Empty;
            btnEntrar00.Size = new Size(77, 36);
            btnEntrar00.TabIndex = 8;
            btnEntrar00.Text = "ENTRAR";
            btnEntrar00.Type = MaterialButton.MaterialButtonType.Contained;
            btnEntrar00.UseAccentColor = false;
            btnEntrar00.UseVisualStyleBackColor = true;
            btnEntrar00.Click += btnEntrar_Click;
            // 
            // txtSenha00
            // 
            txtSenha00.AnimateReadOnly = false;
            txtSenha00.BackgroundImageLayout = ImageLayout.None;
            txtSenha00.CharacterCasing = CharacterCasing.Normal;
            txtSenha00.Cursor = Cursors.IBeam;
            txtSenha00.Depth = 0;
            txtSenha00.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha00.HideSelection = true;
            txtSenha00.LeadingIcon = null;
            txtSenha00.Location = new Point(209, 225);
            txtSenha00.MaxLength = 32767;
            txtSenha00.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha00.Name = "txtSenha00";
            txtSenha00.PasswordChar = '\0';
            txtSenha00.PrefixSuffixText = null;
            txtSenha00.ReadOnly = false;
            txtSenha00.RightToLeft = RightToLeft.No;
            txtSenha00.SelectedText = "";
            txtSenha00.SelectionLength = 0;
            txtSenha00.SelectionStart = 0;
            txtSenha00.ShortcutsEnabled = true;
            txtSenha00.Size = new Size(126, 48);
            txtSenha00.TabIndex = 7;
            txtSenha00.TabStop = false;
            txtSenha00.TextAlign = HorizontalAlignment.Left;
            txtSenha00.TrailingIcon = null;
            txtSenha00.UseSystemPasswordChar = false;
            txtSenha00.TextChanged += txtSenha_TextChanged;
            // 
            // txtLogin00
            // 
            txtLogin00.AnimateReadOnly = false;
            txtLogin00.BackgroundImageLayout = ImageLayout.None;
            txtLogin00.CharacterCasing = CharacterCasing.Normal;
            txtLogin00.Cursor = Cursors.IBeam;
            txtLogin00.Depth = 0;
            txtLogin00.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin00.HideSelection = true;
            txtLogin00.LeadingIcon = null;
            txtLogin00.Location = new Point(209, 153);
            txtLogin00.MaxLength = 32767;
            txtLogin00.MouseState = MaterialSkin.MouseState.OUT;
            txtLogin00.Name = "txtLogin00";
            txtLogin00.PasswordChar = '\0';
            txtLogin00.PrefixSuffixText = null;
            txtLogin00.ReadOnly = false;
            txtLogin00.RightToLeft = RightToLeft.No;
            txtLogin00.SelectedText = "";
            txtLogin00.SelectionLength = 0;
            txtLogin00.SelectionStart = 0;
            txtLogin00.ShortcutsEnabled = true;
            txtLogin00.Size = new Size(126, 48);
            txtLogin00.TabIndex = 6;
            txtLogin00.TabStop = false;
            txtLogin00.TextAlign = HorizontalAlignment.Left;
            txtLogin00.TrailingIcon = null;
            txtLogin00.UseSystemPasswordChar = false;
            // 
            // lblRegistro00
            // 
            lblRegistro00.AutoSize = true;
            lblRegistro00.Cursor = Cursors.Hand;
            lblRegistro00.Depth = 0;
            lblRegistro00.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRegistro00.ForeColor = Color.RoyalBlue;
            lblRegistro00.Location = new Point(326, 348);
            lblRegistro00.MouseState = MaterialSkin.MouseState.HOVER;
            lblRegistro00.Name = "lblRegistro00";
            lblRegistro00.Size = new Size(78, 19);
            lblRegistro00.TabIndex = 5;
            lblRegistro00.Text = "Registre-se";
            lblRegistro00.Click += lblRegistro_Click;
            // 
            // lblEsqueceu00
            // 
            lblEsqueceu00.AutoSize = true;
            lblEsqueceu00.Depth = 0;
            lblEsqueceu00.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEsqueceu00.Location = new Point(138, 348);
            lblEsqueceu00.MouseState = MaterialSkin.MouseState.HOVER;
            lblEsqueceu00.Name = "lblEsqueceu00";
            lblEsqueceu00.Size = new Size(139, 19);
            lblEsqueceu00.TabIndex = 4;
            lblEsqueceu00.Text = "Esqueceu a Senha?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(221, 95);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 3;
            label1.Text = "TELA DE LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(142, 225);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(142, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 792);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Location = new Point(245, 103);
            Name = "TelaLogin";
            Padding = new Padding(3, 32, 3, 4);
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
        private MaterialButton btnEntrar00;
        private MaterialTextBox2 txtSenha00;
        private MaterialTextBox2 txtLogin00;
        private MaterialLabel lblRegistro00;
        private MaterialLabel lblEsqueceu00;
        private MaterialLabel label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox MostrarOcultar;
    }
}