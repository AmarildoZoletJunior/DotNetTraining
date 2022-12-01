using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models.Configuration
{
    public class ReceitaConfiguration : IEntityTypeConfiguration<Receita>
    {
        void IEntityTypeConfiguration<Receita>.Configure(EntityTypeBuilder<Receita> builder)
        {
            builder
                     .HasMany(a => a.ListaIngredientes)
                     .WithMany(x => x.Receitas)
                     .UsingEntity<IngredientesReceitas>(
                     q => q.HasOne(x => x.Ingrediente).WithMany(x => x.ListaReceitas).HasForeignKey(a => a.IngredienteId),
                     q => q.HasOne(x => x.Receita).WithMany(x => x.ListaReceitas).HasForeignKey(x => x.ReceitaId),
                     q => q.HasKey(a => new { a.ReceitaId, a.IngredienteId })
                     );
            builder.Property(x => x.Titulo).IsRequired();
            builder.Property(x => x.ModoPreparo).IsRequired();
            builder.HasOne(x => x.Usuario).WithMany(x => x.ReceitasCriadas).HasForeignKey(x => x.ReceitaId);
        }
    }
}
