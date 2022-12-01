using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest.Entidades
{
    internal class Retangulo : AbstractClass
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Retangulo(int cor, double width, double height) : base(cor)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
