using Microsoft.EntityFrameworkCore;
using Receitas.Models.Models.Configuration;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System;
using Receitas.Models.Models;

namespace ProjetoReceitas
{
    public class DbArquivo : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BuscasReceitas;Integrated Security=True;");
        }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Un_Medida> Un_Medida { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<IngredientesReceitas> IngredientesReceitas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IngredienteConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientesReceitaConfiguration());
            modelBuilder.ApplyConfiguration(new ReceitaConfiguration());
            modelBuilder.ApplyConfiguration(new Un_MedidaConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
