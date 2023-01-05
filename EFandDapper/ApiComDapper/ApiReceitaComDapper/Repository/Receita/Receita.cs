using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Receita;
using Dapper;
using System.Data.SqlClient;

namespace ApiReceitaComDapper.Repository.Receita
{
    public class Receita : IReceita
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Receita(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public async Task<bool> ApagarReceita(int id)
        {
            var sql = $@"remove from table Receita where id_receita = {id}";
            using(var client = new SqlConnection(connection))
            {
                var resposta = await client.ExecuteAsync(sql);
                if (resposta > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> CriarReceita(ReceitaRequest receita)
        {
            var sql = $@"insert into Receita(titulo_receita,rendimento,modo_preparo,id_usuarioDono,tipo_receita) values ({receita.TituloReceita},{receita.Rendimento},{receita.ModoPreparo},{receita.IdUsuario},{receita.tipo_receita})";
            using(SqlConnection conn = new SqlConnection(connection))
            {
                var criar = await conn.ExecuteAsync(sql);
                if (criar > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> EditarReceita(ReceitaRequest receita, int id)
        {
            var sql = $@"update Receita set titulo_receita = {receita.TituloReceita},modo_preparo = {receita.ModoPreparo} where id_receita = {id}";
            using(var conn = new SqlConnection(connection))
            {
                var atualizar = await conn.ExecuteAsync(sql);
                if(atualizar > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Task<IEnumerable<ReceitaResponse>> ListarReceitaComUnicoIngrediente()
        {
           
        }

        public Task<IEnumerable<ReceitaResponse>> ListarReceitaComVariosIngredientes()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ReceitaResponse>> ListarReceitas()
        {
            var ingredientes = $@"select p.ingrediente from Ingrediente_Has_Receita inner join ingrediente";
            var sql = $@"select * from receita;";
            using(var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaResponse>(sql);
            }
        }
    }
}
