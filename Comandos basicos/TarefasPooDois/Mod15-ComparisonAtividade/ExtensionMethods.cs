using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod15_ComparisonAtividade
{
    static class ExtensionMethods
    {
        public static void AdicionarFundo(this List<Cliente> obj)
        {
           foreach(var list in obj)
            {
                list.Preco += 50;
            }
        }
    }
}
