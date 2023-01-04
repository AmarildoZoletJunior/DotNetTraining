using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receitas.Models.Models
{
    public class IngredientesReceitas
    {
        public int IngredienteId { get; set; }
        public int ReceitaId { get; set; }
        public int Un_MedidaId { get; set; }
        public Ingrediente? Ingrediente { get; set; }
        public Receita? Receita { get; set; }
        public Un_Medida? UnidadeMedida { get; set; } 
    }
}
