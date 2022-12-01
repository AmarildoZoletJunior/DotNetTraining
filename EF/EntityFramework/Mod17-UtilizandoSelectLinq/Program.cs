using Mod17_UtilizandoSelectLinq.Entidade;
using System;
using System.Linq;

namespace ProgramaIntroducao
{
    class ProgramaPrincpal
    {
        public static void Main(string[] args)
        {
            List<Produto> listaProduto = new List<Produto>();
            listaProduto.Add(new Produto("Detergente", 25));
            listaProduto.Add(new Produto("Cloro", 12));
            listaProduto.Add(new Produto("Sabão", 9));
            listaProduto.Add(new Produto("Sabonete", 19));
            listaProduto.Add(new Produto("Amaciante", 15));
            listaProduto.Add(new Produto("Esponja", 20));
            List<string> resultado = listaProduto.Select(NomeAlto).ToList();
            foreach(string d in resultado)
            {
                Console.WriteLine(d);
            }
        }
        public static string NomeAlto(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}