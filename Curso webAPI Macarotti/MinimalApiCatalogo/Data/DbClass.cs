using Microsoft.EntityFrameworkCore;
using MinimalApiCatalogo.Configuration;
using MinimalApiCatalogo.Models;
using MinimalApiCatalogo.ModelsConfiguration;

namespace MinimalApiCatalogo.Data
{
    public class DbClass : DbContext
    {
        private readonly IConfig _config;
        public DbClass(IConfig config)
        {
            _config = config;
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}
