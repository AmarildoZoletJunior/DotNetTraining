using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.Entidade
{
     class TrianguloEntidade
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TrianguloEntidade(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double AreaTotal()
        {
            return (A + B + C) / 2;
        }
        
    }
}
