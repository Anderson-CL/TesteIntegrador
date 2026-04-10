using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public abstract class ImpressoraBase
    {
        // Método que cada impressora implementa do seu jeito
        public abstract void ImprimirNFC(Pedido pedido);

        // Método compartilhado — qualquer impressora pode usar
        public void DesenharNota(PrintPageEventArgs e, Pedido pedido)
        {
            var fonte = new Font("Courier New", 8);
            var fonteBold = new Font("Courier New", 8, FontStyle.Bold);
            var brush = Brushes.Black;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float largura = e.MarginBounds.Width;
            float alturaLinha = fonte.GetHeight(e.Graphics);
            var centralize = new StringFormat { Alignment = StringAlignment.Center };

            e.Graphics.DrawString("MINHA LOJA", fonteBold, brush,
                new RectangleF(x, y, largura, alturaLinha * 2), centralize);
            y += alturaLinha * 2;

            e.Graphics.DrawString($"Pedido: #{pedido.Id}", fonte, brush, x, y); y += alturaLinha;
            e.Graphics.DrawString($"Data: {pedido.DataCriacao:dd/MM/yyyy HH:mm}", fonte, brush, x, y); y += alturaLinha;
            e.Graphics.DrawString(new string('-', 32), fonte, brush, x, y); y += alturaLinha;

            e.Graphics.DrawString("ITENS", fonteBold, brush, x, y); y += alturaLinha;
            foreach (var item in pedido.Itens)
            {
                e.Graphics.DrawString($"{item.Produto} x{item.Qtd}", fonte, brush, x, y); y += alturaLinha;
                e.Graphics.DrawString($"  R$ {item.Total:F2}", fonte, brush, x, y); y += alturaLinha;
            }

            e.Graphics.DrawString(new string('-', 32), fonte, brush, x, y); y += alturaLinha;
            e.Graphics.DrawString($"TOTAL: R$ {pedido.Total:F2}", fonteBold, brush, x, y); y += alturaLinha;

            foreach (var pagamento in pedido.Pagamentos)
            {
                e.Graphics.DrawString($"{pagamento.Forma}: R$ {pagamento.Valor:F2}", fonte, brush, x, y);
                y += alturaLinha;
            }

            if (pedido.Troco > 0)
            {
                e.Graphics.DrawString($"Troco: R$ {pedido.Troco:F2}", fonte, brush, x, y);
                y += alturaLinha;
            }

            e.Graphics.DrawString(new string('-', 32), fonte, brush, x, y); y += alturaLinha;
            e.Graphics.DrawString("Obrigado pela preferencia!", fonte, brush,
                new RectangleF(x, y, largura, alturaLinha), centralize);
        }
    }
}
