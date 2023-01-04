using ApiCatalogo.Repository.EntityRepository;

namespace ApiCatalogo.Repository.UOW
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }

        void Commit();
        void Dispose();
    }
}
