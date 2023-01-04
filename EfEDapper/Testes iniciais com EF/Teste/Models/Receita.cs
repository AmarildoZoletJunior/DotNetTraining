using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models
{
    public class Receita
    {
        public int ReceitaId { get; set; }
        public string Titulo { get; set; } = null!;
        public int Rendimento { get; set; }
        public string ModoPreparo { get; set; } = null!;
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public ICollection<IngredientesReceitas>? ListaReceitas { get; set; }
        public ICollection<Ingrediente>? ListaIngredientes { get; set; }
    }
}
