using System;
using Triangulo.Entidade;

namespace Programa
{
    class ProgramaInicial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o lado a do triangulo:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado b do triangulo:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado c do triangulo:");
            double c = double.Parse(Console.ReadLine());
            TrianguloEntidade triangulo = new TrianguloEntidade(a,b,c);
            Console.WriteLine("Resultado: " + triangulo.AreaTotal());
        }
    }
}