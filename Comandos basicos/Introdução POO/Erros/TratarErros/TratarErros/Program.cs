using System;
using TratarErros.Entidades;
using Exception = TratarErros.Entidades.Exception;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o numero do quarto\nR:");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Data de entrada\nR:");
                DateTime diaEntrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Dia de saida\nR:");
                DateTime diaSaida = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(n, diaEntrada, diaSaida);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message );
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}