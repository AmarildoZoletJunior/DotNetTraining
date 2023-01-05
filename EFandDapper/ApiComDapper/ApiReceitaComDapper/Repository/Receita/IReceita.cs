using ApiReceitaComDapper.DTO;
using ApiReceitaComDapper.Entidades.Receita;

namespace ApiReceitaComDapper.Repository.Receita
{
    public interface IReceita
    {
        Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarReceitas();
        Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarReceitaContendoIngrediente(string ingredientes);
        Task<IEnumerable<ReceitaSemIngredienteResponse>> ListarPorNome(string nome);
        Task<bool> CriarReceita(ReceitaRequest receita);
        Task<bool> ApagarReceita(int id);
        Task<bool> EditarReceita(ReceitaRequest receita, int id);
        Task<ReceitaResponse> ReceitaSolo(int idReceita);
    }
}
