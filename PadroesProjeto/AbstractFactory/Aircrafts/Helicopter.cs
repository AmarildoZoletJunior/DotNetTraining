using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos tranquilos para o sudeste");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegando passageiros");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando trajeto de decolagem");
        }
    }
}
