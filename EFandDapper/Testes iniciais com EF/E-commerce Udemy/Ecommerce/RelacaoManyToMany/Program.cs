// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using RelacaoManyToMany;
using RelacaoManyToMany.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        using (var db = new TomanyContext())
        {
            //var resultado = db.Colaboradores.Include(x => x.Turmas);
            //var result = db.Turmas.Where(x => x.Id == 1).FirstOrDefault();
           // var TurmaRe = db.Turmas.Include(x => x.Colaboradores).FirstOrDefault(x => x.Id == 1);
            ////Console.WriteLine(TurmaRe.Nome);
           // var colab = db.Colaboradores.Include(x => x.Turmas).FirstOrDefault(X => X.Id == 3);
            //colab.Turmas.Add(TurmaRe);
            // Colaborador objColab = new Colaborador() { Nome = colab.Nome, Id = colab.Id };
            //Turma objTurma = new Turma() { Nome = resultadoColaborador.Nome, Id = resultadoColaborador.Id };
            // objColab.Turmas.Add(objTurma);
            //Console.WriteLine($"{colab.Nome} ---- {resultadoColaborador.Nome}");
            var consultaTeste = db.Turmas!.Include(x => x.Colaboradores);
            foreach(var consulta in consultaTeste)
            {
                Console.WriteLine("Nome Turma: " + consulta.Nome);
                foreach(var con in consulta.Colaboradores!)
                {
                    Console.WriteLine("Nome Colaborador: " + con.Nome);
                }
            }
           //  db.SaveChanges();
        };
    }
}