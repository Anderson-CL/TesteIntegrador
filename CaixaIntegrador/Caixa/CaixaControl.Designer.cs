namespace CaixaIntegrador.Caixa
{
    partial class CaixaControl
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnLimparCarrinho = new MaterialSkin.Controls.MaterialButton();
            btn_Pedido = new MaterialSkin.Controls.MaterialButton();
            btnDeletarMarcados = new MaterialSkin.Controls.MaterialButton();
            DataGrid_Produtos = new DataGridView();
            Column5 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btn_FinalizarPedido = new MaterialSkin.Controls.MaterialButton();
            btn_Limparpag = new MaterialSkin.Controls.MaterialButton();
            btn_PedidoAberto = new MaterialSkin.Controls.MaterialButton();
            btnAdicionarPagamento = new MaterialSkin.Controls.MaterialButton();
            troco_label = new MaterialSkin.Controls.MaterialLabel();
            lblTotal_Text = new MaterialSkin.Controls.MaterialLabel();
            Valores_MaterialTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            PanelBtnPag = new Panel();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            label1 = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            lblValorPago = new MaterialSkin.Controls.MaterialLabel();
            panelPrincipal = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).BeginInit();
            groupBox2.SuspendLayout();
            PanelBtnPag.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimparCarrinho);
            groupBox1.Controls.Add(btn_Pedido);
            groupBox1.Controls.Add(btnDeletarMarcados);
            groupBox1.Controls.Add(DataGrid_Produtos);
            groupBox1.Location = new Point(0, 32);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 876);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLimparCarrinho
            // 
            btnLimparCarrinho.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimparCarrinho.AutoSize = false;
            btnLimparCarrinho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimparCarrinho.BackColor = Color.Red;
            btnLimparCarrinho.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimparCarrinho.Depth = 0;
            btnLimparCarrinho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimparCarrinho.ForeColor = Color.White;
            btnLimparCarrinho.HighEmphasis = true;
            btnLimparCarrinho.Icon = null;
            btnLimparCarrinho.Location = new Point(5, 697);
            btnLimparCarrinho.Margin = new Padding(5, 8, 5, 8);
            btnLimparCarrinho.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimparCarrinho.Name = "btnLimparCarrinho";
            btnLimparCarrinho.NoAccentTextColor = Color.Empty;
            btnLimparCarrinho.Size = new Size(175, 67);
            btnLimparCarrinho.TabIndex = 5;
            btnLimparCarrinho.Text = "Limpar Carrinho";
            btnLimparCarrinho.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimparCarrinho.UseAccentColor = false;
            btnLimparCarrinho.UseVisualStyleBackColor = false;
            btnLimparCarrinho.Click += btnLimparCarrinho_Click_1;
            // 
            // btn_Pedido
            // 
            btn_Pedido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Pedido.AutoSize = false;
            btn_Pedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Pedido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Pedido.Depth = 0;
            btn_Pedido.HighEmphasis = false;
            btn_Pedido.Icon = null;
            btn_Pedido.Location = new Point(5, 793);
            btn_Pedido.Margin = new Padding(5, 8, 5, 8);
            btn_Pedido.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Pedido.Name = "btn_Pedido";
            btn_Pedido.NoAccentTextColor = Color.Empty;
            btn_Pedido.Size = new Size(346, 67);
            btn_Pedido.TabIndex = 6;
            btn_Pedido.Text = "Pedidos";
            btn_Pedido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Pedido.UseAccentColor = true;
            btn_Pedido.UseVisualStyleBackColor = true;
            btn_Pedido.Click += btn_Pedido_Click_1;
            // 
            // btnDeletarMarcados
            // 
            btnDeletarMarcados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeletarMarcados.AutoSize = false;
            btnDeletarMarcados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletarMarcados.BackColor = Color.Orange;
            btnDeletarMarcados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeletarMarcados.Depth = 0;
            btnDeletarMarcados.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeletarMarcados.ForeColor = Color.White;
            btnDeletarMarcados.HighEmphasis = true;
            btnDeletarMarcados.Icon = null;
            btnDeletarMarcados.Location = new Point(192, 697);
            btnDeletarMarcados.Margin = new Padding(5, 8, 5, 8);
            btnDeletarMarcados.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletarMarcados.Name = "btnDeletarMarcados";
            btnDeletarMarcados.NoAccentTextColor = Color.Empty;
            btnDeletarMarcados.Size = new Size(175, 67);
            btnDeletarMarcados.TabIndex = 4;
            btnDeletarMarcados.Text = "Deletar";
            btnDeletarMarcados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeletarMarcados.UseAccentColor = false;
            btnDeletarMarcados.UseVisualStyleBackColor = false;
            btnDeletarMarcados.Click += btnDeletarMarcados_Click_1;
            // 
            // DataGrid_Produtos
            // 
            DataGrid_Produtos.AllowUserToAddRows = false;
            DataGrid_Produtos.AllowUserToResizeColumns = false;
            DataGrid_Produtos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            DataGrid_Produtos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid_Produtos.BackgroundColor = Color.FromArgb(50, 50, 50);
            DataGrid_Produtos.BorderStyle = BorderStyle.None;
            DataGrid_Produtos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(139, 38, 53);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGrid_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Produtos.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(139, 38, 53);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGrid_Produtos.DefaultCellStyle = dataGridViewCellStyle5;
            DataGrid_Produtos.EnableHeadersVisualStyles = false;
            DataGrid_Produtos.GridColor = Color.FromArgb(80, 80, 80);
            DataGrid_Produtos.Location = new Point(0, 0);
            DataGrid_Produtos.Margin = new Padding(3, 4, 3, 4);
            DataGrid_Produtos.Name = "DataGrid_Produtos";
            DataGrid_Produtos.RowHeadersVisible = false;
            DataGrid_Produtos.RowHeadersWidth = 35;
            DataGrid_Produtos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGrid_Produtos.RowTemplate.Resizable = DataGridViewTriState.False;
            DataGrid_Produtos.ScrollBars = ScrollBars.Vertical;
            DataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGrid_Produtos.Size = new Size(368, 685);
            DataGrid_Produtos.TabIndex = 1;
            DataGrid_Produtos.CellContentClick += DataGrid_Produtos_CellContentClick;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column5.FillWeight = 35F;
            Column5.HeaderText = "X";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 35;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.DataPropertyName = "Produto";
            Column1.FillWeight = 89.42893F;
            Column1.HeaderText = "Produto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.DataPropertyName = "Qtd";
            Column2.FillWeight = 89.42893F;
            Column2.HeaderText = "Qtd";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column3.DataPropertyName = "Preco";
            dataGridViewCellStyle3.Format = "C2";
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.FillWeight = 89.42893F;
            Column3.HeaderText = "Preco";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 65;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "C2";
            Column4.DefaultCellStyle = dataGridViewCellStyle4;
            Column4.FillWeight = 89.42893F;
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 70;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_FinalizarPedido);
            groupBox2.Controls.Add(btn_Limparpag);
            groupBox2.Controls.Add(btn_PedidoAberto);
            groupBox2.Controls.Add(btnAdicionarPagamento);
            groupBox2.Controls.Add(troco_label);
            groupBox2.Controls.Add(lblTotal_Text);
            groupBox2.Controls.Add(Valores_MaterialTextBox);
            groupBox2.Controls.Add(PanelBtnPag);
            groupBox2.Location = new Point(1136, 32);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 876);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn_FinalizarPedido
            // 
            btn_FinalizarPedido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_FinalizarPedido.AutoSize = false;
            btn_FinalizarPedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_FinalizarPedido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_FinalizarPedido.Depth = 0;
            btn_FinalizarPedido.HighEmphasis = true;
            btn_FinalizarPedido.Icon = null;
            btn_FinalizarPedido.Location = new Point(11, 740);
            btn_FinalizarPedido.Margin = new Padding(5, 8, 5, 8);
            btn_FinalizarPedido.MouseState = MaterialSkin.MouseState.HOVER;
            btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            btn_FinalizarPedido.NoAccentTextColor = Color.Empty;
            btn_FinalizarPedido.Size = new Size(289, 67);
            btn_FinalizarPedido.TabIndex = 14;
            btn_FinalizarPedido.Text = "Finalizar Pedido";
            btn_FinalizarPedido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_FinalizarPedido.UseAccentColor = true;
            btn_FinalizarPedido.UseVisualStyleBackColor = true;
            btn_FinalizarPedido.Click += btn_FinalizarPedido_Click_1;
            // 
            // btn_Limparpag
            // 
            btn_Limparpag.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Limparpag.AutoSize = false;
            btn_Limparpag.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Limparpag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Limparpag.Depth = 0;
            btn_Limparpag.FlatStyle = FlatStyle.Popup;
            btn_Limparpag.HighEmphasis = true;
            btn_Limparpag.Icon = null;
            btn_Limparpag.Location = new Point(176, 657);
            btn_Limparpag.Margin = new Padding(5, 8, 5, 8);
            btn_Limparpag.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Limparpag.Name = "btn_Limparpag";
            btn_Limparpag.NoAccentTextColor = Color.Empty;
            btn_Limparpag.Size = new Size(129, 67);
            btn_Limparpag.TabIndex = 19;
            btn_Limparpag.Text = "Limpar";
            btn_Limparpag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Limparpag.UseAccentColor = false;
            btn_Limparpag.UseVisualStyleBackColor = true;
            btn_Limparpag.Click += btn_Limparpag_Click_1;
            // 
            // btn_PedidoAberto
            // 
            btn_PedidoAberto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_PedidoAberto.AutoSize = false;
            btn_PedidoAberto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PedidoAberto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_PedidoAberto.Depth = 0;
            btn_PedidoAberto.HighEmphasis = false;
            btn_PedidoAberto.Icon = null;
            btn_PedidoAberto.Location = new Point(11, 820);
            btn_PedidoAberto.Margin = new Padding(5, 8, 5, 8);
            btn_PedidoAberto.MouseState = MaterialSkin.MouseState.HOVER;
            btn_PedidoAberto.Name = "btn_PedidoAberto";
            btn_PedidoAberto.NoAccentTextColor = Color.Empty;
            btn_PedidoAberto.Size = new Size(289, 48);
            btn_PedidoAberto.TabIndex = 16;
            btn_PedidoAberto.Text = "Pedido em Aberto";
            btn_PedidoAberto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_PedidoAberto.UseAccentColor = true;
            btn_PedidoAberto.UseVisualStyleBackColor = true;
            btn_PedidoAberto.Click += btn_PedidoAberto_Click;
            // 
            // btnAdicionarPagamento
            // 
            btnAdicionarPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdicionarPagamento.AutoSize = false;
            btnAdicionarPagamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarPagamento.BackColor = Color.Green;
            btnAdicionarPagamento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionarPagamento.Depth = 0;
            btnAdicionarPagamento.FlatStyle = FlatStyle.Popup;
            btnAdicionarPagamento.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdicionarPagamento.ForeColor = Color.White;
            btnAdicionarPagamento.HighEmphasis = true;
            btnAdicionarPagamento.Icon = null;
            btnAdicionarPagamento.Location = new Point(11, 657);
            btnAdicionarPagamento.Margin = new Padding(5, 8, 5, 8);
            btnAdicionarPagamento.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            btnAdicionarPagamento.NoAccentTextColor = Color.Empty;
            btnAdicionarPagamento.Size = new Size(153, 67);
            btnAdicionarPagamento.TabIndex = 17;
            btnAdicionarPagamento.Text = "Adicionar Pag";
            btnAdicionarPagamento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionarPagamento.UseAccentColor = true;
            btnAdicionarPagamento.UseVisualStyleBackColor = false;
            btnAdicionarPagamento.Click += btnAdicionarPagamento_Click_1;
            // 
            // troco_label
            // 
            troco_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            troco_label.AutoSize = true;
            troco_label.Depth = 0;
            troco_label.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            troco_label.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            troco_label.Location = new Point(3, 569);
            troco_label.MouseState = MaterialSkin.MouseState.HOVER;
            troco_label.Name = "troco_label";
            troco_label.Size = new Size(46, 19);
            troco_label.TabIndex = 18;
            troco_label.Text = "Troco:";
            troco_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal_Text
            // 
            lblTotal_Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal_Text.AutoSize = true;
            lblTotal_Text.Depth = 0;
            lblTotal_Text.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotal_Text.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTotal_Text.Location = new Point(3, 515);
            lblTotal_Text.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal_Text.Name = "lblTotal_Text";
            lblTotal_Text.Size = new Size(86, 41);
            lblTotal_Text.TabIndex = 15;
            lblTotal_Text.Text = "Total:";
            lblTotal_Text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Valores_MaterialTextBox
            // 
            Valores_MaterialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Valores_MaterialTextBox.AnimateReadOnly = false;
            Valores_MaterialTextBox.BackgroundImageLayout = ImageLayout.None;
            Valores_MaterialTextBox.CharacterCasing = CharacterCasing.Normal;
            Valores_MaterialTextBox.Depth = 0;
            Valores_MaterialTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Valores_MaterialTextBox.HideSelection = true;
            Valores_MaterialTextBox.LeadingIcon = null;
            Valores_MaterialTextBox.Location = new Point(3, 447);
            Valores_MaterialTextBox.Margin = new Padding(3, 4, 3, 4);
            Valores_MaterialTextBox.MaxLength = 32767;
            Valores_MaterialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            Valores_MaterialTextBox.Name = "Valores_MaterialTextBox";
            Valores_MaterialTextBox.PasswordChar = '\0';
            Valores_MaterialTextBox.PrefixSuffixText = null;
            Valores_MaterialTextBox.ReadOnly = false;
            Valores_MaterialTextBox.RightToLeft = RightToLeft.No;
            Valores_MaterialTextBox.SelectedText = "";
            Valores_MaterialTextBox.SelectionLength = 0;
            Valores_MaterialTextBox.SelectionStart = 0;
            Valores_MaterialTextBox.ShortcutsEnabled = true;
            Valores_MaterialTextBox.Size = new Size(305, 48);
            Valores_MaterialTextBox.TabIndex = 10;
            Valores_MaterialTextBox.TabStop = false;
            Valores_MaterialTextBox.TextAlign = HorizontalAlignment.Left;
            Valores_MaterialTextBox.TrailingIcon = null;
            Valores_MaterialTextBox.UseSystemPasswordChar = false;
            Valores_MaterialTextBox.Click += Valores_MaterialTextBox_Click;
            // 
            // PanelBtnPag
            // 
            PanelBtnPag.Controls.Add(materialRadioButton3);
            PanelBtnPag.Controls.Add(label1);
            PanelBtnPag.Controls.Add(materialRadioButton5);
            PanelBtnPag.Controls.Add(materialRadioButton1);
            PanelBtnPag.Controls.Add(materialRadioButton4);
            PanelBtnPag.Controls.Add(materialRadioButton2);
            PanelBtnPag.Controls.Add(lblValorPago);
            PanelBtnPag.Location = new Point(0, 0);
            PanelBtnPag.Margin = new Padding(3, 4, 3, 4);
            PanelBtnPag.Name = "PanelBtnPag";
            PanelBtnPag.Size = new Size(305, 449);
            PanelBtnPag.TabIndex = 1;
            PanelBtnPag.Paint += PanelBtnPag_Paint;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(18, 200);
            materialRadioButton3.Margin = new Padding(0);
            materialRadioButton3.MouseLocation = new Point(-1, -1);
            materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton3.Name = "materialRadioButton3";
            materialRadioButton3.Ripple = true;
            materialRadioButton3.Size = new Size(57, 37);
            materialRadioButton3.TabIndex = 5;
            materialRadioButton3.TabStop = true;
            materialRadioButton3.Text = "Pix";
            materialRadioButton3.UseVisualStyleBackColor = true;
            materialRadioButton3.CheckedChanged += materialRadioButton3_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            label1.Location = new Point(29, 13);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(203, 24);
            label1.TabIndex = 2;
            label1.Text = "Formas de Pagamento";
            // 
            // materialRadioButton5
            // 
            materialRadioButton5.AutoSize = true;
            materialRadioButton5.Depth = 0;
            materialRadioButton5.Location = new Point(18, 333);
            materialRadioButton5.Margin = new Padding(0);
            materialRadioButton5.MouseLocation = new Point(-1, -1);
            materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton5.Name = "materialRadioButton5";
            materialRadioButton5.Ripple = true;
            materialRadioButton5.Size = new Size(94, 37);
            materialRadioButton5.TabIndex = 7;
            materialRadioButton5.TabStop = true;
            materialRadioButton5.Text = "Dinheiro";
            materialRadioButton5.UseVisualStyleBackColor = true;
            materialRadioButton5.CheckedChanged += materialRadioButton5_CheckedChanged_1;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(18, 67);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(136, 37);
            materialRadioButton1.TabIndex = 3;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Cartão Crédito";
            materialRadioButton1.UseVisualStyleBackColor = true;
            materialRadioButton1.CheckedChanged += materialRadioButton1_CheckedChanged_1;
            // 
            // materialRadioButton4
            // 
            materialRadioButton4.AutoSize = true;
            materialRadioButton4.Depth = 0;
            materialRadioButton4.Location = new Point(18, 267);
            materialRadioButton4.Margin = new Padding(0);
            materialRadioButton4.MouseLocation = new Point(-1, -1);
            materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton4.Name = "materialRadioButton4";
            materialRadioButton4.Ripple = true;
            materialRadioButton4.Size = new Size(93, 37);
            materialRadioButton4.TabIndex = 6;
            materialRadioButton4.TabStop = true;
            materialRadioButton4.Text = "Voucher";
            materialRadioButton4.UseVisualStyleBackColor = true;
            materialRadioButton4.CheckedChanged += materialRadioButton4_CheckedChanged_1;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(18, 133);
            materialRadioButton2.Margin = new Padding(0);
            materialRadioButton2.MouseLocation = new Point(-1, -1);
            materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton2.Name = "materialRadioButton2";
            materialRadioButton2.Ripple = true;
            materialRadioButton2.Size = new Size(132, 37);
            materialRadioButton2.TabIndex = 4;
            materialRadioButton2.TabStop = true;
            materialRadioButton2.Text = "Cartão Débito";
            materialRadioButton2.UseVisualStyleBackColor = true;
            materialRadioButton2.CheckedChanged += materialRadioButton2_CheckedChanged_1;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Depth = 0;
            lblValorPago.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValorPago.Location = new Point(128, 417);
            lblValorPago.MouseState = MaterialSkin.MouseState.HOVER;
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(152, 19);
            lblValorPago.TabIndex = 10;
            lblValorPago.Text = "Pagamentos: R$ 0,00";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Location = new Point(371, 32);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(765, 876);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // CaixaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPrincipal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CaixaControl";
            Dock = DockStyle.Fill;
            Padding = new Padding(0, 32, 0, 0);
            Size = new Size(1445, 908);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            PanelBtnPag.ResumeLayout(false);
            PanelBtnPag.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panelPrincipal;
        private DataGridView DataGrid_Produtos;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialButton btnLimparCarrinho;
        private MaterialSkin.Controls.MaterialButton btn_Pedido;
        private MaterialSkin.Controls.MaterialButton btnDeletarMarcados;
        private Panel PanelBtnPag;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialLabel lblValorPago;
        private MaterialSkin.Controls.MaterialTextBox2 Valores_MaterialTextBox;
        private MaterialSkin.Controls.MaterialButton btn_FinalizarPedido;
        private MaterialSkin.Controls.MaterialButton btn_Limparpag;
        private MaterialSkin.Controls.MaterialButton btn_PedidoAberto;
        private MaterialSkin.Controls.MaterialButton btnAdicionarPagamento;
        private MaterialSkin.Controls.MaterialLabel troco_label;
        private MaterialSkin.Controls.MaterialLabel lblTotal_Text;
    }
}
