using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
     interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();

        void SetSeats(int seats);

        void SetMotor(Motor motor);

        void SetTransmission(Transmission transmission);

        void SetVehicleType(VehicleType type);

        public void SetAirbags(bool decisao);

    }
}
