using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11_AtividadeReserva.Entidades
{
     class Reserva
    {
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int NumeroQuarto { get; set; }

        public Reserva(DateTime dataEntrada, DateTime dataSaida, int numeroQuarto)
        {
            if(DataEntrada < DateTime.Now)
            {
                DataEntrada = dataEntrada;
            }
            else
            {
                throw new TesteEx("A data de entrada não pode ser menor que a data do dia de hoje");
            }
            if(DataSaida < DataEntrada)
            {
                DataSaida = dataSaida;
            }
            else
            {
                throw new TesteEx("A data de saida não pode ser menor que a data de entrada");
            }
            if(NumeroQuarto is int)
            {
                NumeroQuarto = numeroQuarto;
            }
            else
            {
                throw new TesteEx("Necessita que seja um numero no campo Numero do Quarto");
            }
         
        }
        public string Duracao()
        {
            TimeSpan teste = DataSaida.Subtract(DataEntrada);
            return $"{teste.TotalDays}";
        }
        public void AlterarDatas(DateTime Entrada,DateTime Saida)
        {
            if(Entrada < DateTime.Now)
            {
                DataEntrada = Entrada;
            }
            else
            {
                throw new TesteEx("A data de entrada não pode ser menor que a de hoje.");
            }
            if(Saida > Entrada)
            {
                DataSaida = Saida;
            }
            else
            {
                throw new TesteEx("A data de saida não pode ser menor que a data de entrada");
            }
        }

        public override string ToString()
        {
            return $"{DataEntrada} -------- {DataSaida}\nDuração: {Duracao()} Dias";
        }
    }
}
