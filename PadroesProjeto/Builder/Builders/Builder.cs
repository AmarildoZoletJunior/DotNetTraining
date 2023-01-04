using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    class Builder : IBuilder
    {
        private Vehicle _vehicle = new Vehicle();

      

        public Vehicle GetVehicle()
        {
            Vehicle Resultado = _vehicle;
            Reset();
            return Resultado;
        }

        public void Reset()
        {
            _vehicle = new Vehicle();
        }

        public void SetMotor(Motor motor)
        {
            _vehicle.motor = motor;
        }

        public void SetSeats(int seats)
        {
            _vehicle.seats = seats;
        }

        public void SetTransmission(Transmission transmission)
        {
            _vehicle.transmission = transmission;
        }

        public void SetVehicleType(VehicleType type)
        {
            _vehicle.TipoCarro = type;
        }
        public void SetAirbags(bool decisao)
        {
            if(decisao == true)
            {
                _vehicle.AirBags = "Sim";

            }
            else
            {
                _vehicle.AirBags = "Não";
            }
           
        }
    }
}
