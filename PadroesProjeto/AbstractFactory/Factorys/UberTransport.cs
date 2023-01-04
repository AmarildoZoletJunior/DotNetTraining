using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factorys
{
    internal class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
