namespace CaixaIntegrador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            DataGrid_Produtos = new DataGridView();
            groupBox2 = new GroupBox();
            panelPrincipal = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(DataGrid_Produtos);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 681);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // DataGrid_Produtos
            // 
            DataGrid_Produtos.AllowUserToAddRows = false;
            DataGrid_Produtos.BackgroundColor = Color.White;
            DataGrid_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Produtos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            DataGrid_Produtos.Dock = DockStyle.Top;
            DataGrid_Produtos.EditMode = DataGridViewEditMode.EditOnEnter;
            DataGrid_Produtos.GridColor = Color.Black;
            DataGrid_Produtos.Location = new Point(3, 19);
            DataGrid_Produtos.Name = "DataGrid_Produtos";
            DataGrid_Produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid_Produtos.Size = new Size(274, 462);
            DataGrid_Produtos.TabIndex = 0;
            DataGrid_Produtos.CellEndEdit += DataGrid_Produtos_CellEndEdit;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(1001, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 681);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(280, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(721, 681);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panel1_Paint;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Produto";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 160;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Format = "N0";
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Qtd";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "C2";
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Preço";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 60;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelPrincipal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid_Produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panelPrincipal;
        private DataGridView DataGrid_Produtos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
