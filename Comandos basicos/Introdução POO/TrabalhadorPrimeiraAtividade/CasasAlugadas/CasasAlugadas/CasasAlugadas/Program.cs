using CasasAlugadas.Entidades;
using System;
using System.Data;

namespace Programa
{
    class ProgramaPrimario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("             Seja bem vindo ao sistema\n\n\n\n\n");
            Console.Write("Vamos cadastrar seus dados\nR:");
           
            Console.Write("Digite Seu nome\nR:");
            string nome = Console.ReadLine();
            Console.Write("Digite a quantidade de casas que você tem\nR:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite a região que as casas estão\nR:");
            Regiao regiao = new Regiao(Console.ReadLine());
            Dono dono = new Dono(quantidade, nome, regiao);
            Console.WriteLine("Digite quantas casas serão alugadas(Não ultrapasse o valor de casas que você possui)");
            int n = int.Parse(Console.ReadLine());
            if(n <= dono.QuantidadeDeCasa)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Digite a data inicial do aluguel(mm/yyyy)\nR:");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.Write("Digite o valor cobrado por dia\nR:");
                    double valorDia = double.Parse(Console.ReadLine());
                    Console.Write("Digite quantos dias será alugado\nR:");
                    int dias = int.Parse(Console.ReadLine());
                    Console.WriteLine("Diga o tamanho da sua residencia(Pequena,Média,Grande)\nR:");
                    Tamanho tam = Enum.Parse<Tamanho>(Console.ReadLine());
                    Aluguel teste = new Aluguel(data,valorDia,dias,tam);
                    dono.AlugarCasa(teste);
                }
            }
            Console.WriteLine("O ganho na temporada entre Dezembro a Março foi de: " + dono.GanhoTemporada());
            Console.WriteLine("Sem temporada: " + dono.GanhoSemTemporada());
        }
    }
}