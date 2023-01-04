using eCommerce.Models.Modelop;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Database
{
    public class EcommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EcommerceTemp;Integrated Security=True;");
        }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<EnderecoEntrega>? Enderecos { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios", t => t.IsTemporal(
                b =>
                {
                    b.HasPeriodStart("PeriodoInicial");
                    b.HasPeriodEnd("PeriodoFinal");
                    b.UseHistoryTable("UsuariosHistorico");
                }));
        }

    }
}
