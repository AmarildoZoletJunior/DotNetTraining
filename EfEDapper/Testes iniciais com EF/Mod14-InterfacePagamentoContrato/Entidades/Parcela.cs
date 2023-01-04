using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Entidades
{
     class Parcela
    {
        public DateTime DataMes { get; set; }
        public double TotalMes { get; set; }

        public Parcela(DateTime dataMes, double totalMes)
        {
            DataMes = dataMes;
            TotalMes = totalMes;
        }

    }
}
