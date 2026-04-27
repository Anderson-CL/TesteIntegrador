namespace CaixaIntegrador.Estoque
{
    partial class EstoqueControl
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnFiltrar = new MaterialSkin.Controls.MaterialButton();
            cmbFiltrar = new MaterialSkin.Controls.MaterialComboBox();
            btbBuscar = new MaterialSkin.Controls.MaterialButton();
            txtBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            BtnAtualizarQtd = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            btnRemover = new MaterialSkin.Controls.MaterialButton();
            btnAdicionar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnFiltrar);
            materialCard1.Controls.Add(cmbFiltrar);
            materialCard1.Controls.Add(btbBuscar);
            materialCard1.Controls.Add(txtBuscar);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 32);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(908, 81);
            materialCard1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = false;
            btnFiltrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFiltrar.Depth = 0;
            btnFiltrar.HighEmphasis = true;
            btnFiltrar.Icon = null;
            btnFiltrar.Location = new Point(778, 8);
            btnFiltrar.Margin = new Padding(5, 8, 5, 8);
            btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoAccentTextColor = Color.Empty;
            btnFiltrar.Size = new Size(109, 65);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFiltrar.UseAccentColor = false;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cmbFiltrar
            // 
            cmbFiltrar.AutoResize = false;
            cmbFiltrar.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltrar.Depth = 0;
            cmbFiltrar.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltrar.DropDownHeight = 174;
            cmbFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrar.DropDownWidth = 121;
            cmbFiltrar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltrar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltrar.FormattingEnabled = true;
            cmbFiltrar.IntegralHeight = false;
            cmbFiltrar.ItemHeight = 43;
            cmbFiltrar.Location = new Point(574, 9);
            cmbFiltrar.Margin = new Padding(3, 4, 3, 4);
            cmbFiltrar.MaxDropDownItems = 4;
            cmbFiltrar.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltrar.Name = "cmbFiltrar";
            cmbFiltrar.Size = new Size(180, 49);
            cmbFiltrar.StartIndex = 0;
            cmbFiltrar.TabIndex = 2;
            cmbFiltrar.SelectedIndexChanged += cmbFiltrar_SelectedIndexChanged;
            // 
            // btbBuscar
            // 
            btbBuscar.AutoSize = false;
            btbBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbBuscar.Depth = 0;
            btbBuscar.HighEmphasis = true;
            btbBuscar.Icon = null;
            btbBuscar.Location = new Point(187, 8);
            btbBuscar.Margin = new Padding(5, 8, 5, 8);
            btbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscar.Name = "btbBuscar";
            btbBuscar.NoAccentTextColor = Color.Empty;
            btbBuscar.Size = new Size(111, 64);
            btbBuscar.TabIndex = 1;
            btbBuscar.Text = "Buscar";
            btbBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbBuscar.UseAccentColor = false;
            btbBuscar.UseVisualStyleBackColor = true;
            btbBuscar.Click += btbBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.AllowPromptAsInput = true;
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.AsciiOnly = false;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.BeepOnError = false;
            txtBuscar.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.HidePromptOnLeave = false;
            txtBuscar.HideSelection = true;
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(19, 10);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Mask = "";
            txtBuscar.MaxLength = 32767;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = '\0';
            txtBuscar.PrefixSuffixText = null;
            txtBuscar.PromptChar = '_';
            txtBuscar.ReadOnly = false;
            txtBuscar.RejectInputOnFirstFailure = false;
            txtBuscar.ResetOnPrompt = true;
            txtBuscar.ResetOnSpace = true;
            txtBuscar.RightToLeft = RightToLeft.No;
            txtBuscar.SelectedText = "";
            txtBuscar.SelectionLength = 0;
            txtBuscar.SelectionStart = 0;
            txtBuscar.ShortcutsEnabled = true;
            txtBuscar.Size = new Size(156, 48);
            txtBuscar.SkipLiterals = true;
            txtBuscar.TabIndex = 0;
            txtBuscar.TabStop = false;
            txtBuscar.Text = "Digite aqui";
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.ValidatingType = null;
            // 
            // BtnAtualizarQtd
            // 
            BtnAtualizarQtd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAtualizarQtd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAtualizarQtd.Depth = 0;
            BtnAtualizarQtd.HighEmphasis = true;
            BtnAtualizarQtd.Icon = null;
            BtnAtualizarQtd.Location = new Point(767, 17);
            BtnAtualizarQtd.Margin = new Padding(5, 8, 5, 8);
            BtnAtualizarQtd.MouseState = MaterialSkin.MouseState.HOVER;
            BtnAtualizarQtd.Name = "BtnAtualizarQtd";
            BtnAtualizarQtd.NoAccentTextColor = Color.Empty;
            BtnAtualizarQtd.Size = new Size(98, 36);
            BtnAtualizarQtd.TabIndex = 3;
            BtnAtualizarQtd.Text = "Adicionar";
            BtnAtualizarQtd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnAtualizarQtd.UseAccentColor = false;
            BtnAtualizarQtd.UseVisualStyleBackColor = true;
            BtnAtualizarQtd.Click += BtnAtualizarQtd_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Controls.Add(txtQuantidade);
            materialCard2.Controls.Add(btnRemover);
            materialCard2.Controls.Add(BtnAtualizarQtd);
            materialCard2.Controls.Add(btnAdicionar);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Bottom;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 528);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(914, 72);
            materialCard2.TabIndex = 3;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(469, 28);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(128, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Nova Quantidade.";
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(613, 13);
            txtQuantidade.MaxLength = 50;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Multiline = false;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 50);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.Text = "";
            txtQuantidade.TrailingIcon = null;
            // 
            // btnRemover
            // 
            btnRemover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemover.Depth = 0;
            btnRemover.HighEmphasis = true;
            btnRemover.Icon = null;
            btnRemover.Location = new Point(190, 17);
            btnRemover.Margin = new Padding(5, 8, 5, 8);
            btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.NoAccentTextColor = Color.Empty;
            btnRemover.Size = new Size(89, 36);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemover.UseAccentColor = false;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.Location = new Point(7, 17);
            btnAdicionar.Margin = new Padding(5, 8, 5, 8);
            btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(98, 36);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(908, 405);
            dataGridView1.TabIndex = 4;
            // 
            // EstoqueControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "EstoqueControl";
            Size = new Size(914, 600);
            Load += EstoqueControl_Load;
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnFiltrar;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltrar;
        private MaterialSkin.Controls.MaterialButton btbBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnRemover;
        private MaterialSkin.Controls.MaterialButton btnAdicionar;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton BtnAtualizarQtd;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
