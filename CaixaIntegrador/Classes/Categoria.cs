using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
 

    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<SubCategoria> SubCategorias { get; set; }
    }

}
