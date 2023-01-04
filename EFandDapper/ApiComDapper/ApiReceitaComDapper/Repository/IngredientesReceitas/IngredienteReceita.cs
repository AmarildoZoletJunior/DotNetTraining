using TesteComEf.DTO;
using TesteComEf.Entidades.IngredientesReceitas;

namespace TesteComEf.Repository.IngredientesReceitas
{
    public interface IngredienteReceita
    {
        Task<IEnumerable<IngredientesReceitaResponse>> ListarIngredientesReceita(int idReceita);
        Task<bool> AdicionarIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita);
        Task<bool> RemoverIngredientes(List<IngredientesReceitaRequest> ingredientes, int idReceita);
    }
}
