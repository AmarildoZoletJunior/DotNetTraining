using StructTeste;
using System;

namespace Teste
{
    class ProgramaTeste
    {
        public static void Main(string[] args)
        {
            struct1 teste1 = new struct1();
            struct1 teste2 = new struct1();
            teste1.x = 59;
            teste2 = teste1;
            Console.WriteLine(teste1.x);
            Console.WriteLine(teste2.x);
            teste1.x = 20;
            Console.WriteLine();
            Console.WriteLine(teste1.x);
            Console.WriteLine(teste2.x);


            double? teste = null;

            Console.WriteLine( teste.Value);
        }
    }
}