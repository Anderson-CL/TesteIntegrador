using MaterialSkin.Controls;

namespace CaixaIntegrador.LOGIN_REGISTRO
{
    partial class TelaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRegistro));
            panel1 = new MaterialCard();
            MostrarOcultar2 = new PictureBox();
            MostrarOcultar1 = new PictureBox();
            txtRegistroSenha2 = new MaterialTextBox2();
            pictureBox4 = new PictureBox();
            btnRegistro = new MaterialButton();
            txtRegistroSenha1 = new MaterialTextBox2();
            txtRegistroLogin = new MaterialTextBox2();
            lblRegistro = new MaterialLabel();
            lblEsqueceu = new MaterialLabel();
            label1 = new MaterialLabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.Controls.Add(MostrarOcultar2);
            panel1.Controls.Add(MostrarOcultar1);
            panel1.Controls.Add(txtRegistroSenha2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(txtRegistroSenha1);
            panel1.Controls.Add(txtRegistroLogin);
            panel1.Controls.Add(lblRegistro);
            panel1.Controls.Add(lblEsqueceu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Depth = 0;
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(245, 63);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.MouseState = MaterialSkin.MouseState.HOVER;
            panel1.Name = "panel1";
            panel1.Padding = new Padding(14);
            panel1.Size = new Size(457, 380);
            panel1.TabIndex = 0;
            // 
            // MostrarOcultar2
            // 
            MostrarOcultar2.Cursor = Cursors.Hand;
            MostrarOcultar2.Location = new Point(299, 204);
            MostrarOcultar2.Name = "MostrarOcultar2";
            MostrarOcultar2.Size = new Size(20, 23);
            MostrarOcultar2.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarOcultar2.TabIndex = 11;
            MostrarOcultar2.TabStop = false;
            MostrarOcultar2.Click += MostrarOcultar2_Click;
            // 
            // MostrarOcultar1
            // 
            MostrarOcultar1.Cursor = Cursors.Hand;
            MostrarOcultar1.Location = new Point(299, 155);
            MostrarOcultar1.Name = "MostrarOcultar1";
            MostrarOcultar1.Size = new Size(20, 23);
            MostrarOcultar1.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarOcultar1.TabIndex = 10;
            MostrarOcultar1.TabStop = false;
            MostrarOcultar1.Click += MostrarOcultar1_Click;
            // 
            // txtRegistroSenha2
            // 
            txtRegistroSenha2.AnimateReadOnly = false;
            txtRegistroSenha2.BackgroundImageLayout = ImageLayout.None;
            txtRegistroSenha2.CharacterCasing = CharacterCasing.Normal;
            txtRegistroSenha2.Cursor = Cursors.IBeam;
            txtRegistroSenha2.Depth = 0;
            txtRegistroSenha2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroSenha2.HideSelection = true;
            txtRegistroSenha2.LeadingIcon = null;
            txtRegistroSenha2.Location = new Point(183, 204);
            txtRegistroSenha2.Margin = new Padding(3, 2, 3, 2);
            txtRegistroSenha2.MaxLength = 32767;
            txtRegistroSenha2.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistroSenha2.Name = "txtRegistroSenha2";
            txtRegistroSenha2.PasswordChar = '\0';
            txtRegistroSenha2.PrefixSuffixText = null;
            txtRegistroSenha2.ReadOnly = false;
            txtRegistroSenha2.RightToLeft = RightToLeft.No;
            txtRegistroSenha2.SelectedText = "";
            txtRegistroSenha2.SelectionLength = 0;
            txtRegistroSenha2.SelectionStart = 0;
            txtRegistroSenha2.ShortcutsEnabled = true;
            txtRegistroSenha2.Size = new Size(110, 48);
            txtRegistroSenha2.TabIndex = 3;
            txtRegistroSenha2.TabStop = false;
            txtRegistroSenha2.TextAlign = HorizontalAlignment.Left;
            txtRegistroSenha2.TrailingIcon = null;
            txtRegistroSenha2.UseSystemPasswordChar = false;
            txtRegistroSenha2.TextChanged += txtRegistroSenha2_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(121, 204);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btnRegistro
            // 
            btnRegistro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRegistro.Depth = 0;
            btnRegistro.HighEmphasis = true;
            btnRegistro.Icon = null;
            btnRegistro.Location = new Point(193, 244);
            btnRegistro.Margin = new Padding(3, 2, 3, 2);
            btnRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistro.Name = "btnRegistro";
            btnRegistro.NoAccentTextColor = Color.Empty;
            btnRegistro.Size = new Size(99, 36);
            btnRegistro.TabIndex = 4;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.Type = MaterialButton.MaterialButtonType.Contained;
            btnRegistro.UseAccentColor = false;
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtRegistroSenha1
            // 
            txtRegistroSenha1.AnimateReadOnly = false;
            txtRegistroSenha1.BackgroundImageLayout = ImageLayout.None;
            txtRegistroSenha1.CharacterCasing = CharacterCasing.Normal;
            txtRegistroSenha1.Cursor = Cursors.IBeam;
            txtRegistroSenha1.Depth = 0;
            txtRegistroSenha1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroSenha1.HideSelection = true;
            txtRegistroSenha1.LeadingIcon = null;
            txtRegistroSenha1.Location = new Point(183, 155);
            txtRegistroSenha1.Margin = new Padding(3, 2, 3, 2);
            txtRegistroSenha1.MaxLength = 32767;
            txtRegistroSenha1.MouseState = MaterialSkin.MouseState.OUT;
            txtRegistroSenha1.Name = "txtRegistroSenha1";
            txtRegistroSenha1.PasswordChar = '\0';
            txtRegistroSenha1.PrefixSuffixText = null;
            txtRegistroSenha1.ReadOnly = false;
            txtRegistroSenha1.RightToLeft = RightToLeft.No;
            txtRegistroSenha1.SelectedText = "";
            txtRegistroSenha1.SelectionLength = 0;
            txtRegistroSenha1.SelectionStart = 0;
            txtRegistroSenha1.ShortcutsEnabled = true;
            txtRegistroSenha1.Size = new Size(110, 48);
            txtRegistroSenha1.TabIndex = 2;
            txtRegistroSenha1.TabStop = false;
            txtRegistroSenha1.TextAlign = HorizontalAlignment.Left;
            txtRegistroSenha1.TrailingIcon = null;
            txtRegistroSenha1.UseSystemPasswordChar = false;
            txtRegistroSenha1.TextChanged += txtRegistroSenha1_TextChanged;
            // 
            // txtRegistroLogin
            // 
            txtRegistroLogin.AnimateReadOnly = false;
            txtRegistroLogin.BackgroundImageLayout = ImageLayout.None;
            txtRegistroLogin.CharacterCasing = CharacterCasing.Normal;
            txtRegistroLogin.Cursor = Cursors.IBeam;
            txtRegistroLogin.Depth = 0;
            txtRegistroLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroLogin.HideSelection = true;
            txtRegistroLogin.LeadingIcon = null;
            txtRegistroLogin.Location = new Point(183, 111);
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
            txtRegistroLogin.Size = new Size(110, 48);
            txtRegistroLogin.TabIndex = 1;
            txtRegistroLogin.TabStop = false;
            txtRegistroLogin.TextAlign = HorizontalAlignment.Left;
            txtRegistroLogin.TrailingIcon = null;
            txtRegistroLogin.UseSystemPasswordChar = false;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Cursor = Cursors.Hand;
            lblRegistro.Depth = 0;
            lblRegistro.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRegistro.ForeColor = Color.RoyalBlue;
            lblRegistro.Location = new Point(270, 292);
            lblRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(43, 19);
            lblRegistro.TabIndex = 5;
            lblRegistro.Text = "Entrar";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Depth = 0;
            lblEsqueceu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEsqueceu.Location = new Point(121, 292);
            lblEsqueceu.MouseState = MaterialSkin.MouseState.HOVER;
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(138, 19);
            lblEsqueceu.TabIndex = 6;
            lblEsqueceu.Text = "Já tem uma conta?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(183, 70);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 0;
            label1.Text = "TELA DE REGISTRO";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(121, 155);
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
            pictureBox2.Location = new Point(121, 111);
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
            pictureBox1.Location = new Point(209, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(949, 594);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaRegistro";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8";
            Load += TelaRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarOcultar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialCard panel1;
        private MaterialTextBox2 txtRegistroSenha2;
        private PictureBox pictureBox4;
        private MaterialButton btnRegistro;
        private MaterialTextBox2 txtRegistroSenha1;
        private MaterialTextBox2 txtRegistroLogin;
        private MaterialLabel lblRegistro;
        private MaterialLabel lblEsqueceu;
        private MaterialLabel label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox MostrarOcultar2;
        private PictureBox MostrarOcultar1;
    }
}