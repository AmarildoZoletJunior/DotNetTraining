using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
     class Vehicle
    {
        public VehicleType TipoCarro { get; set; }
        public int seats { get; set; }
        public Motor motor { get; set; }
        public Transmission transmission { get; set; }
        public string AirBags { get; set; }
    }
}
