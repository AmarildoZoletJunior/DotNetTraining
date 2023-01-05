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
        public async Task<IEnumerable<UnMedidaResponse>> ListarUnidades()
        {
            var sql = $@"select a.id_Medida as IdMedida,a.unidade as Unidade from un_medida a";
            using(var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<UnMedidaResponse>(sql);  
            }
        }
    }
}
