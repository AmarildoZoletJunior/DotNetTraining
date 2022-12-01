using System;
using UtilizandoExtensionMethods.Extensao;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite as horas (dd/mm/yyyy)\nR:");
            DateTime dt = new DateTime(2018,11,16,8,10,45);
            Console.WriteLine(dt.teste());
            string s1 = "Ola a todos meu nome é Amarildo";
            Console.WriteLine(s1.Cut(10));
        }
    }
}