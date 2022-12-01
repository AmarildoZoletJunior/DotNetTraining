using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod15_TestandoGenerics.Entidades
{
     class Classificados
    {
        public void Correr<T>(T n1,T n2) where T : IComparable
        {
            if(!(n1 is T && n2 is T))
            {
                throw new ArgumentException("Erro");
            }
            if (n1.CompareTo(n2) > 0){
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }
    }
}
