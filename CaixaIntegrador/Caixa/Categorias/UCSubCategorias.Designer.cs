using MaterialSkin.Controls;

namespace CaixaIntegrador
{
    partial class UCSubCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSubCategorias));
            btnVoltar = new MaterialButton();
            panel1 = new Panel();
            materialLabel1 = new MaterialLabel();
            FlowSubCategorias = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.BackColor = Color.Crimson;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Density = MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.Dock = DockStyle.Left;
            btnVoltar.FlatAppearance.BorderColor = Color.Black;
            btnVoltar.FlatAppearance.BorderSize = 2;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Arial", 15F);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.BottomCenter;
            btnVoltar.Location = new Point(0, 0);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(77, 40);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlign = ContentAlignment.BottomCenter;
            btnVoltar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnVoltar.Type = MaterialButton.MaterialButtonType.Outlined;
            btnVoltar.UseAccentColor = false;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 40);
            panel1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.Location = new Point(0, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(600, 40);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Adega's";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlowSubCategorias
            // 
            FlowSubCategorias.Dock = DockStyle.Fill;
            FlowSubCategorias.Location = new Point(0, 40);
            FlowSubCategorias.Name = "FlowSubCategorias";
            FlowSubCategorias.Size = new Size(600, 360);
            FlowSubCategorias.TabIndex = 2;
            // 
            // UCSubCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowSubCategorias);
            Controls.Add(panel1);
            Name = "UCSubCategorias";
            Size = new Size(600, 400);
            Load += SubCategorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private MaterialButton btnVoltar;
       
        private MaterialLabel materialLabel1;
        private FlowLayoutPanel FlowSubCategorias;
    }
}
