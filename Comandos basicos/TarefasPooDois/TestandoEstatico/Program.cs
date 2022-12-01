using System;
using System.Globalization;
using TestandoEstatico;
using TestandoEstatico.Entidade;

namespace Teste
{
    class Programa
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da cotação atual da moeda:");
            double moeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor que quer converter:");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = R$ {Conversor.QuantidadePagar(moeda,quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}