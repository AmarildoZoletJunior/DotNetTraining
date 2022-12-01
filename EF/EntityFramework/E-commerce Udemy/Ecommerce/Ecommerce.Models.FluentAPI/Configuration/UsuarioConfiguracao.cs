using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.FluentAPI.Configuration
{
    internal class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.CPF).IsRequired().HasColumnName("CPF_USUARIO");
            builder.Property(x => x.RG).IsRequired().HasColumnName("REGISTRO_GERAL");
            builder.HasOne(x => x.Contato).WithOne(x => x.Usuario).HasForeignKey<Contato>(x => x.UsuarioId);
            builder.HasMany(x => x.ListaEnderecos).WithOne(x => x.Usuario).HasForeignKey(x => x.UsuarioId);
            builder.HasMany(x => x.ListaDepartamentos).WithMany(x => x.ListaUsuarios);
        }
    }
}
