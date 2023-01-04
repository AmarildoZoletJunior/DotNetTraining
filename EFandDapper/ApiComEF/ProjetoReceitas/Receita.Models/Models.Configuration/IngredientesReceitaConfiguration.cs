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
    public class IngredientesReceitaConfiguration : IEntityTypeConfiguration<IngredientesReceitas>
    {
        void IEntityTypeConfiguration<IngredientesReceitas>.Configure(EntityTypeBuilder<IngredientesReceitas> builder)
        {      
      builder.HasKey(bc => new { bc.ReceitaId, bc.Un_MedidaId, bc.IngredienteId});
           
                //builder.HasMany(bc => bc.)
                //.WithMany(b => b.ListaIngredientes)
                //.HasForeignKey(bc => bc.ReceitaId);

            //builder.HasOne(bc => bc.Ingrediente)
            //    .WithMany(c => c.ListaReceitas)
            //    .HasForeignKey(bc => bc.IngredienteId);

            //builder.HasOne(x => x.UnidadeMedida)
            //    .WithMany(X => X.IngredientesReceitas)
            //    .HasForeignKey(X => X.Un_MedidaId);
        }
    }
}
