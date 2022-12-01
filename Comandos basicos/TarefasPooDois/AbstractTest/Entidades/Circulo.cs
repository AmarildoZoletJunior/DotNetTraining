using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest.Entidades
{
    class Circulo : AbstractClass
    {
        const double Pi = 3.1415;
        public double Raio { get; set; }
        public Circulo(int cor, double raio) : base(cor)
        {

            Raio = raio;
        }
        public override double Area()
        {
            return Pi * (Raio * Raio);
        }
    }
}
