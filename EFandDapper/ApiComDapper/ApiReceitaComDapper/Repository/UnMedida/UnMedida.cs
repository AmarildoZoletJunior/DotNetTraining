using ApiReceitaComDapper.DTO;
using Dapper;
using System.Data.SqlClient;

namespace ApiReceitaComDapper.Repository.UnMedida
{
    public class UnMedida : IUnMedida
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public UnMedida(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public async Task<IEnumerable<UnMedidaResponse>> ListarIngredientes()
        {
            var sql = $@"select * from un_medida";
            using(var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<UnMedidaResponse>(sql);  
            }
        }
    }
}
