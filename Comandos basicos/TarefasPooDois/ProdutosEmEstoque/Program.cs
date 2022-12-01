using ProdutosEmEstoque.Entidades;
using System;
using System.Globalization;

namespace ProgramProduto
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite nome do produto:");
            string Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade deste produto:");
            int Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada unidade:");
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto produtoEstoque = new Produto(Nome,Valor,Quantidade);

            Console.WriteLine( );
            Console.WriteLine(produtoEstoque);
            Console.WriteLine();

            Console.WriteLine("Quantos deseja adicionar?:");
            int QuantidadeAdd = int.Parse(Console.ReadLine());
            produtoEstoque.Adicionar(QuantidadeAdd);
            Console.WriteLine();

            Console.WriteLine(produtoEstoque);

            Console.WriteLine();

            Console.WriteLine("Quantos deseja remover:");
            int QuantidadeRemover = int.Parse(Console.ReadLine());
            produtoEstoque.Remover(QuantidadeRemover);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(produtoEstoque);

        }
    }
}