using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
     class Motor
    {
        public int Power { get; set; }

        public Motor(int power)
        {
            Power = power;
        }   
    }
}
