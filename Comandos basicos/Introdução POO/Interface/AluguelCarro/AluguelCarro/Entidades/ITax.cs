using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades
{
    public interface ITax
    {
      int MyProperty { get; set; }
      double ValorTaxa(double quantidade);

    }
}
