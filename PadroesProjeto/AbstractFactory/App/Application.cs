using AbstractFactory.Aircrafts;
using AbstractFactory.Factorys;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    
       class Application
    {
        private IAircraft aircraft;
        private ILandvehicle vehicle;

        public Application(ITransportFactory transport)
        {
            aircraft = transport.CreateTransportAircraft();
            vehicle =  transport.CreateTransportVehicle();
        }
        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
