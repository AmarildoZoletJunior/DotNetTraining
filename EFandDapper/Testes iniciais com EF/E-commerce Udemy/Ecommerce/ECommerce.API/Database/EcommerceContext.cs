using eCommerce.Models.Modelop;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Database
{
    public class EcommerceContext : DbContext
    {

        
       public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EnderecoEntrega> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }

    }
}
