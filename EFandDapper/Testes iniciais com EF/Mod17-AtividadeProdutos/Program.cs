using Mod17_AtividadeProdutos.Entidades;
using System;
using System.Globalization;
using System.Linq;

namespace ProgramaAtividade
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            List<Produto> ListaDeProdutos = new List<Produto>();
            string path = @"C:\Users\amarildojunior_frwk\Desktop\Repositório c#\EstudosRec\Módulo 1 POO\PASTABLOCODENOTAS\TesteLinq.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                   string[] leitura = sr.ReadLine().Split(',');
                    double valorProduto = double.Parse(leitura[1],CultureInfo.InvariantCulture);
                    ListaDeProdutos.Add(new Produto(leitura[0], valorProduto));
                }
            }
            var ValorMedio = ListaDeProdutos.Where(x => x.Valor > 0).Select(x => x.Valor).Average();
            Console.WriteLine(ValorMedio.ToString("F2"));
            var Abaixo = ListaDeProdutos.Where(x => x.Valor < 500.00).Select(p => p.Nome);
            foreach(var listaMenor in Abaixo)
            {
                Console.WriteLine(listaMenor);
            }
        }
    }
}