using CaixaIntegrador.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaIntegrador.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pagamento> PedidoPagamentos { get; set; }  // ← NOVO
        public DbSet<MovimentacaoEstoque> MovimentacoesEstoque { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(AppContext.BaseDirectory, "Data", "Adega.db");
            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // Pedido não tem coleção de Venda — o vínculo é só pela FK
            model.Entity<Venda>()
                .HasOne<Pedido>()
                .WithMany()
                .HasForeignKey(v => v.PedidoId)
                .OnDelete(DeleteBehavior.SetNull);

            model.Entity<Pagamento>()
                .HasOne<Pedido>()
                .WithMany()
                .HasForeignKey(p => p.PedidoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Enums salvos como string no banco
            model.Entity<Pagamento>()
                .Property(p => p.Forma)
                .HasConversion<string>();

            model.Entity<Pedido>()
                .Property(p => p.Status)
                .HasConversion<string>();

            // Pedido.Itens e Pedido.Pagamentos são ignorados pelo EF
            // (são listas em memória, não colunas do banco)
            model.Entity<Pedido>()
                .Ignore(p => p.Itens)
                .Ignore(p => p.Pagamentos);

            model.Entity<Venda>()
                .HasOne(v => v.Produto)
                .WithMany()
                .HasForeignKey(v => v.ProdutoId);
        }
    }
}
