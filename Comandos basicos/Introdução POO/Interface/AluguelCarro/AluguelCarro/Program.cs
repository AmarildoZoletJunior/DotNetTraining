using AluguelCarro.Entidades;
using AluguelCarro.Entidades.Services;
using System;

namespace teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do aluguel");
            Console.Write("Modelo do carro?\nR:");
            string modelo = Console.ReadLine();
            Console.Write("Data de saida?\nR:");
            DateTime saida = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de retorno?\nR:");
            DateTime retorno = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor cobrado por hora?\nR:");
            double hora = double.Parse(Console.ReadLine());
            Console.Write("Valor cobrado por dia\nR:");
            double dia = double.Parse(Console.ReadLine());

            Aluguel teste = new Aluguel(new Carro(modelo), saida, retorno);

            AluguelValor rental = new AluguelValor(hora, dia);

            rental.Processamento(teste);

            Console.WriteLine(teste.tot);
            //Aluguel aluguel = new Aluguel(modelo, saida, retorno, hora, dia);

            //Console.Write(aluguel);
        }
    }
}