using ApiCatalogo.Models;
using ApiCatalogo.Repository.BaseRepository;

namespace ApiCatalogo.Repository.EntityRepository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetPorCategorias(int id);
    }
}
