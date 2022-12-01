using GenericsParteUm.Entidades;
using System;
using System.Collections.Generic;


namespace teste
{
    class Teste
    {
        public static void Main(string[] args)
        {
            ServicoPrint<int> teste = new ServicoPrint<int>();
            Console.Write("Quantos valores serão digitados: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i < n; i++)
            {
                Console.Write("Digite o valor que vai adicionar: ");
                int na = int.Parse(Console.ReadLine());
                teste.AdicionarValor(na);
            }
            teste.Ler();
            Console.WriteLine("First: " + teste.Primeiro());

           

        }
    }
}