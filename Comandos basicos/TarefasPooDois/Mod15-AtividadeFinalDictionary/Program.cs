using System;

namespace Teste
{
    class ProgramaDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string path = @"C:\Users\amarildojunior_frwk\Desktop\Repositório c#\EstudosRec\Módulo 1 POO\PASTABLOCODENOTAS\BlocoDic.txt";

            using(StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
       
                    string[] line = sr.ReadLine().Split(",");
                    int numero = int.Parse(line[1]);
                    if(dictionary.ContainsKey(line[0]))
                    {
                        dictionary[line[0]] += numero;
                    }
                    else
                    {
                        dictionary.Add(line[0], numero);
                    }
          
                }
            }
            foreach(var item in dictionary)
            {
                Console.WriteLine($"Nome:{item.Key}, Quantidade votos: {item.Value}");
            }
        }
    }
}