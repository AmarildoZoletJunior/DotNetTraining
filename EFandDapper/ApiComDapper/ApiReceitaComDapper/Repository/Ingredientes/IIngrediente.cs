using ApiReceitaComDapper.DTO;

namespace ApiReceitaComDapper.Repository.Ingredientes
{
    public interface IIngrediente
    {
        Task<IEnumerable<IngredientesResponse>> ListarIngredientes();
    }
}
