using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models.Configuration
{
    public class ReceitaConfiguration : IEntityTypeConfiguration<Receita>
    {
        void IEntityTypeConfiguration<Receita>.Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.Property(x => x.Titulo).IsRequired();
            builder.Property(x => x.ModoPreparo).IsRequired();
            builder.HasMany(x => x.ListaIngredientes).WithMany(x => x.ListaReceitas);
        }
    }
}
