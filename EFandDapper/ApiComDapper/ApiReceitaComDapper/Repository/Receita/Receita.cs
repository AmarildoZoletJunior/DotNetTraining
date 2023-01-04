using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Receita;

namespace ApiReceitaComDapper.Repository.Receita
{
    public class Receita : IReceita
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Favoritos(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public Task<bool> ApagarReceita(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CriarReceita(ReceitaRequest receita)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditarReceita(ReceitaRequest receita, int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReceitaResponse>> ListarReceitaComUnicoIngrediente()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReceitaResponse>> ListarReceitaComVariosIngredientes()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReceitaResponse>> ListarReceitas()
        {
            throw new NotImplementedException();
        }
    }
}
