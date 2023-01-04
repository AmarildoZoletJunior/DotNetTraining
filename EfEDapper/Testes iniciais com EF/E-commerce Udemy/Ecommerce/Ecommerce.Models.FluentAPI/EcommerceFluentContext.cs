using eCommerce.Models;
using Ecommerce.Models.FluentAPI.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.FluentAPI
{
     class EcommerceFluentContext: DbContext
    {


        public EcommerceFluentContext(DbContextOptions<EcommerceFluentContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<EnderecoEntrega>? Enderecos { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new ContatoConfiguracao());



            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");
            modelBuilder.Entity<Usuario>().Property(x => x.RG).HasColumnName("REGISTRO_GERAL").IsRequired();
            modelBuilder.Entity<Usuario>().Ignore(x => x.SituacaoCadastro);
            modelBuilder.Entity<Usuario>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>().HasOne(x => x.Contato).WithOne(x => x.Usuario).HasForeignKey<Contato>(a => a.UsuarioId);
            modelBuilder.Entity<Usuario>().HasMany(x => x.ListaEnderecos).WithOne(x => x.Usuario).HasForeignKey(x => x.UsuarioId);
            modelBuilder.Entity<Usuario>().HasMany(x => x.ListaDepartamentos).WithMany(x => x.ListaUsuarios);
        }
    }
  
}
