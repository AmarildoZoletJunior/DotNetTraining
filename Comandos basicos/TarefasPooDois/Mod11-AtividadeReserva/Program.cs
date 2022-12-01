using Mod11_AtividadeReserva.Entidades;
using System;

namespace ProgramaReserva
{
    class Programa
    {
        public static void Main(string[] args)
        {
            try
            {
                Reserva teste = new Reserva(new DateTime(2022, 10, 07), new DateTime(2022, 12, 07), 50);
                Console.WriteLine(teste);
                teste.AlterarDatas(new DateTime(2022, 11, 07), new DateTime(2022, 11, 08));
                Console.WriteLine(teste);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}