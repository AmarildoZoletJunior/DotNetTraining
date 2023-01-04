using eCommerce.Models.Modelop;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Database
{
    public class EcommerceContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ecommerce;Integrated Security=True;")
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
            .EnableSensitiveDataLogging();
        }
        
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EnderecoEntrega> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}
