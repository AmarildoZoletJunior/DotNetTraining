using AbstractTest.Entidades;
using System;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<AbstractClass> lista = new List<AbstractClass>();

            lista.Add(new Retangulo(2,20,30));
            lista.Add(new Circulo(3,50));
            foreach(AbstractClass c in lista)
            {
                Console.WriteLine(c.Area());
            }

            

        }
    }
}