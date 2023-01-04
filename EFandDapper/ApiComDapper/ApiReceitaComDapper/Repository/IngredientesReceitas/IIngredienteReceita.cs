using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.IngredientesReceitas;

namespace ApiReceitaComDapper.Repository.IngredientesReceitas
{
    public interface IIngredienteReceita
    {
        Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita);
        Task<bool> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita);
        Task<bool> RemoverIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita);
    }
}
