using TesteComEf.DTO;
using TesteComEf.Entidades.Receita;

namespace TesteComEf.Repository.Receita
{
    public interface IReceita
    {
        Task<IEnumerable<ReceitaResponse>> ListarReceitas();
        Task<IEnumerable<ReceitaResponse>> ListarReceitaComUnicoIngrediente();
        Task<IEnumerable<ReceitaResponse>> ListarReceitaComVariosIngredientes();
        Task<bool> CriarReceita(ReceitaRequest receita);
        Task<bool> ApagarReceita(int id);
        Task<bool> EditarReceita(ReceitaRequest receita, int id);

    }
}
