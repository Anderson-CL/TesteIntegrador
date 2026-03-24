namespace CaixaIntegrador.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<CarrinhoCompra> Itens { get; set; } = new List<CarrinhoCompra>();
        public decimal Total { get; set; }
        public PedidoStatus Status { get; set; }
    }

    public enum PedidoStatus
    {
        Aberto,
        Finalizado
    }
}
