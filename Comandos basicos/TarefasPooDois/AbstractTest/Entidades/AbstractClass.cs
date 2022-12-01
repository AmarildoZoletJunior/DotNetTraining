using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTest.Entidades
{
    abstract class AbstractClass
    {
        public Color CorForma { get; set; }
       

        public AbstractClass(int cor)
        {
            CorForma = (Color)cor;
        }


        public abstract double Area();

    }

}
