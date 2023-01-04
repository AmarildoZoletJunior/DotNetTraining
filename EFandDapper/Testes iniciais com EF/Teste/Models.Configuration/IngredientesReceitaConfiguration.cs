using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models.Configuration
{
    public class IngredientesReceitaConfiguration : IEntityTypeConfiguration<IngredientesReceitas>
    {
        void IEntityTypeConfiguration<IngredientesReceitas>.Configure(EntityTypeBuilder<IngredientesReceitas> builder)
        {
            builder.HasOne(x => x.UnidadeMedida).WithMany(x => x.IngredientesReceitas).HasForeignKey(x => x.Un_MedidaId);

        }
    }
}
