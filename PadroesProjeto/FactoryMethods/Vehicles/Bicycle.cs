using FactoryMethods.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a carga na bicicleta");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega");
        }
    }
}
