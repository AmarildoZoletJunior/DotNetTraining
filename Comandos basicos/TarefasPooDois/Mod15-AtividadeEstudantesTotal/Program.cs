using Mod15_AtividadeEstudantesTotal;
using System;

namespace ProgramaTeste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            HashSet<Estudante> lista = new HashSet<Estudante>();

            lista.Add(new Estudante(50));
            lista.Add(new Estudante(20));
            lista.Add(new Estudante(44));
            lista.Add(new Estudante(44));
            lista.Add(new Estudante(44));
            lista.Add(new Estudante(59));

            foreach(Estudante list in lista)
            {
                Console.WriteLine(list.Id.GetHashCode());
            }
            Console.WriteLine(lista.Count());
        }
    }
}