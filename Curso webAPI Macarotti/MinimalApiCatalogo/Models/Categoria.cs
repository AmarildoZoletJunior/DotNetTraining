using MinimalApiCatalogo.DTO;
using System.Text.Json.Serialization;

namespace MinimalApiCatalogo.Models
{
    public class Categoria : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        [JsonIgnore]
        public ICollection<Produto>? Produtos { get; set; }
    }
}
