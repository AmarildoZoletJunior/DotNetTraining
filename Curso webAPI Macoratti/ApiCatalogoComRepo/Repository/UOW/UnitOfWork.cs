using ApiCatalogo.Data;
using ApiCatalogo.Repository.EntityRepository;
using ApiCatalogo.Repository.EntityRepository.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repository.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProdutoRepository _produtoRepository;
        private CategoriaRepository _categoriaRepository;
        public CatalogoContext _context;

        public IProdutoRepository ProdutoRepository
        {
            get
            {
                return _produtoRepository = _produtoRepository ?? new ProdutoRepository(_context);
            }
        }
        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepository = _categoriaRepository ?? new CategoriaRepository(_context);
            }
        }
        public UnitOfWork(CatalogoContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
