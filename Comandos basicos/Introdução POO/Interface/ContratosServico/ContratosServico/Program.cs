using ContratosServico.Entidades;
using ContratosServico.Servicos;
using System;
using System.Globalization;

namespace Teste
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com os dados da compra\n");
            Console.Write("Digite o numero do pagamento\nR:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Qual data de inicio?(dd/MM/yyyy)\nR:");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());   
            Console.Write("Digite o valor do contrato\nR:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantas vezes você quer pagar?\nR:");
            int n = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, dataInicio, valor);

            ServicoPaypal servico = new ServicoPaypal();

            ContratoServico contratoServico = new ContratoServico(servico);

            contratoServico.ProcessamentoDeContrato(contrato, n);

            double total = 0;
            foreach(Parcelas parcelas in contrato.Parcelas)
            {
                Console.WriteLine(parcelas);
                total += parcelas.total;
            }
            Console.WriteLine(total);
        }
    }
}