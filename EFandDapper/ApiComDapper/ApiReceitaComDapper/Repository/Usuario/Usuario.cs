using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Usuario;
using Dapper;
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

        public async Task<IEnumerable<UsuarioResponse>> ListaUsuarios()
        {
           var sql =  $@"select * from Usuario";
            using(var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<UsuarioResponse>(sql);
            }
        }

        public async Task<bool> CriarUsuario(UsuarioRequest usuario)
        {
            var sql = $@"insert into Usuario values ({usuario.Nome},{usuario.Email},{usuario.Senha})";
            using (var con = new SqlConnection(connection))
            {
                var insercao = await con.ExecuteAsync(sql);
                if(insercao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> EditarUsuario(UsuarioRequest usuario)
        {
            var sql = $@"update from Usuario (nome,senha) set nome = {usuario}, senha = {usuario.Senha}";
            using (var con = new SqlConnection(connection))
            {
                var edicao = await con.ExecuteAsync(sql);
                if(edicao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> UsuarioExiste(string email)
        {
            var sql = $@"select a.email from usuario where email = {email}";
            using (var con = new SqlConnection(connection))
            {
                var edicao = await con.QueryFirstOrDefault(sql);
                if(edicao == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
