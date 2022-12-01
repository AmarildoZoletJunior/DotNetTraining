using Mod17_AtividadeRemoverDelegatePredicate.Entidade;
using System;

namespace ProgramaDelegate
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            List<Produto> listaProduto = new List<Produto>();

            listaProduto.Add(new Produto("Amaciante", 7.50));
            listaProduto.Add(new Produto("Detergente", 8));
            listaProduto.Add(new Produto("Sabonete", 2.50));
            listaProduto.Add(new Produto("Cloro", 15.50));

            listaProduto.RemoveAll(x1 => x1.Preco > 10);
            Console.WriteLine();
            foreach (Produto produto in listaProduto)
            {
                Console.WriteLine(produto.Preco);
            }
            Console.WriteLine();
            Action<Produto> teste = Teste;
            listaProduto.ForEach(teste);
            foreach (Produto produto in listaProduto)
            {
                Console.WriteLine(produto.Preco);
            }
            Console.WriteLine();
            Action<Produto> produtso = p => { p.Preco += p.Preco * 0.10; };
            listaProduto.ForEach(produtso);
            Console.WriteLine();
            foreach(Produto produto in listaProduto)
            {
                Console.WriteLine(produto.Preco);
            }
        }
        public static void Teste(Produto obj)
        {
            obj.Preco += obj.Preco * 0.50;
        }
    }
}