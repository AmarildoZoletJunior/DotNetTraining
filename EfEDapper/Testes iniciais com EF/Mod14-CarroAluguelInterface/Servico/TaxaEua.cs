using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_CarroAluguelInterface.Servico
{
     class TaxaEua : ITaxa
    {
        public double QuantidadeTaxa(double quantidade)
        {
            if(quantidade < 50)
            {
                return quantidade * 0.50;
            }
            else
            {
                return quantidade * 0.25;
            }
        }
    }
}
