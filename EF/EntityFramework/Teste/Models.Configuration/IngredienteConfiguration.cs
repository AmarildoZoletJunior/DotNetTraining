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
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        void IEntityTypeConfiguration<Ingrediente>.Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(X => X.IngredienteUnico).IsRequired();
            builder.HasKey(x => x.Id);
      
        }
    }
}
