using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoHeranca.Entidades
{
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double width, double height,Cor cor) : base(cor)
        {
            Largura = width;
            Altura = height;
        }

        public override double Area()
        {
          return Largura * Altura;   
        }
    }
}
