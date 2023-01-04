using ApiCatalogo.Models;
using ApiCatalogo.Repository.BaseRepository;

namespace ApiCatalogo.Repository.EntityRepository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasPorQuantidadeDeProdutos(int quantidade);
    }
}
