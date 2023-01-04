using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicle
{
    internal class Patinete : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Entregador pegando carga");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega");
        }
    }
}
