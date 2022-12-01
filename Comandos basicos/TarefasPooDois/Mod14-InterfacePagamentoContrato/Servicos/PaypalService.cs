using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Servicos
{
     class PaypalService : ITaxa
    {
        public double CalculoTotal(int mes,double quantidade)
        {
            double Soma = quantidade * (mes * 0.01);
            return Soma + TaxaFixa(Soma) + quantidade;
        }
        public double TaxaFixa(double quantidade)
        {
            return quantidade * 0.01;
        }
    }
}
