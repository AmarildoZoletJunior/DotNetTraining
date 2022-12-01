using System;

namespace Programa
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\amarildojunior_frwk\Desktop\Repositório c#\EstudosRec\Módulo 1 POO\PASTABLOCODENOTAS\TesteHash.txt";
            HashSet<string> set = new HashSet<string>();
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                set.Add(sr.ReadLine());
                }
            }
            Console.WriteLine();
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine($"Tens {set.Count} pessoas nesta lista");
        }
    }
}