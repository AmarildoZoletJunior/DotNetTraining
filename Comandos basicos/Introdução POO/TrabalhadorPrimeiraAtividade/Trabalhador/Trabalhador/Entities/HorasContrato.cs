using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhador.Entities
{
    class HorasContrato
    {
        public DateTime data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        public HorasContrato()
        {

        }

        public HorasContrato(DateTime Data, double valorHora, int horas)
        {
            data = Data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double TotalValor()
        {
            return ValorHora * Horas;
        }
    }
}
