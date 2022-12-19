using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApiCatalogo.Data
{
    public class CatalogoContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options) { }

        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(x => x.CategoriaId);
            modelBuilder.Entity<Categoria>().Property(X => X.ImagemURL).HasMaxLength(300).IsRequired();
            modelBuilder.Entity<Categoria>().Property(X => X.Nome).HasMaxLength(80).IsRequired();
            modelBuilder.Entity<Categoria>().HasMany(x => x.ListaProdutos).WithOne(x => x.CategoriaDoProduto);
            modelBuilder.Entity<Produto>().HasKey(x => x.ProdutoId);
            modelBuilder.Entity<Produto>().Property(x => x.Nome).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Produto>().Property(x => x.Descricao).HasMaxLength(300).IsRequired();
            modelBuilder.Entity<Produto>().Property(x => x.ImagemURL).HasMaxLength(300).IsRequired();
            modelBuilder.Entity<Produto>().Property(x => x.Preco).HasPrecision(10, 2);
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaId = 1, ImagemURL = "Bebida.png", Nome = "Bebidas" });
            modelBuilder.Entity<Produto>().HasData(new Produto {ProdutoId = 1, Nome = "Suco de laranja", Descricao = "2LT de puro refresco", Estoque = 20, Preco = 7.50M, ImagemURL = "sucoLaranja.png", DataCadastro = DateTime.Now, CategoriaId = 1 });
        }
    }
}
