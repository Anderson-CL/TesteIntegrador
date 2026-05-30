namespace CaixaIntegrador.Estoque
{
    partial class FrmHistorico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cmbFiltroProduto = new MaterialSkin.Controls.MaterialComboBox();
            cmbFiltroTipo = new MaterialSkin.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            lblTotal = new MaterialSkin.Controls.MaterialLabel();
            btnFechar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(23, 79);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(129, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Filtrar por Produto";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(433, 79);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(105, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Filtrar por Tipo";
            // 
            // cmbFiltroProduto
            // 
            cmbFiltroProduto.AutoResize = false;
            cmbFiltroProduto.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltroProduto.Depth = 0;
            cmbFiltroProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltroProduto.DropDownHeight = 174;
            cmbFiltroProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroProduto.DropDownWidth = 121;
            cmbFiltroProduto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltroProduto.FormattingEnabled = true;
            cmbFiltroProduto.IntegralHeight = false;
            cmbFiltroProduto.ItemHeight = 43;
            cmbFiltroProduto.Location = new Point(23, 126);
            cmbFiltroProduto.MaxDropDownItems = 4;
            cmbFiltroProduto.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroProduto.Name = "cmbFiltroProduto";
            cmbFiltroProduto.Size = new Size(180, 49);
            cmbFiltroProduto.StartIndex = 0;
            cmbFiltroProduto.TabIndex = 2;
            cmbFiltroProduto.SelectedIndexChanged += cmbFiltroProduto_SelectedIndexChanged;
            // 
            // cmbFiltroTipo
            // 
            cmbFiltroTipo.AutoResize = false;
            cmbFiltroTipo.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltroTipo.Depth = 0;
            cmbFiltroTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltroTipo.DropDownHeight = 174;
            cmbFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroTipo.DropDownWidth = 121;
            cmbFiltroTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltroTipo.FormattingEnabled = true;
            cmbFiltroTipo.IntegralHeight = false;
            cmbFiltroTipo.ItemHeight = 43;
            cmbFiltroTipo.Location = new Point(433, 126);
            cmbFiltroTipo.MaxDropDownItems = 4;
            cmbFiltroTipo.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroTipo.Name = "cmbFiltroTipo";
            cmbFiltroTipo.Size = new Size(181, 49);
            cmbFiltroTipo.StartIndex = 0;
            cmbFiltroTipo.TabIndex = 3;
            cmbFiltroTipo.SelectedIndexChanged += cmbFiltroTipo_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(691, 181);
            dataGridView1.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Depth = 0;
            lblTotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotal.Location = new Point(34, 381);
            lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 19);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // btnFechar
            // 
            btnFechar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFechar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFechar.Depth = 0;
            btnFechar.HighEmphasis = true;
            btnFechar.Icon = null;
            btnFechar.Location = new Point(537, 371);
            btnFechar.Margin = new Padding(4, 6, 4, 6);
            btnFechar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFechar.Name = "btnFechar";
            btnFechar.NoAccentTextColor = Color.Empty;
            btnFechar.Size = new Size(77, 36);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFechar.UseAccentColor = false;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(720, 460);
            Controls.Add(btnFechar);
            Controls.Add(lblTotal);
            Controls.Add(dataGridView1);
            Controls.Add(cmbFiltroTipo);
            Controls.Add(cmbFiltroProduto);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "FrmHistorico";
            Text = "FrmHistorico";
            Load += FrmHistorico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroProduto;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroTipo;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialButton btnFechar;
    }
}