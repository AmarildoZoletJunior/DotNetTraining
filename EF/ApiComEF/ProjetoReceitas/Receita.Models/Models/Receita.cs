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
        public string? Titulo { get; set; }
        public int? Rendimento { get; set; }
        public string? ModoPreparo { get; set; }
        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public ICollection<Ingrediente>? ListaIngredientes { get; set; }
    }
}
