using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoHeranca.Entidades
{
    
    abstract class Forma
    {
        public Cor cor {get; set; }
        
        public Forma(Cor color)
        {
            cor = color;
        }

        public abstract double Area();
    }
}
