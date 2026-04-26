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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            string dbFileName = "Adega.db"; // use o nome exato do arquivo
            string dbPath = System.IO.Path.Combine(AppContext.BaseDirectory, "Data", dbFileName);
            options.UseSqlite($"Data Source={dbPath}");

        }
    }
}
