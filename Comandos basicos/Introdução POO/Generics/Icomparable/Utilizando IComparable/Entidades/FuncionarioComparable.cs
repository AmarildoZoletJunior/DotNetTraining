using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizando_IComparable.Entidades
{
    class FuncionarioComparable
    {

    public T Max<T>(List<T> list) where T : IComparable
        {
            T proximo = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(proximo) > 0)
                {
                    proximo = list[i];
                }
            }
            return proximo;
        }

    }
}
