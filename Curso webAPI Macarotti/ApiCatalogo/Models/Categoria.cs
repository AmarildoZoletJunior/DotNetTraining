namespace ApiCatalogo.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemURL { get; set; }
        public ICollection<Produto>? ListaProdutos { get; set; }
    }
}
