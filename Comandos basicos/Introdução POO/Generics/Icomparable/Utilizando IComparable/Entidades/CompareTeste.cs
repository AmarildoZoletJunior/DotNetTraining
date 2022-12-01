using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_IComparable.Entidades
{
    internal class CompareTeste : IComparer<Funcionario>
    {
        public int Compare(Funcionario a, Funcionario b)
        {
            if(a.Salario > b.Salario)
            {
                return 1;
            }
            if(a.Salario == b.Salario)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

    }
}
