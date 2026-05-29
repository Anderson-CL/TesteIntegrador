using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Classes
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }

        // "Entrada", "Saida" ou "Ajuste"
        public string Tipo { get; set; }

        public int Quantidade { get; set; }
        public int QuantidadeAnterior { get; set; }
        public int QuantidadeNova { get; set; }
        public string Observacao { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        // Navegação (opcional, para consultas com Join)
        public Produto Produto { get; set; }
    }
}
