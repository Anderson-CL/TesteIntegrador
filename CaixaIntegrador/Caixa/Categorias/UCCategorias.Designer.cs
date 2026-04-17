namespace CaixaIntegrador
{
    partial class UCCategorias
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
            panel1 = new Panel();
            panelLeft = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            FlowCategorias = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelLeft);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 40);
            panel1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            // 
            // panelLeft
            // 
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(77, 40);
            panelLeft.TabIndex = 3;
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
            // FlowCategorias
            // 
            FlowCategorias.Dock = DockStyle.Fill;
            FlowCategorias.Location = new Point(0, 40);
            FlowCategorias.Name = "FlowCategorias";
            FlowCategorias.Size = new Size(600, 360);
            FlowCategorias.TabIndex = 2;
            // 
            // UCCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowCategorias);
            Controls.Add(panel1);
            Name = "UCCategorias";
            Size = new Size(600, 400);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelLeft;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlowLayoutPanel FlowCategorias;
    }
}
