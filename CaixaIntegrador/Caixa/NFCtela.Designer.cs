namespace CaixaIntegrador.Caixa
{
    partial class NFCtela
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
            PrintViewNFC = new PrintPreviewControl();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnImprimir = new MaterialSkin.Controls.MaterialButton();
            btnFechar = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // PrintViewNFC
            // 
            PrintViewNFC.Dock = DockStyle.Fill;
            PrintViewNFC.Location = new Point(3, 24);
            PrintViewNFC.Name = "PrintViewNFC";
            PrintViewNFC.Size = new Size(350, 634);
            PrintViewNFC.TabIndex = 0;
            PrintViewNFC.Click += PrintViewNFC_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnImprimir);
            materialCard1.Controls.Add(btnFechar);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Bottom;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 608);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(350, 50);
            materialCard1.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.Location = new Point(177, 5);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnFechar
            // 
            btnFechar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFechar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFechar.Depth = 0;
            btnFechar.HighEmphasis = true;
            btnFechar.Icon = null;
            btnFechar.Location = new Point(51, 5);
            btnFechar.Margin = new Padding(4, 6, 4, 6);
            btnFechar.MouseState = MaterialSkin.MouseState.HOVER;
            btnFechar.Name = "btnFechar";
            btnFechar.NoAccentTextColor = Color.Empty;
            btnFechar.Size = new Size(77, 36);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFechar.UseAccentColor = false;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // NFCtela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 661);
            Controls.Add(materialCard1);
            Controls.Add(PrintViewNFC);
            FormStyle = FormStyles.ActionBar_None;
            Name = "NFCtela";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NFCtela";
            Load += NFCtela_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PrintPreviewControl PrintViewNFC;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnImprimir;
        private MaterialSkin.Controls.MaterialButton btnFechar;
    }
}