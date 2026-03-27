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
            btnAdicionarPagamento = new Button();
            lblValorPago = new Label();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
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
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(368, 908);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btn_Pedido
            // 
            btn_Pedido.Location = new Point(3, 819);
            btn_Pedido.Margin = new Padding(3, 4, 3, 4);
            btn_Pedido.Name = "btn_Pedido";
            btn_Pedido.Size = new Size(358, 81);
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
            btnLimparCarrinho.Location = new Point(3, 641);
            btnLimparCarrinho.Margin = new Padding(3, 4, 3, 4);
            btnLimparCarrinho.Name = "btnLimparCarrinho";
            btnLimparCarrinho.Size = new Size(183, 93);
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
            btnDeletarMarcados.Location = new Point(185, 641);
            btnDeletarMarcados.Margin = new Padding(3, 4, 3, 4);
            btnDeletarMarcados.Name = "btnDeletarMarcados";
            btnDeletarMarcados.Size = new Size(183, 93);
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
            DataGrid_Produtos.Location = new Point(3, 24);
            DataGrid_Produtos.Margin = new Padding(3, 4, 3, 4);
            DataGrid_Produtos.Name = "DataGrid_Produtos";
            DataGrid_Produtos.RowHeadersVisible = false;
            DataGrid_Produtos.RowHeadersWidth = 35;
            DataGrid_Produtos.RowTemplate.Resizable = DataGridViewTriState.True;
            DataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGrid_Produtos.Size = new Size(362, 608);
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
            btn_PedidoAberto.Location = new Point(24, 677);
            btn_PedidoAberto.Margin = new Padding(3, 4, 3, 4);
            btn_PedidoAberto.Name = "btn_PedidoAberto";
            btn_PedidoAberto.Size = new Size(265, 57);
            btn_PedidoAberto.TabIndex = 1;
            btn_PedidoAberto.Text = "Pedido em Aberto";
            btn_PedidoAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btnAdicionarPagamento);
            groupBox2.Controls.Add(lblValorPago);
            groupBox2.Controls.Add(materialTextBox21);
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
            groupBox2.Location = new Point(1142, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(303, 908);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnAdicionarPagamento
            // 
            btnAdicionarPagamento.BackColor = Color.Green;
            btnAdicionarPagamento.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdicionarPagamento.ForeColor = Color.White;
            btnAdicionarPagamento.Location = new Point(7, 533);
            btnAdicionarPagamento.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            btnAdicionarPagamento.Size = new Size(282, 53);
            btnAdicionarPagamento.TabIndex = 11;
            btnAdicionarPagamento.Text = "Adicionar Pagamento";
            btnAdicionarPagamento.UseVisualStyleBackColor = false;
            btnAdicionarPagamento.Click += btnAdicionarPagamento_Click;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblValorPago.Location = new Point(7, 507);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(175, 19);
            lblValorPago.TabIndex = 10;
            lblValorPago.Text = "Pagamentos: R$ 0,00";
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(7, 433);
            materialTextBox21.Margin = new Padding(3, 4, 3, 4);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(238, 48);
            materialTextBox21.TabIndex = 9;
            materialTextBox21.TabStop = false;
            materialTextBox21.Text = "0,00";
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialRadioButton5
            // 
            materialRadioButton5.AutoSize = true;
            materialRadioButton5.Depth = 0;
            materialRadioButton5.Location = new Point(7, 347);
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
            // 
            // materialRadioButton4
            // 
            materialRadioButton4.AutoSize = true;
            materialRadioButton4.Depth = 0;
            materialRadioButton4.Location = new Point(7, 280);
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
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(7, 213);
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
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(7, 147);
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
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(7, 80);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 25);
            label1.Name = "label1";
            label1.Size = new Size(227, 64);
            label1.TabIndex = 2;
            label1.Text = "Formas de Pagamento";
            // 
            // btn_FinalizarPedido
            // 
            btn_FinalizarPedido.Location = new Point(24, 803);
            btn_FinalizarPedido.Margin = new Padding(3, 4, 3, 4);
            btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            btn_FinalizarPedido.Size = new Size(265, 89);
            btn_FinalizarPedido.TabIndex = 0;
            btn_FinalizarPedido.Text = "Finalizar Pedido";
            btn_FinalizarPedido.UseVisualStyleBackColor = true;
            btn_FinalizarPedido.Click += btn_FinalizarPedido_Click;
            // 
            // lblTotal_Text
            // 
            lblTotal_Text.AutoSize = true;
            lblTotal_Text.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal_Text.Location = new Point(7, 595);
            lblTotal_Text.Name = "lblTotal_Text";
            lblTotal_Text.Size = new Size(77, 35);
            lblTotal_Text.TabIndex = 0;
            lblTotal_Text.Text = "Total:";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(368, 0);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(774, 908);
            panelPrincipal.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panelPrincipal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private Label lblValorPago;
        private Button btnAdicionarPagamento;
    }
}
