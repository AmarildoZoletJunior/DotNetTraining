using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models.Configuration
{
    public class Un_MedidaConfiguration : IEntityTypeConfiguration<Un_Medida>
    {
        void IEntityTypeConfiguration<Un_Medida>.Configure(EntityTypeBuilder<Un_Medida> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Medida).IsRequired();
            builder.HasMany(x => x.IngredientesReceitas).WithOne(x => x.UnidadeMedida).HasForeignKey(x => x.Un_MedidaId);
        }
    }
}
