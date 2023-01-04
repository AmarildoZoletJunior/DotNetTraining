using Microsoft.EntityFrameworkCore;
using Receitas.Models.Models.Configuration;
using Receitas.Models.Models;

namespace ProjetoReceitas
{
    public class DbArquivo : DbContext
    {
        public DbArquivo(DbContextOptions<DbArquivo> options) : base(options)
        {

        }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Receita> Receita { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IngredienteConfiguration());
            modelBuilder.ApplyConfiguration(new ReceitaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
