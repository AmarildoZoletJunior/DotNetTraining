using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.IngredientesReceitas;

namespace ApiReceitaComDapper.Repository.IngredientesReceitas
{
    public interface IIngredienteReceita
    {
        Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita);
        Task<int> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita);
        Task<int> RemoverIngredientes(List<int> ingredientes, int idReceita);
        Task<bool> ReceitaExiste(int idReceita);
    }
}
