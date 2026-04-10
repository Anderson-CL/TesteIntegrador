using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public class ImpressoraNormal : ImpressoraBase
    {
        public override void ImprimirNFC(Pedido pedido)
        {
            var doc = new PrintDocument();
            doc.PrintPage += (s, e) => DesenharNota(e, pedido);
            doc.Print();
        }
    }
}
