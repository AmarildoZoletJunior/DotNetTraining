using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.IngredientesReceitas;

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
        public Task<bool> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita)
        {
            throw new NotImplementedException();
        }
    }
}
