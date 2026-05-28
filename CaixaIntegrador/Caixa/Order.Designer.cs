namespace CaixaIntegrador
{
    partial class Order
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Krypton.Toolkit.KryptonDataGridViewIconColumn.ColumnButtonSpec columnButtonSpec1 = new Krypton.Toolkit.KryptonDataGridViewIconColumn.ColumnButtonSpec();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tab_aberto = new TabPage();
            tab_finalizado = new TabPage();
            GridViewFinalizados = new Krypton.Toolkit.KryptonDataGridView();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnNFC = new Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            materialTabControl1.SuspendLayout();
            tab_finalizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewFinalizados).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tab_aberto);
            materialTabControl1.Controls.Add(tab_finalizado);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Bottom;
            materialTabControl1.ItemSize = new Size(100, 40);
            materialTabControl1.Location = new Point(0, 67);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.Padding = new Point(50, 10);
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(595, 383);
            materialTabControl1.SizeMode = TabSizeMode.FillToRight;
            materialTabControl1.TabIndex = 2;
            // 
            // tab_aberto
            // 
            tab_aberto.Location = new Point(4, 44);
            tab_aberto.Name = "tab_aberto";
            tab_aberto.Size = new Size(587, 335);
            tab_aberto.TabIndex = 2;
            tab_aberto.Text = "Pedidos Abertos";
            tab_aberto.UseVisualStyleBackColor = true;
            // 
            // tab_finalizado
            // 
            tab_finalizado.Controls.Add(GridViewFinalizados);
            tab_finalizado.Location = new Point(4, 44);
            tab_finalizado.Name = "tab_finalizado";
            tab_finalizado.Padding = new Padding(3);
            tab_finalizado.Size = new Size(587, 335);
            tab_finalizado.TabIndex = 1;
            tab_finalizado.Text = "Pedidos Finalizados";
            tab_finalizado.UseVisualStyleBackColor = true;
            // 
            // GridViewFinalizados
            // 
            GridViewFinalizados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            GridViewFinalizados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            GridViewFinalizados.BorderStyle = BorderStyle.None;
            GridViewFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GridViewFinalizados.Columns.AddRange(new DataGridViewColumn[] { column1, Column2, Column3, Column4, Column5, btnNFC });
            GridViewFinalizados.Dock = DockStyle.Fill;
            GridViewFinalizados.Location = new Point(3, 3);
            GridViewFinalizados.Margin = new Padding(0);
            GridViewFinalizados.Name = "GridViewFinalizados";
            GridViewFinalizados.RowHeadersVisible = false;
            GridViewFinalizados.Size = new Size(581, 329);
            GridViewFinalizados.StateCommon.Background.Color1 = Color.FromArgb(50, 50, 50);
            GridViewFinalizados.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            GridViewFinalizados.StateCommon.DataCell.Back.Color1 = Color.FromArgb(60, 60, 60);
            GridViewFinalizados.StateCommon.DataCell.Border.Color1 = Color.FromArgb(80, 80, 80);
            GridViewFinalizados.StateCommon.DataCell.Content.Color1 = SystemColors.Window;
            GridViewFinalizados.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(139, 38, 53);
            GridViewFinalizados.StateCommon.HeaderColumn.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            GridViewFinalizados.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            GridViewFinalizados.StateSelected.DataCell.Back.Color1 = Color.FromArgb(139, 38, 53);
            GridViewFinalizados.StateSelected.DataCell.Content.Color1 = Color.White;
            GridViewFinalizados.TabIndex = 0;
            GridViewFinalizados.CellContentClick += GridViewFinalizados_CellContentClick;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 24);
            materialTabSelector1.Margin = new Padding(0);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(595, 44);
            materialTabSelector1.TabIndex = 3;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // column1
            // 
            column1.HeaderText = "ID";
            column1.Name = "column1";
            column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Data";
            Column2.Name = "Column2";
            Column2.Width = 143;
            // 
            // Column3
            // 
            Column3.HeaderText = "Total";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Pagamento";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Detalhes";
            Column5.Name = "Column5";
            Column5.Width = 147;
            // 
            // btnNFC
            // 
            columnButtonSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Right;
            columnButtonSpec1.ExtraText = null;
            columnButtonSpec1.Icon = null;
            columnButtonSpec1.ImageTransparentColor = Color.FromArgb(192, 255, 192);
            columnButtonSpec1.Text = "Nota";
            columnButtonSpec1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            btnNFC.ButtonSpecs.Add(columnButtonSpec1);
            btnNFC.HeaderText = "NFC";
            btnNFC.Name = "btnNFC";
            btnNFC.Text = "";
            btnNFC.Width = 40;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(materialTabSelector1);
            Controls.Add(materialTabControl1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "Order";
            Padding = new Padding(0, 24, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            materialTabControl1.ResumeLayout(false);
            tab_finalizado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewFinalizados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tab_finalizado;
        private TabPage tab_aberto;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Krypton.Toolkit.KryptonDataGridView GridViewFinalizados;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Krypton.Toolkit.KryptonDataGridViewButtonColumn btnNFC;
    }
}