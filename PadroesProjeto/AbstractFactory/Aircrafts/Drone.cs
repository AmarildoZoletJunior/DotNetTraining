using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos fracos");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga acoplada no drone");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Saindo para entrega");
        }
    }
}
