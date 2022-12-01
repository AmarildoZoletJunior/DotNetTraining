using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Servicos
{
     interface ITaxa
    {
        public double CalculoTotal(int mes, double quantidade);

        public double TaxaFixa(double quantidade);
    }
}
