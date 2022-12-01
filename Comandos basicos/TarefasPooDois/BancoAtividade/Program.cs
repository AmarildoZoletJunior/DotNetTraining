using BancoAtividade.Entidade;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ProgramaBanco
{
    class Programa
    {
        public static void Main(string[] args)
        {

            ClienteBanco cliente;
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja abrir a conta com um deposito?(S/N):");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 'S')
            {
            Console.WriteLine("Deseja depositar quanto?:");
                double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                cliente = new ClienteBanco(numero, nome, quantidade);
            }
            else
            {
                cliente = new ClienteBanco(numero, nome);
           
            }
            Console.WriteLine(cliente);
            Console.WriteLine();
            Console.WriteLine("Entre com o valor do deposito:");
            double quantidadeDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Deposito(quantidadeDeposito);
            Console.WriteLine(cliente);
            Console.WriteLine();
            Console.WriteLine("Entre com o valor do saque(Taxa de R$5):");
            double quantidadeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Saque(quantidadeSaque);
            Console.WriteLine(cliente);
            Console.WriteLine();


        }
    }
}