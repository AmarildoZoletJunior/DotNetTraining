using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoHeranca.Entidades
{
     class Triangulo : Forma
    {
        public double Width { get; set; }

     
        public double Height { get; set; }

        public Triangulo(double width, double height,Cor cor) : base(cor)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }
    }
}
