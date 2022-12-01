using Aluguel2.Entidades;
using Aluguel2.Servico;
using System;
using System.Globalization;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite os dados do carro");

            Console.WriteLine("Digite o modelo do veiculo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Data de Retirada do veiculo(dd/MM/yyyy hh:mm): ");
            DateTime teste = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Dia de retorno: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor por dia: ");
            double valorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ServicoAluguel servico = new ServicoAluguel(valorHora, valorDia,new TaxaBrasil());

            AluguelCarro carro = new AluguelCarro(teste, finish, new Veiculo(nome));

            servico.ProcessarFatura(carro);

            Console.WriteLine(carro.Fatura);

        }
    }
}