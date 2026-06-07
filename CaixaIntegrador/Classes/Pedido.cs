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
        public int Id { get; set; }
        public int PedidoId { get; set; }  // ← NOVO
        public FormaPagamento Forma { get; set; }
        public decimal Valor { get; set; }
    }

    // informações de cada pedido
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public decimal Troco { get; set; }
        public PedidoStatus Status { get; set; }
        public List<CarrinhoCompra> Itens { get; set; } = new();   // ← mantém CarrinhoCompra
        public List<Pagamento> Pagamentos { get; set; } = new();
    }

    // status de um pedido
    public enum PedidoStatus
    {
        Aberto,
        Finalizado
    }
}