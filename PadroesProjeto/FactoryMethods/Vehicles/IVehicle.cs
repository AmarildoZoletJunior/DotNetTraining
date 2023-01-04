using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Vehicles
{
    public interface IVehicle
    {
        void GetCargo();
        void StartRoute();
    }
}
