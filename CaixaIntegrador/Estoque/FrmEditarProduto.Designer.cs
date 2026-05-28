namespace CaixaIntegrador.Estoque
{
    partial class FrmEditarProduto
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
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cmbSubCategoria = new MaterialSkin.Controls.MaterialComboBox();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox2();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            cmbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(157, 268);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(104, 24);
            materialLabel5.TabIndex = 21;
            materialLabel5.Text = "Quantidade";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(22, 268);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(53, 24);
            materialLabel4.TabIndex = 22;
            materialLabel4.Text = "Preço";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(230, 157);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(119, 24);
            materialLabel3.TabIndex = 23;
            materialLabel3.Text = "Subcategoria";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(22, 157);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(88, 24);
            materialLabel2.TabIndex = 24;
            materialLabel2.Text = "Categoria";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(22, 64);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(72, 24);
            materialLabel1.TabIndex = 25;
            materialLabel1.Text = "Produto";
            // 
            // cmbSubCategoria
            // 
            cmbSubCategoria.AutoResize = false;
            cmbSubCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cmbSubCategoria.Depth = 0;
            cmbSubCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cmbSubCategoria.DropDownHeight = 174;
            cmbSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubCategoria.DropDownWidth = 121;
            cmbSubCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbSubCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbSubCategoria.FormattingEnabled = true;
            cmbSubCategoria.IntegralHeight = false;
            cmbSubCategoria.ItemHeight = 43;
            cmbSubCategoria.Location = new Point(230, 184);
            cmbSubCategoria.MaxDropDownItems = 4;
            cmbSubCategoria.MouseState = MaterialSkin.MouseState.OUT;
            cmbSubCategoria.Name = "cmbSubCategoria";
            cmbSubCategoria.Size = new Size(200, 49);
            cmbSubCategoria.StartIndex = 0;
            cmbSubCategoria.TabIndex = 20;
            cmbSubCategoria.SelectedIndexChanged += cmbSubCategoria_SelectedIndexChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(157, 295);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(100, 36);
            txtQuantidade.TabIndex = 18;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            txtQuantidade.UseTallSize = false;
            txtQuantidade.Click += txtQuantidade_Click;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(22, 295);
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.ReadOnly = false;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(100, 36);
            txtPreco.TabIndex = 19;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.UseTallSize = false;
            txtPreco.Click += txtPreco_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(315, 361);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(100, 80);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "salvar";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = true;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(22, 405);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoResize = false;
            cmbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategoria.Depth = 0;
            cmbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategoria.DropDownHeight = 174;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.DropDownWidth = 121;
            cmbCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.IntegralHeight = false;
            cmbCategoria.ItemHeight = 43;
            cmbCategoria.Location = new Point(22, 184);
            cmbCategoria.MaxDropDownItems = 4;
            cmbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(200, 49);
            cmbCategoria.StartIndex = 0;
            cmbCategoria.TabIndex = 15;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(22, 91);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = MaterialSkin.MouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(408, 48);
            txtNome.TabIndex = 14;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            txtNome.Click += txtNome_Click;
            // 
            // FrmEditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(cmbSubCategoria);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtNome);
            Name = "FrmEditarProduto";
            Text = "FrmEditarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbSubCategoria;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private MaterialSkin.Controls.MaterialTextBox2 txtPreco;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoria;
        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
    }
}