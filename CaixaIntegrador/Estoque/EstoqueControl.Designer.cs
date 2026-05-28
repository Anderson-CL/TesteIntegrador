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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnFiltrar = new MaterialSkin.Controls.MaterialButton();
            cmbFiltrar = new MaterialSkin.Controls.MaterialComboBox();
            btbBuscar = new MaterialSkin.Controls.MaterialButton();
            txtBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            BtnAtualizarQtd = new MaterialSkin.Controls.MaterialButton();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox();
            btnRemover = new MaterialSkin.Controls.MaterialButton();
            btnAdicionar = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            panelCabecalho = new Panel();
            panel1 = new Panel();
            btnVoltar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelCabecalho.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = false;
            btnFiltrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFiltrar.Depth = 0;
            btnFiltrar.HighEmphasis = true;
            btnFiltrar.Icon = null;
            btnFiltrar.Location = new Point(604, 5);
            btnFiltrar.Margin = new Padding(4, 6, 4, 6);
            btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoAccentTextColor = Color.Empty;
            btnFiltrar.Size = new Size(95, 49);
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
            cmbFiltrar.Location = new Point(417, 6);
            cmbFiltrar.MaxDropDownItems = 4;
            cmbFiltrar.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltrar.Name = "cmbFiltrar";
            cmbFiltrar.Size = new Size(158, 49);
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
            btbBuscar.Location = new Point(155, 6);
            btbBuscar.Margin = new Padding(4, 6, 4, 6);
            btbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscar.Name = "btbBuscar";
            btbBuscar.NoAccentTextColor = Color.Empty;
            btbBuscar.Size = new Size(97, 48);
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
            txtBuscar.Location = new Point(11, 18);
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
            txtBuscar.Size = new Size(136, 36);
            txtBuscar.SkipLiterals = true;
            txtBuscar.TabIndex = 0;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.UseTallSize = false;
            txtBuscar.ValidatingType = null;
            // 
            // BtnAtualizarQtd
            // 
            BtnAtualizarQtd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAtualizarQtd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnAtualizarQtd.Depth = 0;
            BtnAtualizarQtd.HighEmphasis = true;
            BtnAtualizarQtd.Icon = null;
            BtnAtualizarQtd.Location = new Point(604, 15);
            BtnAtualizarQtd.Margin = new Padding(4, 6, 4, 6);
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
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BorderStyle = BorderStyle.None;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(464, 15);
            txtQuantidade.Margin = new Padding(3, 2, 3, 2);
            txtQuantidade.MaxLength = 50;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Multiline = false;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(122, 36);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.Text = "";
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseTallSize = false;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // btnRemover
            // 
            btnRemover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemover.Depth = 0;
            btnRemover.HighEmphasis = true;
            btnRemover.Icon = null;
            btnRemover.Location = new Point(316, 15);
            btnRemover.Margin = new Padding(4, 6, 4, 6);
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
            btnAdicionar.Location = new Point(198, 15);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(50, 50, 50);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 38, 53);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(139, 38, 53);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(80, 80, 80);
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(720, 305);
            dataGridView1.TabIndex = 4;
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.FromArgb(50, 50, 50);
            panelCabecalho.Controls.Add(btnFiltrar);
            panelCabecalho.Controls.Add(cmbFiltrar);
            panelCabecalho.Controls.Add(txtBuscar);
            panelCabecalho.Controls.Add(btbBuscar);
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Margin = new Padding(3, 2, 3, 2);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(720, 73);
            panelCabecalho.TabIndex = 5;
            panelCabecalho.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(BtnAtualizarQtd);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 376);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 84);
            panel1.TabIndex = 6;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSize = false;
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.Location = new Point(11, 15);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(80, 36);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVoltar.UseAccentColor = true;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(92, 15);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(98, 36);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // EstoqueControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelCabecalho);
            Controls.Add(dataGridView1);
            Margin = new Padding(0);
            Name = "EstoqueControl";
            Size = new Size(720, 460);
            Load += EstoqueControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelCabecalho.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnFiltrar;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltrar;
        private MaterialSkin.Controls.MaterialButton btbBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialButton btnRemover;
        private MaterialSkin.Controls.MaterialButton btnAdicionar;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton BtnAtualizarQtd;
        private MaterialSkin.Controls.MaterialTextBox txtQuantidade;
        private Panel panelCabecalho;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnVoltar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
    }
}
