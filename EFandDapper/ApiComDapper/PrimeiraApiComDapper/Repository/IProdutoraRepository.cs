using TesteDapper.Models;

namespace TesteDapper.Repository
{
    public interface IProdutoraRepository
    {
        Task<IEnumerable<ProdutoraResponse>> ListarProdutoras();
        Task<ProdutoraResponse> Produtora(int id);
        Task<bool> AdicionarProdutora(ProdutoraRequest produtora);
        Task<bool> DeletarProdutora(int id);
        Task<bool> EditarProdutora(ProdutoraRequest produtora, int id);
    }
}
