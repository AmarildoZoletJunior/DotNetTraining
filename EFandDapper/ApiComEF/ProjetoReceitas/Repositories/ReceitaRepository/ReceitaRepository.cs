using Microsoft.EntityFrameworkCore;
using ProjetoReceitas.Repositories.UsuarioRepository;
using Receitas.Models.Models;

namespace ProjetoReceitas.Repositories.ReceitaRepository
{
    public class ReceitaRepository : IReceitaRepository
    {
        public readonly DbArquivo _db;

        public ReceitaRepository(DbArquivo db)
        {
            _db = db;
        }
        public List<Receita> ListaDeReceitas()
        {
            var Receitas = _db.Receita.ToList();
            return Receitas;
        }

        public Receita ReceitaUnica(string nome)
        {
           Receita receita = _db.Receita.Where(x => x.Titulo == nome).Include(x => x.ListaIngredientes).FirstOrDefault();
            return receita;
        }
        public void Add(Receita receita)
        {
            _db.Receita.Add(receita);
            _db.SaveChanges();
        }

        public void Deletar(int id)
        {
            Receita receita = _db.Receita.Where(x => x.ReceitaId == id).FirstOrDefault();
            _db.Receita.Remove(receita);
            _db.SaveChanges();
        }

        public void Update(Receita receita)
        {   
            var ReceitaConsultada = _db.Receita.Include(x => x.ListaIngredientes).SingleOrDefault(x => x.ReceitaId == receita.ReceitaId);
            foreach(var excluir in ReceitaConsultada.ListaIngredientes)
            {
               ReceitaConsultada.ListaIngredientes.Remove(excluir);
            }
            _db.SaveChanges();
            _db.ChangeTracker.Clear();

            var ingredientesReceitaFora = receita.ListaIngredientes;
            receita.ListaIngredientes = new List<Ingrediente>();
            foreach(var ingredientes in ingredientesReceitaFora)
            {
                var buscado = _db.Ingrediente.Find(ingredientes.Id);
                receita.ListaIngredientes.Add(buscado);
            }
            _db.Receita.Update(receita);
            _db.SaveChanges();
        }
        public List<Receita> ReceitasDoUsuario(int id)
        {
            var ReceitasDeUsuarioProcurado = _db.Receita.Where(x => x.UsuarioId == id).Include(x => x.ListaIngredientes).ToList();
            return ReceitasDeUsuarioProcurado;
        }
    }
}
