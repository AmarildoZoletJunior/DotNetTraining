using Dapper;
using System.Data.SqlClient;
using TesteDapper.Models;

namespace TesteDapper.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        public IConfiguration Configuration { get; }
        private readonly string connectionString;

        public FilmeRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            connectionString = Configuration.GetConnectionString("ConexaoDefault");
        }
        public async Task<FilmeResponse> BuscaFilmesAsync(int id)
        {
            var sql = $@"SELECT f.id ID,f.nome Nome,f.ano Ano,p.nome Produtora From tb_filme f JOIN tb_produtora p ON f.id_produtora = p.id Where f.id = {id}";
            using (var con = new SqlConnection(connectionString))
            {
                return await con.QueryFirstOrDefaultAsync<FilmeResponse>(sql);
            }
        }
        public async Task<IEnumerable<FilmeResponse>> BuscaFilmes()
        {

            var sql = @"SELECT f.id ID,f.nome Nome,f.ano Ano,p.nome Produtora From tb_filme f JOIN tb_produtora p ON f.id_produtora = p.id";
            using (var con = new SqlConnection(connectionString))
            {
                return await con.QueryAsync<FilmeResponse>(sql);
            }
        }
        public async Task<bool> AdicionarAsync(FilmeRequest request)
        {
            if(request == null)
            {
                return false;
            }
            var sql = $@"insert into Tb_Filme values ('{request.Nome}',{request.Ano},{request.ProdutoraId})";
            using (var con = new SqlConnection(connectionString))
            {
                var pesquisa = await con.QueryFirstOrDefaultAsync($@"select * from tb_produtora where id = {request.ProdutoraId}");
                if(pesquisa == null)
                {
                    return false;
                }
                int resolucao = await con.ExecuteAsync(sql);
                if(resolucao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> AtualizarAsync(FilmeRequest request, int id)
        {
            var sql = $@"update tb_filme set nome = '{request.Nome}', ano = {request.Ano}, id_produtora = '{request.ProdutoraId}' where id = {id}";
            using (var con = new SqlConnection(connectionString))
            {
                int resolucao = await con.ExecuteAsync(sql);
                if (resolucao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> DeletarAsync(int id)
        {
            var sql = $@"DELETE FROM tb_filme where id = {id}";
            using (var con = new SqlConnection(connectionString))
            {
                int resolucao = await con.ExecuteAsync(sql);
                if (resolucao > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
