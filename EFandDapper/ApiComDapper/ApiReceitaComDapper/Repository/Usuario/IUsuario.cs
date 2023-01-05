using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Usuario;

namespace ApiReceitaComDapper.Repository.Usuario
{
    public interface IUsuario
    {
        Task<IEnumerable<UsuarioResponse>> ListaUsuarios();
        Task<bool> CriarUsuario(UsuarioRequest usuario);
        Task<bool> EditarUsuario(UsuarioRequest usuario);
        Task<bool> UsuarioExiste(string email);
    }
}
