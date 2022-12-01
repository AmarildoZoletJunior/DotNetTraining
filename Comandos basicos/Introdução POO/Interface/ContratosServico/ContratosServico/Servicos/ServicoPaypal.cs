using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosServico.Servicos
{
    class ServicoPaypal : IPagamentoOnline
    {
        public virtual double TaxaPagamento(double quantidade)
        {
            return quantidade * 0.02;
        }
        public double JurosMes(double quantidade, int meses)
        {   
                return meses * 0.01 * quantidade;  
        }
    }
}
