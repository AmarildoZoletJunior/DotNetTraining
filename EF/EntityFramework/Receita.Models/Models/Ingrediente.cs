
namespace Receitas.Models.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string? IngredienteUnico { get; set; }
        public ICollection<Receita>? ListaReceitas { get; set; }
    }
}
