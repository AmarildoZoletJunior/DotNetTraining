using Dictionary.Entidades;
using System;
using System.Collections.Generic;

namespace teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\amarildojunior_frwk\Downloads\Candidatos.txt";
            Dictionary<string, int> cookies = new Dictionary<string, int>();  

            using(StreamReader sr =  File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] array = sr.ReadLine().Split(",");
                    if (cookies.ContainsKey(array[0]))
                    {
                        cookies[array[0]] += int.Parse(array[1]);
                    }
                    else {
                        cookies[array[0]] = int.Parse(array[1]);
                    }
             
                }

                foreach(var teste in cookies)
                {
                    Console.WriteLine($"{teste.Key} = {teste.Value}");
                }
               
            }

        }
    }
}