using System;


namespace ProdutosArray
{
	class ProdutosA
	{
	public string Nome { get; set; }
		public double Preco { get; set; }


        /* 
         Console.Write("Digite o tamanho do array\nR:");
           int n = int.Parse(Console.ReadLine());
                double soma = 0.0;
               ProdutosA[] produto = new ProdutosA[n];
            for(int i = 0; i < n; i++)
                {
                    Console.Write($"Digite o nome do produto(Posição{i+1})\nR:");
                    string nome = Console.ReadLine();
                    Console.Write($"Digite o preço do produto(Posição {i+1})\nR:");
                    double preco = double.Parse(Console.ReadLine());
                    produto[i] = new ProdutosA {Nome = nome , Preco = preco};
                }
            for(int i = 0; i < n; i++)
                {
                    Console.WriteLine(produto[i]);
                    soma += produto[i].Preco;
                }
            Console.WriteLine($"A média é: {soma / n}");
                Console.Read();
         */

        public override string ToString()
		{
			return $"Nome do produto: {Nome}\nPreço do produto: R${Preco}";
		}
	}
}
