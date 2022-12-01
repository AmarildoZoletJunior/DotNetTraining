using AnimaisEstimação.Entidades;
using System;

namespace teste
    {
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Animais> teste = new List<Animais>();
            int G = 0, P = 0, C = 0;
            for(int i = 0; i < 2; i++)
            {
                Console.Write($"Digite o nome do {i+1} Animal\nR:");
                string nome = Console.ReadLine();
                Console.Write("Digite qual animal é(Peixe/Cachorro/Gato)\nR:");
                string tipo = Console.ReadLine();
                Console.Write("Qual idade dele?\nR:");
                int idade = int.Parse(Console.ReadLine());
                teste.Add(new Animais(nome, idade, tipo));
            }
            foreach(Animais animais in teste)
            {
                if(animais.Tipo == "Gato")
                {
                    G++;
                }else
                if(animais.Tipo == "Cachorro")
                {
                    C++;
                }else
                if(animais.Tipo == "Peixe")
                {
                    P++;
                }
                else
                {
                    P++;
                }
            }
            Console.WriteLine($"Quantidade\nCachorro:{C}\nGato:{G}\nPeixe:{P}");
        }
    }
}