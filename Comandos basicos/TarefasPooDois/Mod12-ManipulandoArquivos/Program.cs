using System;
using System.IO;
namespace ProgramaArquivos
{
    class Programa
    {
        public static void Main(string[] args)
        {
            /*   try
               {
                   string CaminhoOrigem = @"C:\Users\amarildojunior_frwk\Desktop\BancoTest.txt";
                   //string CaminhoOrigem2 = @"C:\Users\amarildojunior_frwk\Desktop\BancoTest2.txt";
                   FileInfo file = new FileInfo(CaminhoOrigem);
                   //file.CopyTo(CaminhoOrigem2);
                   string[] linhas = File.ReadAllLines(CaminhoOrigem);
                   foreach(string l in linhas)
                   {
                       Console.WriteLine(l);
                   }
               }
               catch (IOException e)
               {
                   Console.WriteLine(e.Message);
               } */




            /*

            string CaminhoOrigem = @"C:\Users\amarildojunior_frwk\Desktop\BancoTest.txt";
            try{

                FileStream fs = new FileStream(CaminhoOrigem, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

            */

            /*
            string CaminhoOrigem = @"C:\Users\amarildojunior_frwk\Desktop\BancoTest.txt";
            using(FileStream fs = new FileStream(CaminhoOrigem, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string lines = sr.ReadLine();
                        Console.WriteLine(lines);
                    }
                
                }
            }
            */

            string CaminhoOrigem = @"C:\Users\amarildojunior_frwk\Desktop\BancoTest.txt";
            using(StreamReader sr = File.OpenText(CaminhoOrigem))
            {
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    Console.WriteLine(lines);
                }
            }








        }
    }
}