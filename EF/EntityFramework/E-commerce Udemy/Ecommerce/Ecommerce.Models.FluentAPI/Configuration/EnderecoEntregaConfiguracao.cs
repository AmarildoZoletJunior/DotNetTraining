using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.FluentAPI.Configuration
{
    internal class EnderecoEntregaConfiguracao : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeEndereco).IsRequired();
            builder.Property(x => x.CEP).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
            builder.HasOne(x => x.Usuario).WithMany(x => x.ListaEnderecos).HasForeignKey(x => x.UsuarioId);

        }
    }
}
