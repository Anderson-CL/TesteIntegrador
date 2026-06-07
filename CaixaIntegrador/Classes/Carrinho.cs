using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public class CarrinhoCompra
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }  // ← NOVO: necessário para salvar no banco
        public string Produto { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
        public decimal Total => Preco * Qtd;
    }
}
