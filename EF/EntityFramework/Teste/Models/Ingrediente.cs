using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string IngredienteUnico { get; set; } = null!;
        public ICollection<IngredientesReceitas>? ListaReceitas { get; set; }
        public ICollection<Receita> Receitas { get; set; }
    }
}
