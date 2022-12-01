using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades.Services
{
   class TaxaBrasil : ITax
    {
        public int MyProperty { get; set; }
        public double ValorTaxa(double quantidade)
        {
            if (quantidade > 0 && quantidade <= 100)
            {
                return quantidade * 0.2;
            }
            else
            {
                return quantidade * 0.15;
            }
        }
    }
}
