namespace CaixaIntegrador.Estoque
{
    partial class FrmAdicionarProduto
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
            txtNome = new MaterialSkin.Controls.MaterialTextBox2();
            nudPreco = new NumericUpDown();
            nudQuantidade = new NumericUpDown();
            cmbSubCategoria = new MaterialSkin.Controls.MaterialComboBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox23 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox24 = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBox25 = new MaterialSkin.Controls.MaterialTextBox2();
            nudQuantidade1 = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
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
            txtNome.Location = new Point(174, 91);
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
            txtNome.Size = new Size(230, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // nudPreco
            // 
            nudPreco.Location = new Point(66, 243);
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 1;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(459, 243);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 2;
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
            cmbSubCategoria.Location = new Point(585, 90);
            cmbSubCategoria.MaxDropDownItems = 4;
            cmbSubCategoria.MouseState = MaterialSkin.MouseState.OUT;
            cmbSubCategoria.Name = "cmbSubCategoria";
            cmbSubCategoria.Size = new Size(161, 49);
            cmbSubCategoria.StartIndex = 0;
            cmbSubCategoria.TabIndex = 3;
            cmbSubCategoria.SelectedIndexChanged += cbSubCategoria_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(350, 379);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(174, 379);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "salvar";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
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
            materialTextBox21.Location = new Point(6, 91);
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
            materialTextBox21.Size = new Size(162, 48);
            materialTextBox21.TabIndex = 6;
            materialTextBox21.TabStop = false;
            materialTextBox21.Text = "Nome do Produto";
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(446, 91);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(133, 48);
            materialTextBox22.TabIndex = 7;
            materialTextBox22.TabStop = false;
            materialTextBox22.Text = "Categoria:";
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
            // 
            // materialTextBox23
            // 
            materialTextBox23.AnimateReadOnly = false;
            materialTextBox23.BackgroundImageLayout = ImageLayout.None;
            materialTextBox23.CharacterCasing = CharacterCasing.Normal;
            materialTextBox23.Depth = 0;
            materialTextBox23.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox23.HideSelection = true;
            materialTextBox23.LeadingIcon = null;
            materialTextBox23.Location = new Point(66, 272);
            materialTextBox23.MaxLength = 32767;
            materialTextBox23.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox23.Name = "materialTextBox23";
            materialTextBox23.PasswordChar = '\0';
            materialTextBox23.PrefixSuffixText = null;
            materialTextBox23.ReadOnly = false;
            materialTextBox23.RightToLeft = RightToLeft.No;
            materialTextBox23.SelectedText = "";
            materialTextBox23.SelectionLength = 0;
            materialTextBox23.SelectionStart = 0;
            materialTextBox23.ShortcutsEnabled = true;
            materialTextBox23.Size = new Size(78, 48);
            materialTextBox23.TabIndex = 8;
            materialTextBox23.TabStop = false;
            materialTextBox23.Text = "Preço";
            materialTextBox23.TextAlign = HorizontalAlignment.Left;
            materialTextBox23.TrailingIcon = null;
            materialTextBox23.UseSystemPasswordChar = false;
            // 
            // materialTextBox24
            // 
            materialTextBox24.AnimateReadOnly = false;
            materialTextBox24.BackgroundImageLayout = ImageLayout.None;
            materialTextBox24.CharacterCasing = CharacterCasing.Normal;
            materialTextBox24.Depth = 0;
            materialTextBox24.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox24.HideSelection = true;
            materialTextBox24.LeadingIcon = null;
            materialTextBox24.Location = new Point(459, 272);
            materialTextBox24.MaxLength = 32767;
            materialTextBox24.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox24.Name = "materialTextBox24";
            materialTextBox24.PasswordChar = '\0';
            materialTextBox24.PrefixSuffixText = null;
            materialTextBox24.ReadOnly = false;
            materialTextBox24.RightToLeft = RightToLeft.No;
            materialTextBox24.SelectedText = "";
            materialTextBox24.SelectionLength = 0;
            materialTextBox24.SelectionStart = 0;
            materialTextBox24.ShortcutsEnabled = true;
            materialTextBox24.Size = new Size(120, 48);
            materialTextBox24.TabIndex = 9;
            materialTextBox24.TabStop = false;
            materialTextBox24.Text = "Quantidade";
            materialTextBox24.TextAlign = HorizontalAlignment.Left;
            materialTextBox24.TrailingIcon = null;
            materialTextBox24.UseSystemPasswordChar = false;
            // 
            // materialTextBox25
            // 
            materialTextBox25.AnimateReadOnly = false;
            materialTextBox25.BackgroundImageLayout = ImageLayout.None;
            materialTextBox25.CharacterCasing = CharacterCasing.Normal;
            materialTextBox25.Depth = 0;
            materialTextBox25.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox25.HideSelection = true;
            materialTextBox25.LeadingIcon = null;
            materialTextBox25.Location = new Point(66, 189);
            materialTextBox25.MaxLength = 32767;
            materialTextBox25.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox25.Name = "materialTextBox25";
            materialTextBox25.PasswordChar = '\0';
            materialTextBox25.PrefixSuffixText = null;
            materialTextBox25.ReadOnly = false;
            materialTextBox25.RightToLeft = RightToLeft.No;
            materialTextBox25.SelectedText = "";
            materialTextBox25.SelectionLength = 0;
            materialTextBox25.SelectionStart = 0;
            materialTextBox25.ShortcutsEnabled = true;
            materialTextBox25.Size = new Size(120, 36);
            materialTextBox25.TabIndex = 10;
            materialTextBox25.TabStop = false;
            materialTextBox25.Text = "materialTextBox25";
            materialTextBox25.TextAlign = HorizontalAlignment.Left;
            materialTextBox25.TrailingIcon = null;
            materialTextBox25.UseSystemPasswordChar = false;
            materialTextBox25.UseTallSize = false;
            // 
            // nudQuantidade1
            // 
            nudQuantidade1.AnimateReadOnly = false;
            nudQuantidade1.BackgroundImageLayout = ImageLayout.None;
            nudQuantidade1.CharacterCasing = CharacterCasing.Normal;
            nudQuantidade1.Depth = 0;
            nudQuantidade1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nudQuantidade1.HideSelection = true;
            nudQuantidade1.LeadingIcon = null;
            nudQuantidade1.Location = new Point(459, 189);
            nudQuantidade1.MaxLength = 32767;
            nudQuantidade1.MouseState = MaterialSkin.MouseState.OUT;
            nudQuantidade1.Name = "nudQuantidade1";
            nudQuantidade1.PasswordChar = '\0';
            nudQuantidade1.PrefixSuffixText = null;
            nudQuantidade1.ReadOnly = false;
            nudQuantidade1.RightToLeft = RightToLeft.No;
            nudQuantidade1.SelectedText = "";
            nudQuantidade1.SelectionLength = 0;
            nudQuantidade1.SelectionStart = 0;
            nudQuantidade1.ShortcutsEnabled = true;
            nudQuantidade1.Size = new Size(120, 36);
            nudQuantidade1.TabIndex = 10;
            nudQuantidade1.TabStop = false;
            nudQuantidade1.Text = "materialTextBox25";
            nudQuantidade1.TextAlign = HorizontalAlignment.Left;
            nudQuantidade1.TrailingIcon = null;
            nudQuantidade1.UseSystemPasswordChar = false;
            nudQuantidade1.UseTallSize = false;
            // 
            // FrmAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudQuantidade1);
            Controls.Add(materialTextBox25);
            Controls.Add(materialTextBox24);
            Controls.Add(materialTextBox23);
            Controls.Add(materialTextBox22);
            Controls.Add(materialTextBox21);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbSubCategoria);
            Controls.Add(nudQuantidade);
            Controls.Add(nudPreco);
            Controls.Add(txtNome);
            FormStyle = FormStyles.ActionBar_None;
            Name = "FrmAdicionarProduto";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FrmAdicionarProduto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private NumericUpDown nudPreco;
        private NumericUpDown nudQuantidade;
        private MaterialSkin.Controls.MaterialComboBox cmbSubCategoria;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox23;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox24;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox25;
        private MaterialSkin.Controls.MaterialTextBox2 nudQuantidade1;
    }
}