namespace CaixaIntegrador.Classes
{
    // formas de pagamento 
    public enum FormaPagamento
    {
        Credito,
        Debito,
        Pix,
        Voucher,
        Dinheiro
    }

    // informações de cada forma de pagamento
    public class Pagamento
    {
        public FormaPagamento Forma { get; set; }
        public decimal Valor { get; set; }
    }

    // informações de cada pedido
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<CarrinhoCompra> Itens { get; set; } = new List<CarrinhoCompra>();
        public decimal Total { get; set; }
        public PedidoStatus Status { get; set; }
        // Lista de pagamentos utilizados neste pedido
        public List<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
    }

    // status de um pedido
    public enum PedidoStatus
    {
        Aberto,
        Finalizado
    }
}