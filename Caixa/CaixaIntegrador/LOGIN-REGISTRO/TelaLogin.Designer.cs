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
            panel1 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblRegistro = new Label();
            lblEsqueceu = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(lblRegistro);
            panel1.Controls.Add(lblEsqueceu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(108, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 312);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(208, 212);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(82, 22);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(193, 171);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(110, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(193, 117);
            txtLogin.Margin = new Padding(3, 2, 3, 2);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(110, 23);
            txtLogin.TabIndex = 6;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.ForeColor = Color.RoyalBlue;
            lblRegistro.Location = new Point(285, 261);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(65, 15);
            lblRegistro.TabIndex = 5;
            lblRegistro.Text = "Registre-se";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // lblEsqueceu
            // 
            lblEsqueceu.AutoSize = true;
            lblEsqueceu.Location = new Point(121, 261);
            lblEsqueceu.Name = "lblEsqueceu";
            lblEsqueceu.Size = new Size(106, 15);
            lblEsqueceu.TabIndex = 4;
            lblEsqueceu.Text = "Esqueceu a Senha?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 71);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "TELA DE LOGIN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(121, 160);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(121, 117);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 31);
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
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblRegistro;
        private Label lblEsqueceu;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}