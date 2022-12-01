using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratarErros.Entidades
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataEntrada < DateTime.Now)
            {
                throw new Exception("Erro, deve marcar o dia de entrada depois da data de hoje");
            }
            if (dataEntrada < dataSaida)
            {
                throw new Exception("Erro, o dia de saida necessita ser maior que o de entrada");
            }
           
            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int Duracao()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada);
            return (int)duracao.TotalDays;
        }

        public void AtualizarData(DateTime entrada,DateTime saida)
        {
            if (entrada < DateTime.Now || saida < DateTime.Now)
            {
                throw new Exception("Erro, o dia de entrada tem que mais adiante que a data atual");
            }
            if (entrada > saida)
            {
                throw new Exception("Erro, dia de saida tem que ser maior que de entrada");
            }
           

            DataEntrada = entrada;
            DataSaida= saida;
        }

        public override string ToString()
        {
            string texto = "Ficha de Locação de quarto:\n";
            texto += $"Numero do quarto: {NumeroQuarto}\n";
            texto += $"Data de entrada: {DataEntrada.ToString("dd/MM/yyyy")}\n";
            texto += $"Data de saida: {DataSaida.ToString("dd/MM/yyyy")}\n";
            return texto;
        }
    }
}
