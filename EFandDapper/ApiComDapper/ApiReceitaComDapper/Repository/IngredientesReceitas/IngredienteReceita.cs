using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.IngredientesReceitas;
using Dapper;
using System.Data.SqlClient;

namespace ApiReceitaComDapper.Repository.IngredientesReceitas
{
    public class IngredienteReceita : IIngredienteReceita
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public IngredienteReceita(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public async Task<int> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita)
        {
            int quantidade = 0;
            foreach (var ing in ingredientes)
            {
                var sql = $@"insert into Ingrediente_Has_Receita (id_ingrediente,id_receita,id_medida,quantidadeIngrediente) values ({ing.IdIngrediente},{idReceita},{ing.IdUnMedida},{ing.IngredienteQuantidade})";
                using (var con = new SqlConnection(connection))
                {
                    var insercao = await con.ExecuteAsync(sql);
                    if (insercao > 0)
                    {
                        quantidade++;
                    }
                }
            }
            return quantidade;
        }

        public async Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita)
        {
            var sql = $@"select a.id_ingrediente as idIngrediente,c.ingrediente as NomeIngrediente,d.unidade as UnidadeMedida,a.quantidadeIngrediente as QuantidadeIngrediente from  Ingrediente_Has_Receita a inner join receita b on b.id_receita = a.id_receita inner join Ingrediente c on c.id_ingrediente = a.id_ingrediente inner join Un_Medida d on d.id_Medida = a.id_medida where a.id_receita = {idReceita}";
            using (var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<IngredientesReceitaResponse>(sql);
            }
        }

        public async Task<int> RemoverIngredientes(List<int> ingredientes, int idReceita)
        {
            int quantidade = 0;
            foreach (var ing in ingredientes)
            {
                var sql = $@"delete from Ingrediente_Has_Receita where id_ingrediente = {ing} and id_receita = {idReceita} ";
                using (var con = new SqlConnection(connection))
                {
                    var insercao = await con.ExecuteAsync(sql);
                    if (insercao > 0)
                    {
                        quantidade++;
                    }
                }
            }
            return quantidade;
        }
        public async Task<bool> ReceitaExiste(int idReceita)
        {
            var sql = $@"select * from Receita where id_receita = {idReceita}";
            using (var conn = new SqlConnection(connection))
            {
                var existe = await conn.QuerySingleOrDefaultAsync(sql);
                if (existe == null)
                {
                    return false;
                }
                return true;
            }

        }
    }
}
