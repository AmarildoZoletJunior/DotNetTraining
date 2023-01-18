using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Repository.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repository.EntityRepository.Repositorio
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(CatalogoContext context) : base(context)
        {
        }
        public IEnumerable<Categoria> GetCategoriasPorQuantidadeDeProdutos(int quantidade)
        {
            return GetAll().Include(x => x.ListaProdutos).Where(x => x.ListaProdutos.Count == quantidade);
        }
    }
}
