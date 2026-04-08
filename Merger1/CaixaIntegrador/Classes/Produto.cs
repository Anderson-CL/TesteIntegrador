using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int SubCategoriaId { get; set; }
        public decimal Preco { get; set; }
    }
}
