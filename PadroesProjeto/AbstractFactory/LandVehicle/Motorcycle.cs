using System;

namespace AbstractFactory.LandVehicle
{
    class Motorcycle : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a carga");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando trajeto na rua");
        }
    }
}
