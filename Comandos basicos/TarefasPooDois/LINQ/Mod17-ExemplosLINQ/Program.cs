using System;
using System.Linq;

namespace ProgramaLinq
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultado = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 2);
            foreach(int resultados in resultado)
            {
                Console.WriteLine(resultados);
            }
        }
    }
}