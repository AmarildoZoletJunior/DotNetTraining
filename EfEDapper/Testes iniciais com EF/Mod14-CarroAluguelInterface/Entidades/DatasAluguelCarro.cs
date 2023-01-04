using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_CarroAluguelInterface.Entidades
{
    internal class DatasAluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Pagamentos Pagamentos { get; set; }

        public DatasAluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }
        public double TotalTempoUso()
        {
            TimeSpan tempoCorrido = Fim.Subtract(Inicio);
            return tempoCorrido.TotalDays;
        }


    }
}
