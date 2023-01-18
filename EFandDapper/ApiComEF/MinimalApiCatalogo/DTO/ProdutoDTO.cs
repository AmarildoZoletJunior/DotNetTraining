using MinimalApiCatalogo.Models;

namespace MinimalApiCatalogo.DTO
{
    public class ProdutoDTO : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemI { get; set; }
        public DateTime DataCompra { get; set; }
        public int Estoque { get; set; }
        public string? CategoriaTipo { get; set; }
        public int Id { get; set; }
    }
}
