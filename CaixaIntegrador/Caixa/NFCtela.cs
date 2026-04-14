using CaixaIntegrador.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador.Caixa
{
    public partial class NFCtela : Form
    {
        private Pedido NFCpedido;
        private ImpressoraBase NFCimpressora;
        private PrintDocument NFCdoc;
        public NFCtela(Pedido pedido)
        {
            InitializeComponent();
            NFCpedido = pedido;
            NFCimpressora = new ImpressoraNormal();

        }

        private void NFCtela_Load(object sender, EventArgs e)
        {

            NFCdoc = new PrintDocument();
            // Calcula a altura com base nos itens e pagamentos
            int linhasFixas = 10; // cabeçalho + data + separadores + total + rodapé
            int linhasItens = NFCpedido.Itens.Count*2; // cada item ocupa 2 linhas
            int linhasPagamentos = NFCpedido.Pagamentos.Count;
            int linhasTroco = NFCpedido.Troco > 0 ? 1 : 0;
            int totalLinhas = linhasFixas + linhasItens + linhasPagamentos + linhasTroco;

            // Cada linha tem aproximadamente 20 unidades de altura
            int alturaCalculada = totalLinhas * 20 + 100; // 100 de margem extra

            // Ajusta a altura do form proporcionalmente ao cupom
            int alturaForm = Math.Min(alturaCalculada + 150, 800); // 150 para os botões, máximo 800
            this.Size = new Size(350, alturaForm);

            NFCdoc.DefaultPageSettings.PaperSize = new PaperSize("Cupom", 300, alturaCalculada);
            NFCdoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            NFCdoc.PrintPage += (s, ev) => NFCimpressora.DesenharNota(ev, NFCpedido);
            PrintViewNFC.Document = NFCdoc;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            NFCdoc.Print();
            this.Close();
        }
    }
}
