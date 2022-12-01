using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models
{
    public class Un_Medida
    {
        public int Id { get; set; }
        public string? Medida { get; set; }
        public ICollection<Ingrediente>? IngredientesReceitas { get; set; }
    }

}
