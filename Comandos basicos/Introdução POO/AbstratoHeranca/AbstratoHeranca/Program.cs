using AbstratoHeranca.Entidades;
using System;


namespace Teste
{
    class Teste
    {
        public static void Main(string[] args)
        {
            List<Forma> lista = new List<Forma>();
            Console.Write("Quantas figuras você deseja iniciar\nR:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Forma?(Retangulo/Triangulo)\nR:");
                string decisao = Console.ReadLine();
                if(decisao == "Retangulo")
                {
                    Console.Write("Cor?(Branco/Preto/Vermelho)\nR:");
                    Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                    Console.Write("Altura?\nR:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.Write("Largura?\nR:");
                    double largura = double.Parse(Console.ReadLine());
                    Forma forma = new Retangulo(largura, altura, cor);
                    lista.Add(forma);
                }
                if(decisao == "Triangulo")
                {
                    Console.Write("Cor?(Branco/Preto/Vermelho)\nR:");
                    Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                    Console.Write("Altura?\nR:");
                    double altura = double.Parse(Console.ReadLine());
                    Console.Write("Largura?\nR:");
                    double largura = double.Parse(Console.ReadLine());
                    Forma forma = new Triangulo(largura, altura, cor);
                    lista.Add(forma);
                }
            }
            string texto = "Area calculada\n";
            foreach(Forma forma in lista)
            {
                texto += $"{forma.Area()}\n";
            }
            Console.WriteLine(texto);
        }
    }
}
