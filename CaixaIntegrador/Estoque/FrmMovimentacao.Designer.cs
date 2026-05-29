namespace CaixaIntegrador.Estoque
{
    partial class FrmMovimentacao
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
            lblNomeProduto = new MaterialSkin.Controls.MaterialLabel();
            lblQuantidade = new MaterialSkin.Controls.MaterialLabel();
            lblPreview = new MaterialSkin.Controls.MaterialLabel();
            txtObservacao = new MaterialSkin.Controls.MaterialTextBox2();
            txtQuantidade = new MaterialSkin.Controls.MaterialTextBox2();
            btnEntrada = new MaterialSkin.Controls.MaterialButton();
            btnSaida = new MaterialSkin.Controls.MaterialButton();
            btnAjuste = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            lblEstoqueAtual = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.BackColor = Color.FromArgb(50, 50, 50);
            lblNomeProduto.Depth = 0;
            lblNomeProduto.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblNomeProduto.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblNomeProduto.Location = new Point(38, 83);
            lblNomeProduto.MouseState = MaterialSkin.MouseState.HOVER;
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(72, 24);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.FromArgb(50, 50, 50);
            lblQuantidade.Depth = 0;
            lblQuantidade.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblQuantidade.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblQuantidade.Location = new Point(38, 186);
            lblQuantidade.MouseState = MaterialSkin.MouseState.HOVER;
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(104, 24);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.BackColor = Color.FromArgb(50, 50, 50);
            lblPreview.Depth = 0;
            lblPreview.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPreview.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblPreview.Location = new Point(38, 286);
            lblPreview.MouseState = MaterialSkin.MouseState.HOVER;
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(107, 24);
            lblPreview.TabIndex = 2;
            lblPreview.Text = "Observacao";
            // 
            // txtObservacao
            // 
            txtObservacao.AnimateReadOnly = false;
            txtObservacao.BackgroundImageLayout = ImageLayout.None;
            txtObservacao.CharacterCasing = CharacterCasing.Normal;
            txtObservacao.Depth = 0;
            txtObservacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservacao.HideSelection = true;
            txtObservacao.LeadingIcon = null;
            txtObservacao.Location = new Point(38, 324);
            txtObservacao.MaxLength = 32767;
            txtObservacao.MouseState = MaterialSkin.MouseState.OUT;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PasswordChar = '\0';
            txtObservacao.PrefixSuffixText = null;
            txtObservacao.ReadOnly = false;
            txtObservacao.RightToLeft = RightToLeft.No;
            txtObservacao.SelectedText = "";
            txtObservacao.SelectionLength = 0;
            txtObservacao.SelectionStart = 0;
            txtObservacao.ShortcutsEnabled = true;
            txtObservacao.Size = new Size(250, 48);
            txtObservacao.TabIndex = 3;
            txtObservacao.TabStop = false;
            txtObservacao.TextAlign = HorizontalAlignment.Left;
            txtObservacao.TrailingIcon = null;
            txtObservacao.UseSystemPasswordChar = false;
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
            txtQuantidade.Location = new Point(38, 223);
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
            txtQuantidade.Size = new Size(250, 48);
            txtQuantidade.TabIndex = 4;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            txtQuantidade.Click += txtQuantidade_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEntrada.Depth = 0;
            btnEntrada.HighEmphasis = true;
            btnEntrada.Icon = null;
            btnEntrada.Location = new Point(38, 134);
            btnEntrada.Margin = new Padding(4, 6, 4, 6);
            btnEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            btnEntrada.Name = "btnEntrada";
            btnEntrada.NoAccentTextColor = Color.Empty;
            btnEntrada.Size = new Size(87, 36);
            btnEntrada.TabIndex = 5;
            btnEntrada.Text = "Entrada";
            btnEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEntrada.UseAccentColor = false;
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaida.Depth = 0;
            btnSaida.HighEmphasis = true;
            btnSaida.Icon = null;
            btnSaida.Location = new Point(161, 134);
            btnSaida.Margin = new Padding(4, 6, 4, 6);
            btnSaida.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaida.Name = "btnSaida";
            btnSaida.NoAccentTextColor = Color.Empty;
            btnSaida.Size = new Size(64, 36);
            btnSaida.TabIndex = 6;
            btnSaida.Text = "Saida";
            btnSaida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaida.UseAccentColor = false;
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // btnAjuste
            // 
            btnAjuste.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAjuste.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAjuste.Depth = 0;
            btnAjuste.HighEmphasis = true;
            btnAjuste.Icon = null;
            btnAjuste.Location = new Point(258, 134);
            btnAjuste.Margin = new Padding(4, 6, 4, 6);
            btnAjuste.MouseState = MaterialSkin.MouseState.HOVER;
            btnAjuste.Name = "btnAjuste";
            btnAjuste.NoAccentTextColor = Color.Empty;
            btnAjuste.Size = new Size(75, 36);
            btnAjuste.TabIndex = 7;
            btnAjuste.Text = "AJUSTE";
            btnAjuste.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAjuste.UseAccentColor = false;
            btnAjuste.UseVisualStyleBackColor = true;
            btnAjuste.Click += btnAjuste_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(38, 381);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.Location = new Point(228, 381);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(105, 36);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblEstoqueAtual
            // 
            lblEstoqueAtual.AutoSize = true;
            lblEstoqueAtual.BackColor = Color.FromArgb(50, 50, 50);
            lblEstoqueAtual.Depth = 0;
            lblEstoqueAtual.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblEstoqueAtual.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblEstoqueAtual.Location = new Point(258, 77);
            lblEstoqueAtual.MouseState = MaterialSkin.MouseState.HOVER;
            lblEstoqueAtual.Name = "lblEstoqueAtual";
            lblEstoqueAtual.Size = new Size(120, 24);
            lblEstoqueAtual.TabIndex = 10;
            lblEstoqueAtual.Text = "EstoqueAtual";
            // 
            // FrmMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(lblEstoqueAtual);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAjuste);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(txtQuantidade);
            Controls.Add(txtObservacao);
            Controls.Add(lblPreview);
            Controls.Add(lblQuantidade);
            Controls.Add(lblNomeProduto);
            Name = "FrmMovimentacao";
            Text = "FrmMovimentacao";
            Load += FrmMovimentacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNomeProduto;
        private MaterialSkin.Controls.MaterialLabel lblQuantidade;
        private MaterialSkin.Controls.MaterialLabel lblPreview;
        private MaterialSkin.Controls.MaterialTextBox2 txtObservacao;
        private MaterialSkin.Controls.MaterialTextBox2 txtQuantidade;
        private MaterialSkin.Controls.MaterialButton btnEntrada;
        private MaterialSkin.Controls.MaterialButton btnSaida;
        private MaterialSkin.Controls.MaterialButton btnAjuste;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialLabel lblEstoqueAtual;
    }
}