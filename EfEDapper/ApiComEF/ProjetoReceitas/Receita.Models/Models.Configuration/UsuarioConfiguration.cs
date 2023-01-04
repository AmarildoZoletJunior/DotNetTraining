using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        void IEntityTypeConfiguration<Usuario>.Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasMany(x => x.ReceitasCriadas).WithOne(x => x.Usuario).HasForeignKey(x => x.UsuarioId);
            builder.Property(x => x.Email).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Senha).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
        }
    }
}
