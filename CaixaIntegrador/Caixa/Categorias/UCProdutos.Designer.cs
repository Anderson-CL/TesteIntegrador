using MaterialSkin.Controls;

namespace CaixaIntegrador
{
    partial class UCProdutos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProdutos));
            btnVoltar = new MaterialButton();
            pnlProdutos = new Panel();
            materialLabel1 = new MaterialLabel();
            FlowProdutos = new FlowLayoutPanel();
            pnlProdutos.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.BackColor = Color.Crimson;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Density = MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.FlatAppearance.BorderColor = Color.Black;
            btnVoltar.FlatAppearance.BorderSize = 2;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Arial", 15F);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.BottomCenter;
            btnVoltar.Location = new Point(5, 2);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(77, 36);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.BottomCenter;
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.Type = MaterialButton.MaterialButtonType.Outlined;
            btnVoltar.UseAccentColor = false;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // pnlProdutos
            // 
            pnlProdutos.Controls.Add(btnVoltar);
            pnlProdutos.Controls.Add(materialLabel1);
            pnlProdutos.Dock = DockStyle.Top;
            pnlProdutos.Location = new Point(0, 0);
            pnlProdutos.Name = "pnlProdutos";
            pnlProdutos.Size = new Size(600, 40);
            pnlProdutos.TabIndex = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Adega's";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            btnVoltar.Dock = DockStyle.Left;
            // 
            // FlowProdutos
            // 
            FlowProdutos.Dock = DockStyle.Fill;
            FlowProdutos.Location = new Point(0, 40);
            FlowProdutos.Name = "FlowProdutos";
            FlowProdutos.Size = new Size(600, 360);
            FlowProdutos.TabIndex = 1;
            // 
            // UCProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowProdutos);
            Controls.Add(pnlProdutos);
            Name = "UCProdutos";
            Size = new Size(600, 400);
            pnlProdutos.ResumeLayout(false);
            pnlProdutos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialButton btnVoltar;
        private Panel pnlProdutos;
        private MaterialLabel materialLabel1;
        private FlowLayoutPanel FlowProdutos;
    }
}
