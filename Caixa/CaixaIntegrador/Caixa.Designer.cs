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
            groupBox1 = new GroupBox();
            btn_Pedido = new Button();
            btnLimparCarrinho = new Button();
            btnDeletarMarcados = new Button();
            DataGrid_Produtos = new DataGridView();
            Column5 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btn_PedidoAberto = new Button();
            groupBox2 = new GroupBox();
            btn_Limparpag = new MaterialSkin.Controls.MaterialButton();
            troco_label = new Label();
            btnAdicionarPagamento = new Button();
            lblValorPago = new Label();
            Valores_MaterialTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            label1 = new Label();
            btn_FinalizarPedido = new Button();
            lblTotal_Text = new Label();
            panelPrincipal = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btn_Pedido);
            groupBox1.Controls.Add(btnLimparCarrinho);
            groupBox1.Controls.Add(btnDeletarMarcados);
            groupBox1.Controls.Add(DataGrid_Produtos);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 681);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_Pedido
            // 
            btn_Pedido.Location = new Point(3, 614);
            btn_Pedido.Name = "btn_Pedido";
            btn_Pedido.Size = new Size(313, 61);
            btn_Pedido.TabIndex = 3;
            btn_Pedido.Text = "Pedidos";
            btn_Pedido.UseVisualStyleBackColor = true;
            btn_Pedido.Click += btn_Pedido_Click;
            // 
            // btnLimparCarrinho
            // 
            btnLimparCarrinho.BackColor = Color.Red;
            btnLimparCarrinho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimparCarrinho.ForeColor = Color.White;
            btnLimparCarrinho.Location = new Point(3, 481);
            btnLimparCarrinho.Name = "btnLimparCarrinho";
            btnLimparCarrinho.Size = new Size(160, 70);
            btnLimparCarrinho.TabIndex = 2;
            btnLimparCarrinho.Text = "Limpar Carrinho";
            btnLimparCarrinho.UseVisualStyleBackColor = false;
            btnLimparCarrinho.Click += BtnLimparCarrinho_Click;
            // 
            // btnDeletarMarcados
            // 
            btnDeletarMarcados.BackColor = Color.Orange;
            btnDeletarMarcados.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDeletarMarcados.ForeColor = Color.White;
            btnDeletarMarcados.Location = new Point(162, 481);
            btnDeletarMarcados.Name = "btnDeletarMarcados";
            btnDeletarMarcados.Size = new Size(160, 70);
            btnDeletarMarcados.TabIndex = 1;
            btnDeletarMarcados.Text = "Deletar";
            btnDeletarMarcados.UseVisualStyleBackColor = false;
            btnDeletarMarcados.Click += BtnDeletarMarcados_Click;
            // 
            // DataGrid_Produtos
            // 
            DataGrid_Produtos.AllowUserToAddRows = false;
            DataGrid_Produtos.AllowUserToResizeColumns = false;
            DataGrid_Produtos.AllowUserToResizeRows = false;
            DataGrid_Produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Produtos.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            DataGrid_Produtos.Dock = DockStyle.Top;
            DataGrid_Produtos.Location = new Point(3, 19);
            DataGrid_Produtos.Name = "DataGrid_Produtos";
            DataGrid_Produtos.RowHeadersVisible = false;
            DataGrid_Produtos.RowHeadersWidth = 35;
            DataGrid_Produtos.RowTemplate.Resizable = DataGridViewTriState.True;
            DataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGrid_Produtos.Size = new Size(316, 456);
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
            dataGridViewCellStyle1.Format = "N0";
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.FillWeight = 89.42893F;
            Column2.HeaderText = "Qtd";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Format = "C2";
            Column3.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Format = "C2";
            Column4.DefaultCellStyle = dataGridViewCellStyle3;
            Column4.FillWeight = 89.42893F;
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            // 
            // btn_PedidoAberto
            // 
            btn_PedidoAberto.Location = new Point(21, 527);
            btn_PedidoAberto.Name = "btn_PedidoAberto";
            btn_PedidoAberto.Size = new Size(232, 43);
            btn_PedidoAberto.TabIndex = 1;
            btn_PedidoAberto.Text = "Pedido em Aberto";
            btn_PedidoAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btn_Limparpag);
            groupBox2.Controls.Add(troco_label);
            groupBox2.Controls.Add(btnAdicionarPagamento);
            groupBox2.Controls.Add(lblValorPago);
            groupBox2.Controls.Add(Valores_MaterialTextBox);
            groupBox2.Controls.Add(materialRadioButton5);
            groupBox2.Controls.Add(materialRadioButton4);
            groupBox2.Controls.Add(materialRadioButton3);
            groupBox2.Controls.Add(materialRadioButton2);
            groupBox2.Controls.Add(materialRadioButton1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btn_FinalizarPedido);
            groupBox2.Controls.Add(btn_PedidoAberto);
            groupBox2.Controls.Add(lblTotal_Text);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(999, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 681);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn_Limparpag
            // 
            btn_Limparpag.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Limparpag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Limparpag.Depth = 0;
            btn_Limparpag.HighEmphasis = true;
            btn_Limparpag.Icon = null;
            btn_Limparpag.Location = new Point(177, 439);
            btn_Limparpag.Margin = new Padding(4, 6, 4, 6);
            btn_Limparpag.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Limparpag.Name = "btn_Limparpag";
            btn_Limparpag.NoAccentTextColor = Color.Empty;
            btn_Limparpag.Size = new Size(75, 36);
            btn_Limparpag.TabIndex = 13;
            btn_Limparpag.Text = "Limpar";
            btn_Limparpag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Limparpag.UseAccentColor = false;
            btn_Limparpag.UseVisualStyleBackColor = true;
            btn_Limparpag.Click += btn_Limparpag_Click;
            // 
            // troco_label
            // 
            troco_label.AutoSize = true;
            troco_label.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            troco_label.Location = new Point(6, 421);
            troco_label.Name = "troco_label";
            troco_label.Size = new Size(49, 37);
            troco_label.TabIndex = 12;
            troco_label.Text = "Troco:";
            // 
            // btnAdicionarPagamento
            // 
            btnAdicionarPagamento.BackColor = Color.Green;
            btnAdicionarPagamento.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdicionarPagamento.ForeColor = Color.White;
            btnAdicionarPagamento.Location = new Point(21, 481);
            btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            btnAdicionarPagamento.Size = new Size(232, 40);
            btnAdicionarPagamento.TabIndex = 11;
            btnAdicionarPagamento.Text = "Adicionar Pagamento";
            btnAdicionarPagamento.UseVisualStyleBackColor = false;
            btnAdicionarPagamento.Click += btnAdicionarPagamento_Click;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblValorPago.Location = new Point(6, 376);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(151, 16);
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
            Valores_MaterialTextBox.Location = new Point(6, 325);
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
            Valores_MaterialTextBox.Size = new Size(208, 48);
            Valores_MaterialTextBox.TabIndex = 9;
            Valores_MaterialTextBox.TabStop = false;
            Valores_MaterialTextBox.TextAlign = HorizontalAlignment.Left;
            Valores_MaterialTextBox.TrailingIcon = null;
            Valores_MaterialTextBox.UseSystemPasswordChar = false;
            Valores_MaterialTextBox.Enter += materialTextBox21_Enter;
            Valores_MaterialTextBox.KeyDown += materialTextBox21_KeyDown;
            Valores_MaterialTextBox.Leave += materialTextBox21_Leave;
            // 
            // materialRadioButton5
            // 
            materialRadioButton5.AutoSize = true;
            materialRadioButton5.Depth = 0;
            materialRadioButton5.Location = new Point(6, 260);
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
            // materialRadioButton4
            // 
            materialRadioButton4.AutoSize = true;
            materialRadioButton4.Depth = 0;
            materialRadioButton4.Location = new Point(6, 210);
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
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(6, 160);
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
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(6, 110);
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
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(6, 60);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 51);
            label1.TabIndex = 2;
            label1.Text = "Formas de Pagamento";
            // 
            // btn_FinalizarPedido
            // 
            btn_FinalizarPedido.Location = new Point(21, 608);
            btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            btn_FinalizarPedido.Size = new Size(232, 67);
            btn_FinalizarPedido.TabIndex = 0;
            btn_FinalizarPedido.Text = "Finalizar Pedido";
            btn_FinalizarPedido.UseVisualStyleBackColor = true;
            btn_FinalizarPedido.Click += btn_FinalizarPedido_Click;
            // 
            // lblTotal_Text
            // 
            lblTotal_Text.AutoSize = true;
            lblTotal_Text.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal_Text.Location = new Point(6, 392);
            lblTotal_Text.Name = "lblTotal_Text";
            lblTotal_Text.Size = new Size(61, 29);
            lblTotal_Text.TabIndex = 0;
            lblTotal_Text.Text = "Total:";
            lblTotal_Text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(322, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(677, 681);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panelPrincipal;
        private Label lblTotal_Text;
        private Button btnDeletarMarcados;
        private Button btnLimparCarrinho;
        private DataGridView DataGrid_Produtos;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btn_FinalizarPedido;
        private Button btn_Pedido;
        private Button btn_PedidoAberto;
        private Label label1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialTextBox2 Valores_MaterialTextBox;
        private Label lblValorPago;
        private Button btnAdicionarPagamento;
        private Label troco_label;
        private MaterialSkin.Controls.MaterialButton btn_Limparpag;
    }
}
