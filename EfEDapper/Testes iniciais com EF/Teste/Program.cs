using Microsoft.EntityFrameworkCore;
using ProjetoReceitas;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var db = new DbArquivo()) { 
        //var UsuarioUm = db.Usuario.Where(x => x.Id == 1).Include(x => x.ReceitasCriadas).FirstOrDefault();
        //UsuarioUm.ReceitasCriadas.Add(new Receitas.Models.Models.Receita { Titulo = "Feijão", ModoPreparo = "Testando", Rendimento = 5});
        var receita1 = db.Receita.Where(x => x.ReceitaId == 3).Include(x => x.ListaIngredientes).FirstOrDefault();
        var ingredienteAdd = db.Ingrediente.Where(x => x.Id == 1).FirstOrDefault();
        var un = db.Un_Medida.Where(x => x.Id == 1).FirstOrDefault();
        db.IngredientesReceitas.Add(new Receitas.Models.Models.IngredientesReceitas { Ingrediente = ingredienteAdd, Receita = receita1, UnidadeMedida = un});
        //receita1.ListaIngredientes.Add(ingredienteAdd);
        db.SaveChanges();
            }
    }
}