using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.FluentAPI.Configuration
{
    internal class ContatoConfiguracao : IEntityTypeConfiguration<Contato>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Celular).IsRequired();
            builder.HasOne(x => x.Usuario).WithOne(x => x.Contato).HasForeignKey<Contato>(x => x.UsuarioId);
        }
    }
}
