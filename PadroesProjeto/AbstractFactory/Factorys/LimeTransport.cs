using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factorys
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Patinete();
        }
    }
}
