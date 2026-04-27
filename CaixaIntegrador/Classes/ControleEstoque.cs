using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CaixaIntegrador.Classes
{
    public class ControleEstoque
    {
        public List<Produto> Listar()
        {
            using var db = new Data.AppDbContext();
            return db.Produtos.Include(p => p.SubCategoria).ToList();
        }

        public List<Produto> Buscar(string termo)
        {
            using var db = new Data.AppDbContext();
            return db.Produtos.Include(p => p.SubCategoria)
                .Where(p => p.Nome.Contains(termo)).ToList();
        }

        public void Adicionar(Produto produto)
        {
            if (produto == null) throw new ArgumentNullException(nameof(produto));
            using var db = new Data.AppDbContext();
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        public void Remover(int id)
        {
            using var db = new Data.AppDbContext();
            var prod = db.Produtos.Find(id);
            if (prod != null)
            {
                db.Produtos.Remove(prod);
                db.SaveChanges();
            }
        }

        public void AtualizarQuantidade(int id, int novaQtd)
        {
            using var db = new Data.AppDbContext();
            var prod = db.Produtos.Find(id);
            if (prod != null && novaQtd >= 0)
            {
                prod.Quantidade = novaQtd;
                db.SaveChanges();
            }
        }

        public List<Produto> ListarPorCategoria(int categoriaId)
        {
            using var db = new Data.AppDbContext();
            return db.Produtos.Include(p => p.SubCategoria)
                .Where(p => p.SubCategoria.CategoriaId == categoriaId).ToList();
        }
    }
}
