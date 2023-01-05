using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Favoritos;

namespace ApiReceitaComDapper.Repository.Favoritos
{
    public interface IFavoritos
    {
        Task<IEnumerable<FavoritosResponse>> FavoritosGeral();
        Task<IEnumerable<FavoritosResponse>> FavoritosUsuario(int idUsuario);
        Task<bool> AdicionarFavoritos(int idReceita, int IdUsuario);
        Task<bool> RemoverFavoritos(int idUsuario, int idReceita);
    }
}
