using ApiReceitaComDapper.DTO;

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
        public Task<IEnumerable<UnMedidaResponse>> ListarIngredientes()
        {
            throw new NotImplementedException();
        }
    }
}
