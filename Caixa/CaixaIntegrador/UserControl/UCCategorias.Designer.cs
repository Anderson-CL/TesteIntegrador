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
            FlowCategorias = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowCategorias
            // 
            FlowCategorias.Dock = DockStyle.Fill;
            FlowCategorias.Location = new Point(0, 0);
            FlowCategorias.Name = "FlowCategorias";
            FlowCategorias.Size = new Size(655, 468);
            FlowCategorias.TabIndex = 0;
            FlowCategorias.Paint += FlowCategorias_Paint;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowCategorias);
            Name = "Categorias";
            Size = new Size(655, 468);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowCategorias;
    }
}
