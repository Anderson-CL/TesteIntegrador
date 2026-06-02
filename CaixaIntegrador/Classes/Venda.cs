using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public class Venda
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal PrecoUnitario { get; set; }  // ← NOVO
        public decimal Subtotal { get; set; }  // ← NOVO
        public int? PedidoId { get; set; }  // ← NOVO

        public Produto Produto { get; set; }
    }
}
