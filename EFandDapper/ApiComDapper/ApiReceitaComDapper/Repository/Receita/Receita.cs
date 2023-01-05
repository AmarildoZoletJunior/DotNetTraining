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

        public async Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarReceitaContendoIngrediente(string ingredientes)
        {
            var sql = $@"select distinct a.id_receita,a.titulo_receita,a.rendimento,a.modo_preparo,a.id_usuarioDono from receita a inner join Ingrediente_Has_Receita b on a.id_receita = b.id_receita inner join Ingrediente c on c.id_ingrediente = b.id_ingrediente where c.id_ingrediente in ({ingredientes}) ";
            using (var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }

        public async Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarReceitas()
        {
            var sql = $@"select * from receita;";
            using(var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }
        public async Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarPorNome(string nome)
        {
            var sql = $@"select a.id_receita,a.titulo_receita,a.rendimento,a.modo_preparo,a.id_usuarioDono from receita a where titulo_receita like ('%{nome}%') ;";
            using (var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }
        public async Task<ReceitaResponse> ReceitaSolo(int idReceita)
        {
            var sql = $@"select a.id_receita,a.titulo_receita,a.rendimento,a.modo_preparo,a.id_usuarioDono where id_receita = {idReceita}";
            var sqlIngrediente = $@"select a.id_ingrediente,b.ingrediente,c.unidade,a.quantidadeIngrediente from Ingrediente_Has_Receita a inner join ingrediente b on b.id_ingrediente = a.id_ingrediente inner join Un_Medida c on c.id_Medida = a.id_medida inner join Receita d on d.id_receita = a.id_receita where d.id_receita = {idReceita}";
            using(var conn = new SqlConnection(connection))
            {
                var receita = await conn.QueryFirstOrDefaultAsync<ReceitaSemIngredienteResponse>(sql);
                if(receita == null)
                {
                    return null;
                }
                var lista = await conn.QueryAsync<IngredientesReceitaResponse>(sqlIngrediente);
                return new ReceitaResponse { IdReceita = receita.IdReceita, IdUsuarioDono = receita.IdUsuarioDono, ModoPreparo = receita.ModoPreparo, Rendimento = receita.Rendimento, TituloReceita = receita.TituloReceita, IngredientesReceita = lista };
            }
        }
    }
}
