using AtividadeErros.Entidades;
using System;
using Exception = AtividadeErros.Entidades.Exception;

namespace Teste
{
    class Teste
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Digite os dados da conta");
                Console.Write("Número da conta\nR:");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Nome do cliente\nR:");
                string nome = Console.ReadLine();
                Console.Write("Valor inicial\nR:");
                double valorInicial = double.Parse(Console.ReadLine());
                Console.Write("Valor para limite de retirada\nR:");
                double limite = double.Parse(Console.ReadLine());
                ContaBancaria cliente1 = new ContaBancaria(n, nome, valorInicial, limite);

                Console.Write("Digite o valor que quer retirar\nR:");
                cliente1.Retirar(double.Parse(Console.ReadLine()));

                Console.WriteLine($"Novo saldo: {cliente1.Balance} ");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Você digitou algum caracter inválido\n" + e.Message);
            }
        }
    }
};