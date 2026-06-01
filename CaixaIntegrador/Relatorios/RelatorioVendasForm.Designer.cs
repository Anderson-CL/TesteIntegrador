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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            lblResumo = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(10, 128);
            dataGridViewVendas.Margin = new Padding(3, 2, 3, 2);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.RowHeadersWidth = 51;
            dataGridViewVendas.Size = new Size(540, 144);
            dataGridViewVendas.TabIndex = 0;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(36, 64);
            dtInicio.Margin = new Padding(3, 2, 3, 2);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(219, 23);
            dtInicio.TabIndex = 1;
            // 
            // dtFim
            // 
            dtFim.Location = new Point(331, 64);
            dtFim.Margin = new Padding(3, 2, 3, 2);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(219, 23);
            dtFim.TabIndex = 2;
            // 
            // btnRelatorio
            // 
            btnRelatorio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRelatorio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRelatorio.Depth = 0;
            btnRelatorio.HighEmphasis = true;
            btnRelatorio.Icon = null;
            btnRelatorio.Location = new Point(602, 51);
            btnRelatorio.Margin = new Padding(4);
            btnRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.NoAccentTextColor = Color.Empty;
            btnRelatorio.Size = new Size(68, 36);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.Text = "Gerar";
            btnRelatorio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRelatorio.UseAccentColor = false;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 64);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(24, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "De:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(297, 64);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(28, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Até:";
            // 
            // lblResumo
            // 
            lblResumo.AutoSize = true;
            lblResumo.Depth = 0;
            lblResumo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblResumo.Location = new Point(10, 291);
            lblResumo.MouseState = MaterialSkin.MouseState.HOVER;
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(59, 19);
            lblResumo.TabIndex = 6;
            lblResumo.Text = "Resumo";
            // 
            // RelatorioVendasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(691, 376);
            Controls.Add(lblResumo);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(btnRelatorio);
            Controls.Add(dtFim);
            Controls.Add(dtInicio);
            Controls.Add(dataGridViewVendas);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RelatorioVendasForm";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioVendasForm";
            Load += RelatorioVendasForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVendas;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFim;
        private MaterialSkin.Controls.MaterialButton btnRelatorio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblResumo;
    }
}