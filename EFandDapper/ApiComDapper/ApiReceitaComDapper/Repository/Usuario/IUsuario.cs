using TesteComEf.DTO;
using TesteComEf.Entidades.Usuario;

namespace TesteComEf.Repository.Usuario
{
    public interface IUsuario
    {
        Task<IEnumerable<UsuarioResponse>> ListaUsuarios();
        Task<bool> CriarUsuario(UsuarioRequest usuario);
        Task<bool> EditarUsuario(UsuarioRequest usuario);
        Task<bool> LogarUsuario(UsuarioLogin usuario);
    }
}
