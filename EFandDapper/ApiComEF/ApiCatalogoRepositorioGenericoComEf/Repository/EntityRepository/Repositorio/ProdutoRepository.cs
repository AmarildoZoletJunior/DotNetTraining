using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Repository.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiCatalogo.Repository.EntityRepository.Repositorio
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(CatalogoContext context) : base(context)
        {
        }

        public IEnumerable<Produto> GetPorCategorias(int id)
        {
            return GetAll().Include(x => x.CategoriaDoProduto).Where(x => x.CategoriaId == id);
        }

      
    }
}
