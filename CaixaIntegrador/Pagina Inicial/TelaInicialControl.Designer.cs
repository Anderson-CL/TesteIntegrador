namespace CaixaIntegrador.Pagina_Inicial
{
    partial class TelaInicialControl
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
            panel1 = new Panel();
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            btnSair = new MaterialSkin.Controls.MaterialRadioButton();
            lblSaudacao = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            lblVersao = new MaterialSkin.Controls.MaterialLabel();
            lblData = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            btnConfiguracoes = new Button();
            btnCaixa = new Button();
            btnRelatorios = new Button();
            btnEstoque = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(lblSaudacao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 105);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(46, 32);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 41);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "materialLabel2";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.Red;
            btnSair.Depth = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1182, 32);
            btnSair.Margin = new Padding(0);
            btnSair.MouseLocation = new Point(-1, -1);
            btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            btnSair.Name = "btnSair";
            btnSair.Ripple = true;
            btnSair.Size = new Size(69, 37);
            btnSair.TabIndex = 5;
            btnSair.TabStop = true;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.CheckedChanged += btnSair_CheckedChanged;
            // 
            // lblSaudacao
            // 
            lblSaudacao.AutoEllipsis = true;
            lblSaudacao.AutoSize = true;
            lblSaudacao.Depth = 0;
            lblSaudacao.FlatStyle = FlatStyle.Flat;
            lblSaudacao.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSaudacao.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSaudacao.ForeColor = Color.White;
            lblSaudacao.Location = new Point(855, 41);
            lblSaudacao.MouseState = MaterialSkin.MouseState.HOVER;
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.RightToLeft = RightToLeft.Yes;
            lblSaudacao.Size = new Size(135, 24);
            lblSaudacao.TabIndex = 0;
            lblSaudacao.Text = "materialLabel1";
            lblSaudacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblVersao);
            panel2.Controls.Add(lblData);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 626);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 94);
            panel2.TabIndex = 1;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Depth = 0;
            lblVersao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblVersao.Location = new Point(46, 32);
            lblVersao.MouseState = MaterialSkin.MouseState.HOVER;
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(107, 19);
            lblVersao.TabIndex = 1;
            lblVersao.Text = "materialLabel3";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Depth = 0;
            lblData.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblData.Location = new Point(883, 32);
            lblData.MouseState = MaterialSkin.MouseState.HOVER;
            lblData.Name = "lblData";
            lblData.Size = new Size(107, 19);
            lblData.TabIndex = 0;
            lblData.Text = "materialLabel2";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConfiguracoes);
            panel3.Controls.Add(btnCaixa);
            panel3.Controls.Add(btnRelatorios);
            panel3.Controls.Add(btnEstoque);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 109);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1280, 517);
            panel3.TabIndex = 2;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.Orange;
            btnConfiguracoes.BackgroundImage = Properties.Resources.BCO_f8e6bf86_b615_4422_9b82_c700895e2aaf;
            btnConfiguracoes.BackgroundImageLayout = ImageLayout.Stretch;
            btnConfiguracoes.FlatStyle = FlatStyle.Popup;
            btnConfiguracoes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.Location = new Point(664, 269);
            btnConfiguracoes.Margin = new Padding(4);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(428, 185);
            btnConfiguracoes.TabIndex = 3;
            btnConfiguracoes.Text = "CONFIGURAÇÕES";
            btnConfiguracoes.TextAlign = ContentAlignment.BottomCenter;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = Color.Orange;
            btnCaixa.BackgroundImage = Properties.Resources.Cashier;
            btnCaixa.BackgroundImageLayout = ImageLayout.Zoom;
            btnCaixa.FlatStyle = FlatStyle.Popup;
            btnCaixa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.Location = new Point(664, 56);
            btnCaixa.Margin = new Padding(4);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(428, 184);
            btnCaixa.TabIndex = 1;
            btnCaixa.Text = "CAIXA";
            btnCaixa.TextAlign = ContentAlignment.BottomCenter;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.Orange;
            btnRelatorios.BackgroundImage = Properties.Resources.Relatório;
            btnRelatorios.BackgroundImageLayout = ImageLayout.Zoom;
            btnRelatorios.FlatStyle = FlatStyle.Popup;
            btnRelatorios.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Location = new Point(172, 269);
            btnRelatorios.Margin = new Padding(4);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(428, 186);
            btnRelatorios.TabIndex = 2;
            btnRelatorios.Text = "RELATORIOS";
            btnRelatorios.TextAlign = ContentAlignment.BottomCenter;
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.SeaGreen;
            btnEstoque.BackgroundImage = Properties.Resources.Estoque;
            btnEstoque.BackgroundImageLayout = ImageLayout.Zoom;
            btnEstoque.FlatStyle = FlatStyle.Popup;
            btnEstoque.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(172, 56);
            btnEstoque.Margin = new Padding(4);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(428, 184);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "ESTOQUE";
            btnEstoque.TextAlign = ContentAlignment.BottomCenter;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // TelaInicialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaInicialControl";
            Size = new Size(1280, 720);
            Load += TelaInicialControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnConfiguracoes;
        private Button btnRelatorios;
        private Button btnCaixa;
        private Button btnEstoque;
        private MaterialSkin.Controls.MaterialLabel lblSaudacao;
        private MaterialSkin.Controls.MaterialLabel lblVersao;
        private MaterialSkin.Controls.MaterialLabel lblData;
        private MaterialSkin.Controls.MaterialRadioButton btnSair;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}
