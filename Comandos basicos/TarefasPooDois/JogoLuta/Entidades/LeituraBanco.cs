using JogoLuta.Erros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JogoLuta.Entidades
{
     class LeituraBanco
    {
        public string CaminhoArquivo { get; set; }

        public List<Lutador> listaLutadores = new List<Lutador>();

        public LeituraBanco(string caminhoArquivo)
        {

            CaminhoArquivo = caminhoArquivo;
        }

        public string ListarLutadores()
        {
            string data = "Lista de Lutadores\n";
            using (StreamReader sr = File.OpenText(CaminhoArquivo))
            {
                if (sr.ReadLine() != null)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] teste = sr.ReadLine().Split(",");
                        listaLutadores.Add(new Lutador(teste[0], int.Parse(teste[2]), int.Parse(teste[1]), double.Parse(teste[3])));
                    }
                }
                else
                {
                    data = "Ñão existe lutadores cadastrados";
                    return data;
                }
            }
            foreach (var lutador in listaLutadores)
            {
              data += $"\n{lutador}\n";
            }
            return data;
        }
        public void AdicionarLutador()
        {

            Console.WriteLine("Qual nome dele?");
            string Nome = Console.ReadLine();
            Console.Write("Quantos de dano ele da?(Até 20):");
            double Dano = double.Parse(Console.ReadLine());
            Console.Write("Quantos de vida ele tem?(Até 150):");
            int Vida = int.Parse(Console.ReadLine());
            Console.Write("Qual peso dele?(Maior que 40 menor que 250)");
            double peso = double.Parse(Console.ReadLine());
            if (Dano > 25)
            {
                throw new Errors("O ataque não pode ser maior que 25");
            }
            if (Vida > 150)
            {
                throw new Errors("A vida não pode ser maior que 150");
            };
            if(peso < 40 || peso > 250)
            {
                throw new Errors("O peso não pode ser menor que 40 e maior que 250");
            }
   
            using (StreamWriter sr = File.AppendText(CaminhoArquivo))
            {
                sr.Write($"\n{Nome},{Vida},{Dano},{peso}");
            }
        }
    }
}
