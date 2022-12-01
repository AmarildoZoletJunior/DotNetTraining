using ProdutosUsandoHeranca.Entidades;
using System;

namespace Teste
{
    class Primaria
    {
        public static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();
            Console.Write("Digite quantos produtos quer enviar\nR:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) {
                Console.Write($"Produto numero {i + 1}\n");
                Console.Write("Produto é?(Comum,Usado,Importado)\nR:");
                string decisao = Console.ReadLine();
                if(decisao == "Comum")
                {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();   
                    Console.Write("Preço\nR:");
                    double preco = double.Parse(Console.ReadLine());
                    Produto produto1 = new Produto(nome, preco);
                    lista.Add(produto1);
                }
                if(decisao == "Usado")
                {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();
                    Console.Write("Preço\nR:");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Manufaturado dia(dd/mm/yyyy)\nR:");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    ProdutoUsado produto2 = new ProdutoUsado(nome, preco,data);
                    lista.Add(produto2);
                }
                if(decisao == "Importado")
                {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();
                    Console.Write("Preço\nR:");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Custo de entrega\nR:");
                    double custo = double.Parse(Console.ReadLine());
                    Produto produto3 = new ProdutoImportado(nome, preco, custo);
                    lista.Add(produto3);
                }
            }
                foreach(Produto produto in lista)
            {
                Console.Write(produto.Tag());
            }
        }
    }
}