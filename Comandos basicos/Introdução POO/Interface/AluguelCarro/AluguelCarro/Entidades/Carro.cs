using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades
{
    class Carro
    {
        public string nome { get; set; }
        public Carro(string nome)
        {
            this.nome = nome;
        }
    }
}
