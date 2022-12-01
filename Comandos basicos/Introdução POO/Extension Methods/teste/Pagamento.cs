using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Pagamento
    {
        public static double Calcular(double salario,double imposto)
        {
            return salario + imposto;
        }
        public static class Salario
        {
            public const double valor = 1500;
            public const double imposto = 500;
            public static double salarioLiquido()
            {
                return valor - imposto;
            }
        }
    }
}
