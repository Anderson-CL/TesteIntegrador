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
            FlowProdutos = new FlowLayoutPanel();
            btnVoltar = new Button();
            FlowProdutos.SuspendLayout();
            SuspendLayout();
            // 
            // FlowProdutos
            // 
            FlowProdutos.Controls.Add(btnVoltar);
            FlowProdutos.Dock = DockStyle.Fill;
            FlowProdutos.Location = new Point(0, 0);
            FlowProdutos.Name = "FlowProdutos";
            FlowProdutos.Size = new Size(150, 150);
            FlowProdutos.TabIndex = 0;
            FlowProdutos.Paint += FlowProdutos_Paint;
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
            // UCProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowProdutos);
            Name = "UCProdutos";
            Load += Produtos_Load;
            FlowProdutos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowProdutos;
        private Button btnVoltar;
    }
}
