using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
     class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedan()
        {
            builder.SetVehicleType(Components.VehicleType.Sedan);
            builder.SetMotor(new Motor(2000));
            builder.SetTransmission(Transmission.Automatic);
            builder.SetSeats(5);
            builder.SetAirbags(false);
        }

        public void ConstrutorTruck()
        {
            builder.SetVehicleType(Components.VehicleType.Truck);
            builder.SetMotor(new Motor(3000));
            builder.SetTransmission(Transmission.Manual);
            builder.SetSeats(3);
            builder.SetAirbags(false);
        }
        public void ConstrutorSUV()
        {
            builder.SetAirbags(true);
            builder.SetVehicleType(Components.VehicleType.SUV);
            builder.SetMotor(new Motor(2800));
            builder.SetTransmission(Transmission.Automatic_sequential);
            builder.SetSeats(6);
        }
    }
}
