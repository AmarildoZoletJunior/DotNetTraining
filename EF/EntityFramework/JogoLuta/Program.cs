using JogoLuta.Entidades;
using System;
using System.Linq;
using JogoLuta.Camada_Tela;
using JogoLuta;

namespace ProgramaLuta
{
    class Programa
    {
        public static void Main(string[] args)
        {
            try
            {

                VoltarMenu.PrimeiroMenu();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}