using Mod14_CarroAluguelInterface.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_CarroAluguelInterface.Servico
{
    internal class TaxaBrasil : ITaxa
    {
        public double QuantidadeTaxa(double quantidade)
        {
            if(quantidade <= 100)
            {
                return quantidade * 0.20;
            }
            else
            {
                return quantidade * 0.15;
            }
              
        }
    }
}
