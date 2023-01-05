using ApiReceitaComDapper.DTO;

namespace ApiReceitaComDapper.Repository.UnMedida
{
    public interface IUnMedida
    {
        Task<IEnumerable<UnMedidaResponse>> ListarUnidades();
    }
}
