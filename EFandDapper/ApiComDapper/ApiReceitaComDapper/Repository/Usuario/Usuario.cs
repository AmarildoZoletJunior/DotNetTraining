using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Usuario;
using System.Data.SqlClient;

namespace ApiReceitaComDapper.Repository.Usuario
{
    public class Usuario : IUsuario
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Usuario(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }

        public Task<IEnumerable<UsuarioResponse>> ListaUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CriarUsuario(UsuarioRequest usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarUsuario(UsuarioRequest usuario)
        {
            throw new NotImplementedException();
        }
    }
}
