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
            panel2 = new Panel();
            panel3 = new Panel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            btnCaixa = new MaterialSkin.Controls.MaterialButton();
            btnRelatorios = new MaterialSkin.Controls.MaterialButton();
            btnConfiguracoes = new MaterialSkin.Controls.MaterialButton();
            btnEstoque = new MaterialSkin.Controls.MaterialButton();
            panel3.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 125);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 783);
            panel2.Name = "panel2";
            panel2.Size = new Size(1445, 125);
            panel2.TabIndex = 1;
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
            kryptonTableLayoutPanel1.Location = new Point(103, 60);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 2;
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.Size = new Size(995, 523);
            kryptonTableLayoutPanel1.TabIndex = 4;
            // 
            // btnCaixa
            // 
            btnCaixa.AutoSize = false;
            btnCaixa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCaixa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCaixa.Depth = 0;
            btnCaixa.HighEmphasis = true;
            btnCaixa.Icon = null;
            btnCaixa.Location = new Point(501, 6);
            btnCaixa.Margin = new Padding(4, 6, 4, 6);
            btnCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            btnCaixa.Name = "btnCaixa";
            btnCaixa.NoAccentTextColor = Color.Empty;
            btnCaixa.Size = new Size(400, 213);
            btnCaixa.TabIndex = 1;
            btnCaixa.Text = "CAIXA";
            btnCaixa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCaixa.UseAccentColor = false;
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.AutoSize = false;
            btnRelatorios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRelatorios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRelatorios.Depth = 0;
            btnRelatorios.HighEmphasis = true;
            btnRelatorios.Icon = null;
            btnRelatorios.Location = new Point(4, 267);
            btnRelatorios.Margin = new Padding(4, 6, 4, 6);
            btnRelatorios.MouseState = MaterialSkin.MouseState.HOVER;
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.NoAccentTextColor = Color.Empty;
            btnRelatorios.Size = new Size(438, 213);
            btnRelatorios.TabIndex = 2;
            btnRelatorios.Text = "RELATORIOS";
            btnRelatorios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRelatorios.UseAccentColor = false;
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.AutoSize = false;
            btnConfiguracoes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfiguracoes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfiguracoes.Depth = 0;
            btnConfiguracoes.HighEmphasis = true;
            btnConfiguracoes.Icon = null;
            btnConfiguracoes.Location = new Point(501, 267);
            btnConfiguracoes.Margin = new Padding(4, 6, 4, 6);
            btnConfiguracoes.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.NoAccentTextColor = Color.Empty;
            btnConfiguracoes.Size = new Size(440, 236);
            btnConfiguracoes.TabIndex = 3;
            btnConfiguracoes.Text = "CONFIGURAÇÕES";
            btnConfiguracoes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfiguracoes.UseAccentColor = false;
            btnConfiguracoes.UseVisualStyleBackColor = true;
            btnConfiguracoes.Click += btnConfiguracoes_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.AutoSize = false;
            btnEstoque.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEstoque.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEstoque.Depth = 0;
            btnEstoque.HighEmphasis = true;
            btnEstoque.Icon = null;
            btnEstoque.Location = new Point(4, 6);
            btnEstoque.Margin = new Padding(4, 6, 4, 6);
            btnEstoque.MouseState = MaterialSkin.MouseState.HOVER;
            btnEstoque.Name = "btnEstoque";
            btnEstoque.NoAccentTextColor = Color.Empty;
            btnEstoque.Size = new Size(438, 219);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "ESTOQUE";
            btnEstoque.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEstoque.UseAccentColor = false;
            btnEstoque.UseVisualStyleBackColor = true;
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
    }
}
