using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_CarroAluguelInterface.Entidades
{
    internal class Pagamentos
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public double PagamentoTotal {
            get { return PagamentoBasico + Taxa; } 
            }
        public Pagamentos(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
        public override string ToString()
        {
            return $"Pagamento base:{PagamentoBasico}\nTaxa:{Taxa}\nPagamento Total:{PagamentoTotal}";
        }
    }
}
