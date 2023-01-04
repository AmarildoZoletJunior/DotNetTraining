using TesteDapper.Models;

namespace TesteDapper.Repository
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<FilmeResponse>> BuscaFilmes();
        Task<FilmeResponse> BuscaFilmesAsync(int id);
        Task<bool> AdicionarAsync(FilmeRequest request);
        Task<bool> AtualizarAsync(FilmeRequest request,int id);
        Task<bool> DeletarAsync(int id);
    }
}
