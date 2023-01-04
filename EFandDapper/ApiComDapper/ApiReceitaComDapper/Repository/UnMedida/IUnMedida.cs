using TesteComEf.DTO;

namespace TesteComEf.Repository.UnMedida
{
    public interface IUnMedida
    {
        Task<IEnumerable<UnMedidaResponse>> ListarIngredientes();
    }
}
