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
            btn_Pedido.Location = new Point(6, 559);
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
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Produto";
            Column1.FillWeight = 89.42893F;
            Column1.HeaderText = "Produto";
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
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            // 
            // btn_PedidoAberto
            // 
            btn_PedidoAberto.Location = new Point(21, 508);
            btn_PedidoAberto.Name = "btn_PedidoAberto";
            btn_PedidoAberto.Size = new Size(232, 43);
            btn_PedidoAberto.TabIndex = 1;
            btn_PedidoAberto.Text = "Pedido em Aberto";
            btn_PedidoAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btn_FinalizarPedido);
            groupBox2.Controls.Add(btn_PedidoAberto);
            groupBox2.Controls.Add(lblTotal_Text);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(999, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 681);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btn_FinalizarPedido
            // 
            btn_FinalizarPedido.Location = new Point(21, 602);
            btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            btn_FinalizarPedido.Size = new Size(232, 67);
            btn_FinalizarPedido.TabIndex = 0;
            btn_FinalizarPedido.Text = "Finalizar Pedido";
            btn_FinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // lblTotal_Text
            // 
            lblTotal_Text.AutoSize = true;
            lblTotal_Text.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal_Text.Location = new Point(92, 446);
            lblTotal_Text.Name = "lblTotal_Text";
            lblTotal_Text.Size = new Size(61, 29);
            lblTotal_Text.TabIndex = 0;
            lblTotal_Text.Text = "Total:";
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
    }
}
