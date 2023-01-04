using Mod14_CarroAluguelInterface.Entidades;
using Mod14_CarroAluguelInterface.Servico;
using System;
using System.Globalization;

namespace ProgramaLocacao
{
    class Programa
    {
        public static void Main(string[] args)
        {
            Veiculo civic = new Veiculo("Civic");
            DatasAluguelCarro datas = new DatasAluguelCarro(new DateTime(2022, 09, 11), DateTime.Now,civic);
            TaxaBrasil taxaBrasil = new TaxaBrasil();
            TaxaEua taxaEua = new TaxaEua();
            ServicoAluguel servico = new ServicoAluguel(50, 100, taxaEua);
            servico.ProcessarPagamento(datas);
            Console.WriteLine($"{datas.Pagamentos}\nTotal de tempo de uso em dias:{datas.TotalTempoUso().ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}