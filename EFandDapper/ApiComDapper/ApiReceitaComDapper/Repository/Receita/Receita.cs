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
            var sql = $@"delete from Receita where id_receita = {id}";
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
            var sql = $@"insert into Receita(titulo_receita,rendimento,modo_preparo,id_usuarioDono,tipo_receita) values ('{receita.TituloReceita}',{receita.Rendimento},'{receita.ModoPreparo}',{receita.IdUsuario},'{receita.tipo_receita}')";
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
            var sql = $@"update Receita set titulo_receita = '{receita.TituloReceita}',modo_preparo = '{receita.ModoPreparo}' where id_receita = {id}";
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
            var sql = $@"SELECT DISTINCT a.id_receita AS IdReceita,a.titulo_receita AS TituloReceita,a.rendimento as Rendimento,a.modo_preparo AS ModoPreparo,a.id_usuarioDono AS IdUsuarioDono from receita a inner join Ingrediente_Has_Receita b on a.id_receita = b.id_receita inner join Ingrediente c on c.id_ingrediente = b.id_ingrediente where c.id_ingrediente in ({ingredientes}) ";
            using (var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }

        public async Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarReceitas()
        {
            var sql = $@"select a.id_receita as IdReceita,a.titulo_receita as TituloReceita, a.rendimento as Rendimento, a.modo_preparo as ModoPreparo,a.id_usuarioDono as idUsuarioDono from receita a;";
            using(var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }
        public async Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarPorNome(string nome)
        {
            var sql = $@"select a.id_receita as IdReceita,a.titulo_receita as TituloReceita, a.rendimento as Rendimento, a.modo_preparo as ModoPreparo,a.id_usuarioDono as idUsuarioDono from receita a where titulo_receita like ('%{nome}%') ;";
            using (var conn = new SqlConnection(connection))
            {
                return await conn.QueryAsync<ReceitaSemIngredienteResponse>(sql);
            }
        }
        public async Task<ReceitaResponse> ReceitaSolo(int idReceita)
        {
            var sql = $@"select a.id_receita as IdReceita,a.titulo_receita as TituloReceita, a.rendimento as Rendimento, a.modo_preparo as ModoPreparo,a.id_usuarioDono as idUsuarioDono from receita a where a.id_receita = {idReceita}";
           var sqlIngrediente = $@"select a.id_ingrediente as idIngrediente,b.ingrediente as NomeIngrediente,c.unidade as UnidadeMedida,a.quantidadeIngrediente as QuantidadeIngrediente from Ingrediente_Has_Receita a inner join ingrediente b on b.id_ingrediente = a.id_ingrediente inner join Un_Medida c on c.id_Medida = a.id_medida inner join Receita d on d.id_receita = a.id_receita where d.id_receita = {idReceita}";
            using(var conn = new SqlConnection(connection))
            {
                var receita = await conn.QueryFirstOrDefaultAsync<ReceitaSemIngredienteResponse>(sql);
               if(receita == null)
               {
                  return null;
                }
                var lista = await conn.QueryAsync<IngredientesReceitaResponse>(sqlIngrediente);
                ReceitaResponse receitaNova = new ReceitaResponse { IdReceita = receita.IdReceita, IdUsuarioDono = receita.IdUsuarioDono, ModoPreparo = receita.ModoPreparo, Rendimento = receita.Rendimento, TituloReceita = receita.TituloReceita, IngredientesReceita = lista };
                return receitaNova;
            }
        }
    }
}
