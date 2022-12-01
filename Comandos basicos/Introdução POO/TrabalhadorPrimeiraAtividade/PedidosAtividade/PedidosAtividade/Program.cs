using PedidosAtividade.Entidades;
using System;



namespace ProgramaPrincipal
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.Write("\nEntre com os dados do Cliente\n");
            Console.Write("\nDigite o Nome\nR:");
            string nomeCliente = Console.ReadLine();
            Console.Write("\nDigite o email\nR:");
            string emailCliente = Console.ReadLine();
            Console.Write("\nDigite a data de nascimento(dd/mm/yyyy)\nR:");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nomeCliente,emailCliente,data);



            Console.Write("\nEntre com os dados do pedido\n");
            Console.Write("\nDigite o status(PagamentoPendente,Processando,Postado,Entregue)\nR:");
            OrdemStatus os = Enum.Parse<OrdemStatus>(Console.ReadLine());
            Ordem ordens = new Ordem(os, cliente);

            Console.Write("\nQuantos itens distintos tem?\nR:");
            int num = int.Parse(Console.ReadLine());
           
            for(int i = 0; i < num; i++)
            {
                Console.Write("\n--------------------------------------\n");
                Console.Write($"\nPedido numero {i+1}\n");
            Console.Write("\nNome do produto\nR:");
            string nomeProduto = Console.ReadLine();
            Console.Write("\nPreço do produto\nR:");
                double preco = double.Parse(Console.ReadLine());
            Console.Write("\nQuantidade do pedido\nR:");
                int quantidade = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto, preco);
                OrdemItem ordem = new OrdemItem(quantidade, produto);
                ordens.AdicionarItem(ordem);
            }
            Console.WriteLine(ordens);
        }
    }
}