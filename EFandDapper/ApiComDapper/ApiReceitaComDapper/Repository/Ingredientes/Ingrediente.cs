using ApiReceitaComDapper.DTO;

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
        public Task<IEnumerable<IngredientesResponse>> ListarIngredientes()
        {
            
        }
    }
}
