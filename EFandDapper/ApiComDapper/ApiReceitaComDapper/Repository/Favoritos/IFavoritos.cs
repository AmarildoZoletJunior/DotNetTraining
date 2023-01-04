using TesteComEf.DTO;
using TesteComEf.Entidades.Favoritos;

namespace TesteComEf.Repository.Favoritos
{
    public interface IFavoritos
    {
        Task<IEnumerable<FavoritosResponse>> FavoritosGeral();
        Task<IEnumerable<FavoritosResponse>> FavoritosUsuario(int idUsuario);
        Task<bool> AdicionarFavoritos(FavoritosRequest request,int idUsuario);
        Task<bool> RemoverFavoritos(int idUsuario, int idReceita);
    }
}
