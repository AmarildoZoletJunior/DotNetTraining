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
        public async Task<bool> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita)
        {
            bool decisao = false;
            foreach(var ing in ingredientes)
            {
                var sql = $@"insert into Ingrediente_Has_Receita (id_ingrediente,id_receita,id_medida,quantidadeIngrediente) values ({ing.IdIngrediente},{ing.IdReceita},{ing.IdUnMedida},{ing.IngredienteQuantidade}) where  id_receita = {idReceita}";
                using (var con = new SqlConnection(connection))
                {
                    var insercao = await con.ExecuteAsync(sql);
                    if(insercao > 0)
                    {
                        decisao = true;
                    }
                    else
                    {
                        decisao = false;
                    }
                }
           }  
            return decisao;
        }

        public async Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita)
        {
            var sql = $@"select a.id_ingrediente,c.ingrediente,d.unidade,a.quantidadeIngrediente from  Ingrediente_Has_Receita a inner join receita b on b.id_receita = a.id_receita inner join Ingrediente c on c.id_ingrediente = a.id_ingrediente inner join Un_Medida d on d.id_Medida = a.id_medida where a.id_receita = {idReceita}";
            using(var con = new SqlConnection(connection))
            {
               return await con.QueryAsync<IngredientesReceitaResponse>(sql);
            }
        }

        public Task<bool> RemoverIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita)
        {
                bool decisao = false;
            foreach(var ing in ingredientes)
            {
                var sql = $@"insert into Ingrediente_Has_Receita (id_ingrediente,id_receita,id_medida,quantidadeIngrediente) values ({ing.IdIngrediente},{ing.IdReceita},{ing.IdUnMedida},{ing.IngredienteQuantidade})";
                using (var con = new SqlConnection(connection))
                {
                    var insercao = await con.ExecuteAsync(sql);
                    if(insercao > 0)
                    {
                        decisao = true;
                    }
                    else
                    {
                        decisao = false;
                    }
                }
           }  
            return decisao;
        }
    }
}
