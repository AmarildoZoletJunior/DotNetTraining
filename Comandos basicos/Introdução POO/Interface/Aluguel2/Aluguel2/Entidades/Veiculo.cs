using System;

namespace Aluguel2.Entidades
{
    internal class Veiculo
    {
        public string Model { get; set; }

        public Veiculo(string model)
        {
            Model = model;
        }
    }
}
