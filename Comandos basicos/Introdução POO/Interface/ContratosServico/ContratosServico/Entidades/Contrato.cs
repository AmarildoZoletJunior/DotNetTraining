using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosServico.Entidades
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataInicio { get; set; }
        public double ValorTotal { get; set; }

       public  List<Parcelas> Parcelas { get; set; } = new List<Parcelas>();

        public Contrato(int numeroContrato, DateTime dataInicio, double valorTotal)
        {
            NumeroContrato = numeroContrato;
            DataInicio = dataInicio;
            ValorTotal = valorTotal;
        }
    }
}
