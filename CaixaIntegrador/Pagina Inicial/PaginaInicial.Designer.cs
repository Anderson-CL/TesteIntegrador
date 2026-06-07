namespace CaixaIntegrador
{
    partial class PaginaInicial
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
            panelPrincipal = new Panel();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(3, 24);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1280, 717);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 744);
            Controls.Add(panelPrincipal);
            FormStyle = FormStyles.ActionBar_None;
            Name = "PaginaInicial";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaginaInicial";
            Load += PaginaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
    }
}