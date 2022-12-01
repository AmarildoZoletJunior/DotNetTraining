using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades
{
     class Valores
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }
        public Valores(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }


        public override string ToString()
        {
            string texto;
            texto = "Nota de pagamento\n";
            texto += $"Pagamento sem taxa: R$ {PagamentoBasico}\n";
            texto += $"Taxa: R$ {Taxa}\n";
            texto += $"Pagamento total: R$ {PagamentoTotal}";
            return texto;
        }

    }
}
