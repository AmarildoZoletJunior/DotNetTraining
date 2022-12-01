using Mod15_ComparisonAtividade;
using System;

namespace ProgramaComparison
{
    class ProgramaPrincipal
    {
        delegate void SomarValor(List<Cliente> obj);
        public static void Main(string[] args)
        {
            List<Cliente> listas = new List<Cliente>();
            listas.Add(new Cliente(50, "Amarildo"));
            listas.Add(new Cliente(20, "Maria"));
            listas.AdicionarFundo();
            foreach(var li in listas)
            {
                Console.WriteLine(li.Preco);
            }
            SomarValor somar = ExtensionMethods.AdicionarFundo;
            listas.Sort((x1,x2) => x2.Preco.CompareTo(x1.Preco));
            listas.Sort(MudarOrdem);
            somar(listas);
            Console.WriteLine();
            foreach (var li in listas)
            {
                Console.WriteLine(li.Preco);
            }
        }
        public static int MudarOrdem(Cliente ClienteUm, Cliente ClienteDois)
        {
            return ClienteDois.Preco.CompareTo(ClienteUm.Preco);
        }
    }
}