using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoEstatico.Entidade
{
     static class Conversor
    {
        public static double QuantidadePagar(double preco, double quantidade)
        {
            return preco * quantidade;
        }
    }
}
