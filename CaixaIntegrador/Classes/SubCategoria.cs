using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
 
    public class SubCategoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        // Uma subcategoria pode ter vários produtos
        public List<Produto> Produtos { get; set; }
    }
}
