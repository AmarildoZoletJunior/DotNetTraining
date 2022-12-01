using System;
using System.IO;
using System.Threading.Tasks;

namespace teste
{
    class test
    {
        public static void Main(string[] args)
        {
            FileStream fs = null;
            StreamReader rs = null;
            string caminho = @"C:\Users\amarildojunior_frwk\Desktop\ola.txt";
            string caminho2 = @"C:\Users\amarildojunior_frwk\Desktop\ola2.txt";
            try
            {




                /* FileInfo fi = new FileInfo(caminho);
                 string[] lines = File.ReadAllLines(caminho);
                 foreach (string l in lines)
                 {
                     Console.WriteLine(l);
                 }
                */
                /*
                rs = File.OpenText(caminho);
                while (!rs.EndOfStream)
                {
                string line = rs.ReadLine();
                Console.WriteLine(line);    
                }
                */


                /*
            using (StreamReader sr = File.OpenText(caminho))
            {
                string[] lines 
                string line = sr.ReadLine();   
                Console.WriteLine(line);

            }
                */
                /*
                 
                 
              
                    string[] lines = File.ReadAllLines(caminho);
                using(StreamWriter sw = File.AppendText(caminho2))
            {
                foreach(string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
                */



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (rs != null) rs.Close();

            }


        }
    }
}