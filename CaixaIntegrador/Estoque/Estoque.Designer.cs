namespace CaixaIntegrador.estoque

{
    partial class Estoque
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            txtBuscar = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btbBuscar = new MaterialSkin.Controls.MaterialButton();
            cmbFiltrar = new MaterialSkin.Controls.MaterialComboBox();
            btnFiltrar = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnFiltrar);
            materialCard1.Controls.Add(cmbFiltrar);
            materialCard1.Controls.Add(btbBuscar);
            materialCard1.Controls.Add(txtBuscar);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 24);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(794, 61);
            materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialButton5);
            materialCard2.Controls.Add(materialButton4);
            materialCard2.Controls.Add(materialButton3);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Bottom;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(3, 393);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(794, 54);
            materialCard2.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.AllowPromptAsInput = true;
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.AsciiOnly = false;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.BeepOnError = false;
            txtBuscar.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.HidePromptOnLeave = false;
            txtBuscar.HideSelection = true;
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(4, 6);
            txtBuscar.Mask = "";
            txtBuscar.MaxLength = 32767;
            txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = '\0';
            txtBuscar.PrefixSuffixText = null;
            txtBuscar.PromptChar = '_';
            txtBuscar.ReadOnly = false;
            txtBuscar.RejectInputOnFirstFailure = false;
            txtBuscar.ResetOnPrompt = true;
            txtBuscar.ResetOnSpace = true;
            txtBuscar.RightToLeft = RightToLeft.No;
            txtBuscar.SelectedText = "";
            txtBuscar.SelectionLength = 0;
            txtBuscar.SelectionStart = 0;
            txtBuscar.ShortcutsEnabled = true;
            txtBuscar.Size = new Size(113, 48);
            txtBuscar.SkipLiterals = true;
            txtBuscar.TabIndex = 0;
            txtBuscar.TabStop = false;
            txtBuscar.Text = "Digite aqui";
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.ValidatingType = null;
            // 
            // btbBuscar
            // 
            btbBuscar.AutoSize = false;
            btbBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btbBuscar.Depth = 0;
            btbBuscar.HighEmphasis = true;
            btbBuscar.Icon = null;
            btbBuscar.Location = new Point(124, 6);
            btbBuscar.Margin = new Padding(4, 6, 4, 6);
            btbBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            btbBuscar.Name = "btbBuscar";
            btbBuscar.NoAccentTextColor = Color.Empty;
            btbBuscar.Size = new Size(97, 48);
            btbBuscar.TabIndex = 1;
            btbBuscar.Text = "Buscar";
            btbBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btbBuscar.UseAccentColor = false;
            btbBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbFiltrar
            // 
            cmbFiltrar.AutoResize = false;
            cmbFiltrar.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltrar.Depth = 0;
            cmbFiltrar.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltrar.DropDownHeight = 174;
            cmbFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrar.DropDownWidth = 121;
            cmbFiltrar.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltrar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltrar.FormattingEnabled = true;
            cmbFiltrar.IntegralHeight = false;
            cmbFiltrar.ItemHeight = 43;
            cmbFiltrar.Location = new Point(553, 6);
            cmbFiltrar.MaxDropDownItems = 4;
            cmbFiltrar.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltrar.Name = "cmbFiltrar";
            cmbFiltrar.Size = new Size(121, 49);
            cmbFiltrar.StartIndex = 0;
            cmbFiltrar.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = false;
            btnFiltrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFiltrar.Depth = 0;
            btnFiltrar.HighEmphasis = true;
            btnFiltrar.Icon = null;
            btnFiltrar.Location = new Point(681, 6);
            btnFiltrar.Margin = new Padding(4, 6, 4, 6);
            btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoAccentTextColor = Color.Empty;
            btnFiltrar.Size = new Size(95, 49);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFiltrar.UseAccentColor = false;
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(4, 9);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(98, 36);
            materialButton3.TabIndex = 0;
            materialButton3.Text = "Adicionar";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(352, 9);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(89, 36);
            materialButton4.TabIndex = 1;
            materialButton4.Text = "Remover";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(696, 9);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(80, 36);
            materialButton5.TabIndex = 2;
            materialButton5.Text = "Excluir";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "Estoque";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Estoque";
            materialCard1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnFiltrar;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltrar;
        private MaterialSkin.Controls.MaterialButton btbBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}