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
            panelPrincipal.Location = new Point(6, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1442, 887);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panelPrincipal);
            FormStyle = FormStyles.ActionBar_None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaginaInicial";
            Padding = new Padding(3, 32, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaginaInicial";
            Load += PaginaInicial_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
    }
}