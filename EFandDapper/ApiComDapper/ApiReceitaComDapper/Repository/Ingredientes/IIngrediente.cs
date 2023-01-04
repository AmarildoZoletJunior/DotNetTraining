using TesteComEf.DTO;

namespace TesteComEf.Repository.Ingredientes
{
    public interface IIngrediente
    {
        Task<IEnumerable<IngredientesResponse>> ListarIngredientes();
    }
}
