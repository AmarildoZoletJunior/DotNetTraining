using MaiorIdade.Entidades;
using System;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Pessoa> Pessoas = new List<Pessoa>();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Nome?\nR:");
                string nome = Console.ReadLine();
                Console.Write("Idade?\nR:");
                int idade = int.Parse(Console.ReadLine());
                Pessoas.Add(new Pessoa(nome, idade));
            }
            int max = 0;
            foreach(Pessoa pessoa in Pessoas)
            {
                max = pessoa.Idade;
                if(pessoa.Idade > max)
                {
                    max = pessoa.Idade;
                }
            }
            Console.WriteLine(max);
        }
    }
}