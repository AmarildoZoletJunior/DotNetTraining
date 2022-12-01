using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public static double Calculo(double i,double a)
        {
            return i * a;
        }
        public static double Calculo(int i, int a)
        {
            return i + a;
        }
    }
}
