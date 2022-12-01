using AtividadeLogUsuarios.Entidade;
using System;
namespace Programa
{
    class NewPrograma
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\amarildojunior_frwk\Downloads\teste.txt";

            HashSet<RegistroLog> registro = new HashSet<RegistroLog>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        //Estamos lendo aqui todas as stirngs 
                        string[] separar = sr.ReadLine().Split(' ');
                        string nome = separar[0];
                        DateTime horario = DateTime.Parse(separar[1]);
                        registro.Add(new RegistroLog { Nome = nome, dataLog = horario });
                    }
                    Console.WriteLine("Total de usuarios: " + registro.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}