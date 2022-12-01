using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Servicos
{
     class Nubank : ITaxa
    {
        public double CalculoTotal(int mes, double quantidade)
        {
            double Soma = quantidade * (mes * 0.03);
            return Soma + TaxaFixa(Soma);
        }
        public double TaxaFixa(double quantidade)
        {
            return quantidade * 0.01;
        }
    }
}
