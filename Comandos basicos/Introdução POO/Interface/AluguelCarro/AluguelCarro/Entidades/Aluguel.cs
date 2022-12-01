using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades
{
    class Aluguel
    {
        Carro carro { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Volta { get; set; }
        public Valores tot { get; set; }


        public Aluguel(Carro carro, DateTime saida, DateTime volta)
        {
            this.carro = carro;
            Saida = saida;
            Volta = volta;

        }



    }
}
