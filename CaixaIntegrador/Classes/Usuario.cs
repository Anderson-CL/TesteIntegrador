using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        //public string Nome { get; set; }

        public string Privilegio { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
    }
}

