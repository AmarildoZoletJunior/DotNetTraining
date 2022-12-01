using ComparisionProblemaDelegate.Entidades;
using System;
using System.Security.Cryptography;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Produto> produto = new List<Produto>();

            produto.Add(new Produto("TV", 2500));
            produto.Add(new Produto("Tablet", 900));
            produto.Add(new Produto("Televisão", 500));

            produto.Sort(ordenarPorValor);
            foreach(var total in produto)
            {
                Console.WriteLine(total);
            }
            produto.
        }
        static int ordenarPorValor(Produto n1,Produto n2)
        {
            return n1.valor.CompareTo(n2.valor);
        }
    }
}