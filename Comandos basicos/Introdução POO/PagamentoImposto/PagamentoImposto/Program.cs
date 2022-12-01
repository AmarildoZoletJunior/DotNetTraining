using PagamentoImposto.Entidades;
using System;
using System.Globalization;

namespace Programa
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            string texto = "Relatório de pagamentos de impostos\n";
            double total = 0;
            Console.Write("Quantas pessoas quer cadastrar?\nR:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
            Console.Write("Pessoa juridica ou Fisica?(f/j)\nR:");
                char decisao = char.Parse(Console.ReadLine());

                if(decisao == 'f')
                    {
                      Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();
                      Console.Write("Renda Anual\nR:");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                      Console.Write("Gasto com saude?\nR:");
                    double gasto = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                    Pessoa pessoa1 = new PessoaFisica(nome, renda, gasto);
                    lista.Add(pessoa1);
                }
                    else
                        {
                    Console.Write("Nome\nR:");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual\nR:");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                    Console.Write("Quantos funcionarios?\nR:");
                    int quantidadeFuncionario = int.Parse(Console.ReadLine());
                    Pessoa pessoa2 = new PessoaJuridica(nome, renda, quantidadeFuncionario);
                    lista.Add(pessoa2);
                }
            }
            foreach(Pessoa pessoa in lista)
            {
                texto += $"{pessoa.Nome}, Valor: {pessoa.ImpostoPago().ToString("F2")}\n";
                total += pessoa.ImpostoPago();
            }
            Console.Write(texto);
            Console.Write($"\nTotal de imposto: {total.ToString("F2")}");
        }
    }
}