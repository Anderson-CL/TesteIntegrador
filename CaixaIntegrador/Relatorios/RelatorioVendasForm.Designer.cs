namespace CaixaIntegrador.Relatorios
{
    partial class RelatorioVendasForm
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
            dataGridViewVendas = new DataGridView();
            dtInicio = new DateTimePicker();
            dtFim = new DateTimePicker();
            btnRelatorio = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(70, 2);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.RowHeadersWidth = 51;
            dataGridViewVendas.Size = new Size(655, 301);
            dataGridViewVendas.TabIndex = 0;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(12, 328);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(250, 27);
            dtInicio.TabIndex = 1;
            // 
            // dtFim
            // 
            dtFim.Location = new Point(453, 328);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(250, 27);
            dtFim.TabIndex = 2;
            // 
            // btnRelatorio
            // 
            btnRelatorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRelatorio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRelatorio.Depth = 0;
            btnRelatorio.HighEmphasis = true;
            btnRelatorio.Icon = null;
            btnRelatorio.Location = new Point(325, 389);
            btnRelatorio.Margin = new Padding(4, 6, 4, 6);
            btnRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.NoAccentTextColor = Color.Empty;
            btnRelatorio.Size = new Size(149, 36);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "Gerar Relatorio";
            btnRelatorio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRelatorio.UseAccentColor = false;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // RelatorioVendasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRelatorio);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Controls.Add(dataGridViewVendas);
            Name = "RelatorioVendasForm";
            Text = "RelatorioVendasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVendas;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFim;
        private MaterialSkin.Controls.MaterialButton btnRelatorio;
    }
}