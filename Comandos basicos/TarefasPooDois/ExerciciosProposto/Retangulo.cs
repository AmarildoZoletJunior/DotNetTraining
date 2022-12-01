using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProposto
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }


        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }
        public double Diagonal() {
        return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
