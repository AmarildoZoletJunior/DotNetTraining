using MinimalApiCatalogo.Models;

namespace MinimalApiCatalogo.DTO
{
    public class CategoriaDTO : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

    }
}
