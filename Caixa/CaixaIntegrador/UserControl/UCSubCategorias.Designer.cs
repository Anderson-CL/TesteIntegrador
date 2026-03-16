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
            FlowSubCategorias = new FlowLayoutPanel();
            btnVoltar = new Button();
            FlowSubCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // FlowSubCategorias
            // 
            FlowSubCategorias.Controls.Add(btnVoltar);
            FlowSubCategorias.Dock = DockStyle.Fill;
            FlowSubCategorias.Location = new Point(0, 0);
            FlowSubCategorias.Name = "FlowSubCategorias";
            FlowSubCategorias.Size = new Size(576, 397);
            FlowSubCategorias.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Crimson;
            btnVoltar.Font = new Font("Arial", 15F);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(3, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 120);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // UCSubCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowSubCategorias);
            Name = "UCSubCategorias";
            Size = new Size(576, 397);
            Load += SubCategorias_Load;
            FlowSubCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowSubCategorias;
        private Button btnVoltar;
    }
}
