using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoExtensionMethods.Extensao
{
    static class StringCut
    {
        public static string Cut(this string thisString,int number)
        {
            string nova = string.Empty;
            for (int i = 0; i < number; i++)
            {
                nova += thisString[i];
            }
            return nova;
        }
    }
}
