using ApiReceitaComDapper.DTO;
using Dapper;
using System.Data.SqlClient;

namespace ApiReceitaComDapper.Repository.Ingredientes
{
    public class Ingrediente : IIngrediente
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Ingrediente(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public async Task<IEnumerable<IngredientesResponse>> ListarIngredientes()
        {
            var sql = $@"select   a.id_ingrediente as  IdIngrediente,a.ingrediente as NomeIngrediente from ingrediente a";
            using(var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<IngredientesResponse>(sql);
            }
        }
    }
}
