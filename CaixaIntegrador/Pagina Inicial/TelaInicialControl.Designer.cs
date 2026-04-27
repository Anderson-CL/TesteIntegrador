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
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            btnCaixa = new MaterialSkin.Controls.MaterialButton();
            btnRelatorios = new MaterialSkin.Controls.MaterialButton();
            btnConfiguracoes = new MaterialSkin.Controls.MaterialButton();
            btnEstoque = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(lblSaudacao);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 125);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(52, 42);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 19);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "materialLabel2";
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.BackColor = Color.Red;
            btnSair.Depth = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(1159, 48);
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
            lblSaudacao.AutoSize = true;
            lblSaudacao.Depth = 0;
            lblSaudacao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSaudacao.ForeColor = Color.White;
            lblSaudacao.Location = new Point(1009, 59);
            lblSaudacao.MouseState = MaterialSkin.MouseState.HOVER;
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(107, 19);
            lblSaudacao.TabIndex = 0;
            lblSaudacao.Text = "materialLabel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblVersao);
            panel2.Controls.Add(lblData);
            panel2.Location = new Point(0, 783);
            panel2.Name = "panel2";
            panel2.Size = new Size(1445, 125);
            panel2.TabIndex = 1;
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Depth = 0;
            lblVersao.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblVersao.Location = new Point(52, 43);
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
            lblData.Location = new Point(1009, 43);
            lblData.MouseState = MaterialSkin.MouseState.HOVER;
            lblData.Name = "lblData";
            lblData.Size = new Size(107, 19);
            lblData.TabIndex = 0;
            lblData.Text = "materialLabel2";
            // 
            // panel3
            // 
            panel3.Controls.Add(kryptonTableLayoutPanel1);
            panel3.Location = new Point(3, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(1439, 622);
            panel3.TabIndex = 2;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.ColumnCount = 2;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Controls.Add(btnCaixa, 1, 0);
            kryptonTableLayoutPanel1.Controls.Add(btnRelatorios, 0, 1);
            kryptonTableLayoutPanel1.Controls.Add(btnConfiguracoes, 1, 1);
            kryptonTableLayoutPanel1.Controls.Add(btnEstoque, 0, 0);
            kryptonTableLayoutPanel1.Location = new Point(229, 42);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 2;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Size = new Size(996, 517);
            kryptonTableLayoutPanel1.TabIndex = 4;
            // 
            // btnCaixa
            // 
            btnCaixa.AutoSize = false;
            btnCaixa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCaixa.BackColor = Color.Orange;
            btnCaixa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCaixa.Depth = 0;
            btnCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCaixa.ForeColor = Color.White;
            btnCaixa.HighEmphasis = true;
            btnCaixa.Icon = null;
            btnCaixa.Location = new Point(502, 6);
            btnCaixa.Margin = new Padding(4, 6, 4, 6);
            btnCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            btnCaixa.Name = "btnCaixa";
            btnCaixa.NoAccentTextColor = Color.Empty;
            btnCaixa.Size = new Size(490, 246);
            btnCaixa.TabIndex = 1;
            btnCaixa.Text = "CAIXA";
            btnCaixa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCaixa.UseAccentColor = false;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.AutoSize = false;
            btnRelatorios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRelatorios.BackColor = Color.MediumBlue;
            btnRelatorios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRelatorios.Depth = 0;
            btnRelatorios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.HighEmphasis = true;
            btnRelatorios.Icon = null;
            btnRelatorios.Location = new Point(4, 264);
            btnRelatorios.Margin = new Padding(4, 6, 4, 6);
            btnRelatorios.MouseState = MaterialSkin.MouseState.HOVER;
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.NoAccentTextColor = Color.Empty;
            btnRelatorios.Size = new Size(490, 247);
            btnRelatorios.TabIndex = 2;
            btnRelatorios.Text = "RELATORIOS";
            btnRelatorios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRelatorios.UseAccentColor = false;
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.AutoSize = false;
            btnConfiguracoes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfiguracoes.BackColor = Color.DarkBlue;
            btnConfiguracoes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfiguracoes.Depth = 0;
            btnConfiguracoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.HighEmphasis = true;
            btnConfiguracoes.Icon = null;
            btnConfiguracoes.Location = new Point(502, 264);
            btnConfiguracoes.Margin = new Padding(4, 6, 4, 6);
            btnConfiguracoes.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.NoAccentTextColor = Color.Empty;
            btnConfiguracoes.Size = new Size(490, 247);
            btnConfiguracoes.TabIndex = 3;
            btnConfiguracoes.Text = "CONFIGURAÇÕES";
            btnConfiguracoes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfiguracoes.UseAccentColor = false;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.AutoSize = false;
            btnEstoque.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEstoque.BackColor = Color.Yellow;
            btnEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEstoque.Depth = 0;
            btnEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEstoque.ForeColor = Color.IndianRed;
            btnEstoque.HighEmphasis = true;
            btnEstoque.Icon = null;
            btnEstoque.Location = new Point(4, 6);
            btnEstoque.Margin = new Padding(4, 6, 4, 6);
            btnEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            btnEstoque.Name = "btnEstoque";
            btnEstoque.NoAccentTextColor = Color.Empty;
            btnEstoque.Size = new Size(490, 246);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "ESTOQUE";
            btnEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEstoque.UseAccentColor = false;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // TelaInicialControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TelaInicialControl";
            Size = new Size(1445, 908);
            Load += TelaInicialControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnConfiguracoes;
        private MaterialSkin.Controls.MaterialButton btnRelatorios;
        private MaterialSkin.Controls.MaterialButton btnCaixa;
        private MaterialSkin.Controls.MaterialButton btnEstoque;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lblSaudacao;
        private MaterialSkin.Controls.MaterialLabel lblVersao;
        private MaterialSkin.Controls.MaterialLabel lblData;
        private MaterialSkin.Controls.MaterialRadioButton btnSair;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}
