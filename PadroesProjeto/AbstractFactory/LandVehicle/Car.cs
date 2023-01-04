using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicle
{
    class Car : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a carga");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando rota");
        }
    }
}
