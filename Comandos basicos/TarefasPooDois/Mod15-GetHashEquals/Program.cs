using Mod15_GetHashEquals.Entidades;
using System;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Computador teste = new Computador("A");
            Notebook teste2 = new Notebook("A");
            Console.WriteLine(teste.Equals(teste));
            Console.WriteLine(teste.GetHashCode());
            Console.WriteLine(teste2.GetHashCode());
        }
    }
}