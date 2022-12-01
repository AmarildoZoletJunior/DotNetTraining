using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosServico.Servicos
{
     interface IPagamentoOnline
    {
        public double TaxaPagamento(double quantidade); //TaxaPagamento necessita do valor de JurosMes
        public double JurosMes(double quantidade, int mes); 

    }
}
