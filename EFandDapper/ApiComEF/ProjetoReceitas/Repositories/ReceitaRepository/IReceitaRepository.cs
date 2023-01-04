namespace ProjetoReceitas.Repositories;
using Receitas.Models.Models;

public interface IReceitaRepository
{
    List<Receita> ListaDeReceitas();
    Receita ReceitaUnica(string nome);
    void Add(Receita receita);
    void Update(Receita receita);
    void Deletar(int id);
    List<Receita> ReceitasDoUsuario(int id);
}
