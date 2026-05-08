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
            cmbSubCategoria = new MaterialSkin.Controls.MaterialComboBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox2();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblProduto = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            label5 = new Label();
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
            txtNome.Location = new Point(82, 68);
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
            cmbSubCategoria.Location = new Point(470, 68);
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
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.CharacterCasing = CharacterCasing.Normal;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HideSelection = true;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(82, 182);
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
            txtPreco.Size = new Size(120, 36);
            txtPreco.TabIndex = 10;
            txtPreco.TabStop = false;
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.UseTallSize = false;
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
            txtQuantidade.Location = new Point(482, 172);
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
            txtQuantidade.Size = new Size(120, 36);
            txtQuantidade.TabIndex = 10;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            txtQuantidade.UseTallSize = false;
            txtQuantidade.Click += nudQuantidade1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 182);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 11;
            label1.Text = "Quantidade";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 192);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Preço";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 90);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Categoria";
            label3.Click += label1_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(26, 90);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 11;
            lblProduto.Text = "Produto";
            lblProduto.Click += label2_Click;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(492, 270);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 292);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 11;
            label5.Text = "SubCategoria";
            label5.Click += label1_Click;
            // 
            // FrmAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(materialComboBox1);
            Controls.Add(lblProduto);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbSubCategoria);
            Controls.Add(txtNome);
            FormStyle = FormStyles.ActionBar_None;
            Name = "FrmAdicionarProduto";
            Padding = new Padding(3, 24, 3, 3);
            Text = "FrmAdicionarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtNome;
        private MaterialSkin.Controls.MaterialComboBox cmbSubCategoria;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialTextBox2 txtPreco;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblProduto;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private Label label5;
    }
}