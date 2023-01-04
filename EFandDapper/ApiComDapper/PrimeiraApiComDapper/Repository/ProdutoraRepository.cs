using Dapper;
using System.Data.SqlClient;
using TesteDapper.Models;

namespace TesteDapper.Repository
{
    public class ProdutoraRepository : IProdutoraRepository
    {
        private readonly IConfiguration configuration;
        private string connection;

        public ProdutoraRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            connection = configuration.GetConnectionString("ConexaoDefault");
        }
        public async Task<bool> AdicionarProdutora(ProdutoraRequest produtora)
        {
            var sql = $@"insert into tb_produtora values ({produtora.Nome})";
            using(var con = new SqlConnection(connection))
            {
                var insercao = await con.ExecuteAsync(sql);
                if(insercao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> DeletarProdutora(int id)
        {
            var sql = $@"delete from tb_produtora where id = {id}";
            using (var con = new SqlConnection(connection))
            {
                var insercao = await con.ExecuteAsync(sql);
                if (insercao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> EditarProdutora(ProdutoraRequest produtora,int id)
        {
            var sql = $@"update from tb_produtora set nome = {produtora.Nome} where id = {id}";
            using (var con = new SqlConnection(connection))
            {
                var insercao = await con.ExecuteAsync(sql);
                if (insercao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<IEnumerable<ProdutoraResponse>> ListarProdutoras()
        {
            var sql = $@"select p.id,p.nome from tb_produtora p";
            using (var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<ProdutoraResponse>(sql);
            }
        }

        public async Task<ProdutoraResponse> Produtora(int id)
        {
            var sql = $@"select p.id,p.nome from tb_produtora p where p.id = {id}";
            using(var con = new SqlConnection(connection))
            {
                return await con.QueryFirstOrDefaultAsync<ProdutoraResponse>(sql);
            }
        }
    }
}
