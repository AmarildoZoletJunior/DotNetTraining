using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factorys
{
     interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
