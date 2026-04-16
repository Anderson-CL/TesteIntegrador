using MaterialSkin.Controls;

namespace CaixaIntegrador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new MaterialCard();
            btn_Pedido = new MaterialButton();
            btnLimparCarrinho = new MaterialButton();
            btnDeletarMarcados = new MaterialButton();
            DataGrid_Produtos = new DataGridView();
            Column5 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btn_PedidoAberto = new MaterialButton();
            groupBox2 = new MaterialCard();
            PanelBtnPag = new MaterialCard();
            label1 = new MaterialLabel();
            materialRadioButton1 = new MaterialRadioButton();
            materialRadioButton2 = new MaterialRadioButton();
            materialRadioButton3 = new MaterialRadioButton();
            materialRadioButton4 = new MaterialRadioButton();
            materialRadioButton5 = new MaterialRadioButton();
            btn_Limparpag = new MaterialButton();
            troco_label = new MaterialLabel();
            btnAdicionarPagamento = new MaterialButton();
            lblValorPago = new MaterialLabel();
            Valores_MaterialTextBox = new MaterialTextBox2();
            btn_FinalizarPedido = new MaterialButton();
            lblTotal_Text = new MaterialLabel();
            panelPrincipal = new MaterialCard();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).BeginInit();
            groupBox2.SuspendLayout();
            PanelBtnPag.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 255);
            groupBox1.Controls.Add(btn_Pedido);
            groupBox1.Controls.Add(btnLimparCarrinho);
            groupBox1.Controls.Add(btnDeletarMarcados);
            groupBox1.Controls.Add(DataGrid_Produtos);
            groupBox1.Depth = 0;
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox1.Location = new Point(3, 24);
            groupBox1.Margin = new Padding(14);
            groupBox1.MouseState = MaterialSkin.MouseState.HOVER;
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(14);
            groupBox1.Size = new Size(322, 654);
            groupBox1.TabIndex = 0;
            groupBox1.Text = "groupBox1";
            // 
            // btn_Pedido
            // 
            btn_Pedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Pedido.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_Pedido.Depth = 0;
            btn_Pedido.HighEmphasis = true;
            btn_Pedido.Icon = null;
            btn_Pedido.Location = new Point(108, 614);
            btn_Pedido.Margin = new Padding(4, 6, 4, 6);
            btn_Pedido.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Pedido.Name = "btn_Pedido";
            btn_Pedido.NoAccentTextColor = Color.Empty;
            btn_Pedido.Size = new Size(82, 36);
            btn_Pedido.TabIndex = 3;
            btn_Pedido.Text = "Pedidos";
            btn_Pedido.Type = MaterialButton.MaterialButtonType.Contained;
            btn_Pedido.UseAccentColor = false;
            btn_Pedido.UseVisualStyleBackColor = true;
            btn_Pedido.Click += btn_Pedido_Click;
            // 
            // btnLimparCarrinho
            // 
            btnLimparCarrinho.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimparCarrinho.BackColor = Color.Red;
            btnLimparCarrinho.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLimparCarrinho.Depth = 0;
            btnLimparCarrinho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimparCarrinho.ForeColor = Color.White;
            btnLimparCarrinho.HighEmphasis = true;
            btnLimparCarrinho.Icon = null;
            btnLimparCarrinho.Location = new Point(18, 540);
            btnLimparCarrinho.Margin = new Padding(4, 6, 4, 6);
            btnLimparCarrinho.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimparCarrinho.Name = "btnLimparCarrinho";
            btnLimparCarrinho.NoAccentTextColor = Color.Empty;
            btnLimparCarrinho.Size = new Size(151, 36);
            btnLimparCarrinho.TabIndex = 2;
            btnLimparCarrinho.Text = "Limpar Carrinho";
            btnLimparCarrinho.Type = MaterialButton.MaterialButtonType.Contained;
            btnLimparCarrinho.UseAccentColor = false;
            btnLimparCarrinho.UseVisualStyleBackColor = false;
            btnLimparCarrinho.Click += BtnLimparCarrinho_Click;
            // 
            // btnDeletarMarcados
            // 
            btnDeletarMarcados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeletarMarcados.BackColor = Color.Orange;
            btnDeletarMarcados.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDeletarMarcados.Depth = 0;
            btnDeletarMarcados.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeletarMarcados.ForeColor = Color.White;
            btnDeletarMarcados.HighEmphasis = true;
            btnDeletarMarcados.Icon = null;
            btnDeletarMarcados.Location = new Point(201, 540);
            btnDeletarMarcados.Margin = new Padding(4, 6, 4, 6);
            btnDeletarMarcados.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeletarMarcados.Name = "btnDeletarMarcados";
            btnDeletarMarcados.NoAccentTextColor = Color.Empty;
            btnDeletarMarcados.Size = new Size(84, 36);
            btnDeletarMarcados.TabIndex = 1;
            btnDeletarMarcados.Text = "Deletar";
            btnDeletarMarcados.Type = MaterialButton.MaterialButtonType.Contained;
            btnDeletarMarcados.UseAccentColor = false;
            btnDeletarMarcados.UseVisualStyleBackColor = false;
            btnDeletarMarcados.Click += BtnDeletarMarcados_Click;
            // 
            // DataGrid_Produtos
            // 
            DataGrid_Produtos.AllowUserToAddRows = false;
            DataGrid_Produtos.AllowUserToResizeColumns = false;
            DataGrid_Produtos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            DataGrid_Produtos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid_Produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(139, 38, 53);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGrid_Produtos.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid_Produtos.Dock = DockStyle.Top;
            DataGrid_Produtos.EnableHeadersVisualStyles = false;
            DataGrid_Produtos.GridColor = Color.FromArgb(80, 80, 80);
            DataGrid_Produtos.Location = new Point(14, 14);
            DataGrid_Produtos.Name = "DataGrid_Produtos";
            DataGrid_Produtos.RowHeadersVisible = false;
            DataGrid_Produtos.RowHeadersWidth = 35;
            DataGrid_Produtos.RowTemplate.Resizable = DataGridViewTriState.True;
            DataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGrid_Produtos.Size = new Size(294, 508);
            DataGrid_Produtos.TabIndex = 0;
            DataGrid_Produtos.CellEndEdit += DataGrid_Produtos_CellEndEdit;
            // 
            // Column5
            // 
            Column5.FillWeight = 35F;
            Column5.HeaderText = "X";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Produto";
            Column1.FillWeight = 89.42893F;
            Column1.HeaderText = "Produto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Qtd";
            Column2.FillWeight = 89.42893F;
            Column2.HeaderText = "Qtd";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Preco";
            Column3.FillWeight = 89.42893F;
            Column3.HeaderText = "Preco";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Total";
            Column4.FillWeight = 89.42893F;
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            // 
            // btn_PedidoAberto
            // 
            btn_PedidoAberto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_PedidoAberto.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_PedidoAberto.Depth = 0;
            btn_PedidoAberto.HighEmphasis = true;
            btn_PedidoAberto.Icon = null;
            btn_PedidoAberto.Location = new Point(37, 560);
            btn_PedidoAberto.Margin = new Padding(4, 6, 4, 6);
            btn_PedidoAberto.MouseState = MaterialSkin.MouseState.HOVER;
            btn_PedidoAberto.Name = "btn_PedidoAberto";
            btn_PedidoAberto.NoAccentTextColor = Color.Empty;
            btn_PedidoAberto.Size = new Size(157, 36);
            btn_PedidoAberto.TabIndex = 1;
            btn_PedidoAberto.Text = "Pedido em Aberto";
            btn_PedidoAberto.Type = MaterialButton.MaterialButtonType.Contained;
            btn_PedidoAberto.UseAccentColor = false;
            btn_PedidoAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 255);
            groupBox2.Controls.Add(PanelBtnPag);
            groupBox2.Controls.Add(btn_Limparpag);
            groupBox2.Controls.Add(troco_label);
            groupBox2.Controls.Add(btnAdicionarPagamento);
            groupBox2.Controls.Add(lblValorPago);
            groupBox2.Controls.Add(Valores_MaterialTextBox);
            groupBox2.Controls.Add(btn_FinalizarPedido);
            groupBox2.Controls.Add(btn_PedidoAberto);
            groupBox2.Controls.Add(lblTotal_Text);
            groupBox2.Depth = 0;
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            groupBox2.Location = new Point(992, 24);
            groupBox2.Margin = new Padding(14);
            groupBox2.MouseState = MaterialSkin.MouseState.HOVER;
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(14);
            groupBox2.Size = new Size(269, 654);
            groupBox2.TabIndex = 1;
            groupBox2.Text = "groupBox2";
            // 
            // PanelBtnPag
            // 
            PanelBtnPag.BackColor = Color.FromArgb(255, 255, 255);
            PanelBtnPag.BackgroundImageLayout = ImageLayout.None;
            PanelBtnPag.Controls.Add(label1);
            PanelBtnPag.Controls.Add(materialRadioButton1);
            PanelBtnPag.Controls.Add(materialRadioButton2);
            PanelBtnPag.Controls.Add(materialRadioButton3);
            PanelBtnPag.Controls.Add(materialRadioButton4);
            PanelBtnPag.Controls.Add(materialRadioButton5);
            PanelBtnPag.Depth = 0;
            PanelBtnPag.ForeColor = Color.FromArgb(222, 0, 0, 0);
            PanelBtnPag.Location = new Point(0, 0);
            PanelBtnPag.Margin = new Padding(14);
            PanelBtnPag.MouseState = MaterialSkin.MouseState.HOVER;
            PanelBtnPag.Name = "PanelBtnPag";
            PanelBtnPag.Padding = new Padding(14);
            PanelBtnPag.Size = new Size(269, 326);
            PanelBtnPag.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Depth = 0;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(17, 14);
            label1.MouseState = MaterialSkin.MouseState.HOVER;
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 2;
            label1.Text = "Formas de Pagamento";
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(23, 41);
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
            materialRadioButton1.CheckedChanged += materialRadioButton1_CheckedChanged;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(23, 91);
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
            materialRadioButton2.CheckedChanged += materialRadioButton2_CheckedChanged;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(23, 141);
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
            materialRadioButton3.CheckedChanged += materialRadioButton3_CheckedChanged;
            // 
            // materialRadioButton4
            // 
            materialRadioButton4.AutoSize = true;
            materialRadioButton4.Depth = 0;
            materialRadioButton4.Location = new Point(23, 191);
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
            materialRadioButton4.CheckedChanged += materialRadioButton4_CheckedChanged;
            // 
            // materialRadioButton5
            // 
            materialRadioButton5.AutoSize = true;
            materialRadioButton5.Depth = 0;
            materialRadioButton5.Location = new Point(23, 241);
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
            materialRadioButton5.CheckedChanged += materialRadioButton5_CheckedChanged;
            // 
            // btn_Limparpag
            // 
            btn_Limparpag.AutoSize = false;
            btn_Limparpag.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Limparpag.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_Limparpag.Depth = 0;
            btn_Limparpag.FlatStyle = FlatStyle.Popup;
            btn_Limparpag.HighEmphasis = true;
            btn_Limparpag.Icon = null;
            btn_Limparpag.Location = new Point(142, 498);
            btn_Limparpag.Margin = new Padding(4, 6, 4, 6);
            btn_Limparpag.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Limparpag.Name = "btn_Limparpag";
            btn_Limparpag.NoAccentTextColor = Color.Empty;
            btn_Limparpag.Size = new Size(110, 40);
            btn_Limparpag.TabIndex = 13;
            btn_Limparpag.Text = "Limpar";
            btn_Limparpag.Type = MaterialButton.MaterialButtonType.Contained;
            btn_Limparpag.UseAccentColor = false;
            btn_Limparpag.UseVisualStyleBackColor = true;
            btn_Limparpag.Click += btn_Limparpag_Click;
            // 
            // troco_label
            // 
            troco_label.AutoSize = true;
            troco_label.Depth = 0;
            troco_label.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            troco_label.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            troco_label.Location = new Point(6, 447);
            troco_label.MouseState = MaterialSkin.MouseState.HOVER;
            troco_label.Name = "troco_label";
            troco_label.Size = new Size(46, 19);
            troco_label.TabIndex = 12;
            troco_label.Text = "Troco:";
            troco_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdicionarPagamento
            // 
            btnAdicionarPagamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionarPagamento.BackColor = Color.Green;
            btnAdicionarPagamento.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAdicionarPagamento.Depth = 0;
            btnAdicionarPagamento.FlatStyle = FlatStyle.Popup;
            btnAdicionarPagamento.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdicionarPagamento.ForeColor = Color.White;
            btnAdicionarPagamento.HighEmphasis = true;
            btnAdicionarPagamento.Icon = null;
            btnAdicionarPagamento.Location = new Point(6, 500);
            btnAdicionarPagamento.Margin = new Padding(4, 6, 4, 6);
            btnAdicionarPagamento.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            btnAdicionarPagamento.NoAccentTextColor = Color.Empty;
            btnAdicionarPagamento.Size = new Size(131, 36);
            btnAdicionarPagamento.TabIndex = 11;
            btnAdicionarPagamento.Text = "Adicionar Pag";
            btnAdicionarPagamento.Type = MaterialButton.MaterialButtonType.Contained;
            btnAdicionarPagamento.UseAccentColor = false;
            btnAdicionarPagamento.UseVisualStyleBackColor = false;
            btnAdicionarPagamento.Click += btnAdicionarPagamento_Click;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Depth = 0;
            lblValorPago.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblValorPago.Location = new Point(6, 376);
            lblValorPago.MouseState = MaterialSkin.MouseState.HOVER;
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(152, 19);
            lblValorPago.TabIndex = 10;
            lblValorPago.Text = "Pagamentos: R$ 0,00";
            // 
            // Valores_MaterialTextBox
            // 
            Valores_MaterialTextBox.AnimateReadOnly = false;
            Valores_MaterialTextBox.BackgroundImageLayout = ImageLayout.None;
            Valores_MaterialTextBox.CharacterCasing = CharacterCasing.Normal;
            Valores_MaterialTextBox.Depth = 0;
            Valores_MaterialTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Valores_MaterialTextBox.HideSelection = true;
            Valores_MaterialTextBox.LeadingIcon = null;
            Valores_MaterialTextBox.Location = new Point(0, 325);
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
            Valores_MaterialTextBox.Size = new Size(269, 48);
            Valores_MaterialTextBox.TabIndex = 9;
            Valores_MaterialTextBox.TabStop = false;
            Valores_MaterialTextBox.TextAlign = HorizontalAlignment.Left;
            Valores_MaterialTextBox.TrailingIcon = null;
            Valores_MaterialTextBox.UseSystemPasswordChar = false;
            Valores_MaterialTextBox.Enter += materialTextBox21_Enter;
            Valores_MaterialTextBox.KeyDown += materialTextBox21_KeyDown;
            Valores_MaterialTextBox.Leave += materialTextBox21_Leave;
            // 
            // btn_FinalizarPedido
            // 
            btn_FinalizarPedido.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_FinalizarPedido.Density = MaterialButton.MaterialButtonDensity.Default;
            btn_FinalizarPedido.Depth = 0;
            btn_FinalizarPedido.HighEmphasis = true;
            btn_FinalizarPedido.Icon = null;
            btn_FinalizarPedido.Location = new Point(65, 614);
            btn_FinalizarPedido.Margin = new Padding(4, 6, 4, 6);
            btn_FinalizarPedido.MouseState = MaterialSkin.MouseState.HOVER;
            btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            btn_FinalizarPedido.NoAccentTextColor = Color.Empty;
            btn_FinalizarPedido.Size = new Size(149, 36);
            btn_FinalizarPedido.TabIndex = 0;
            btn_FinalizarPedido.Text = "Finalizar Pedido";
            btn_FinalizarPedido.Type = MaterialButton.MaterialButtonType.Contained;
            btn_FinalizarPedido.UseAccentColor = true;
            btn_FinalizarPedido.UseVisualStyleBackColor = true;
            btn_FinalizarPedido.Click += btn_FinalizarPedido_Click;
            // 
            // lblTotal_Text
            // 
            lblTotal_Text.AutoSize = true;
            lblTotal_Text.Depth = 0;
            lblTotal_Text.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotal_Text.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTotal_Text.Location = new Point(6, 406);
            lblTotal_Text.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal_Text.Name = "lblTotal_Text";
            lblTotal_Text.Size = new Size(86, 41);
            lblTotal_Text.TabIndex = 0;
            lblTotal_Text.Text = "Total:";
            lblTotal_Text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(255, 255, 255);
            panelPrincipal.Depth = 0;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panelPrincipal.Location = new Point(325, 24);
            panelPrincipal.Margin = new Padding(14);
            panelPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(14);
            panelPrincipal.Size = new Size(667, 654);
            panelPrincipal.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelPrincipal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "Form1";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            PanelBtnPag.ResumeLayout(false);
            PanelBtnPag.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialCard groupBox1;
        private MaterialCard groupBox2;
        private MaterialCard panelPrincipal;
        private MaterialLabel lblTotal_Text;
        private MaterialButton btnDeletarMarcados;
        private MaterialButton btnLimparCarrinho;
        private DataGridView DataGrid_Produtos;
        private MaterialButton btn_FinalizarPedido;
        private MaterialButton btn_Pedido;
        private MaterialButton btn_PedidoAberto;
        private MaterialLabel label1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialTextBox2 Valores_MaterialTextBox;
        private MaterialLabel lblValorPago;
        private MaterialButton btnAdicionarPagamento;
        private MaterialLabel troco_label;
        private MaterialSkin.Controls.MaterialButton btn_Limparpag;
        private MaterialCard PanelBtnPag;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
