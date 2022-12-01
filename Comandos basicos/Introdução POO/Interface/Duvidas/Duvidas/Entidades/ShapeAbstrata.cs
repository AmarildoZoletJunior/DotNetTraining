using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvidas.Entidades
{
    
        abstract class ShapeAbstrata : IShape
    {
        public Color color;
        public abstract double area();
        

    }
}
