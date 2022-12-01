using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_polimorfismo.Entidades
{
    class teste : ContaPoupanca
    {
        public string ola { get; set; }
        public teste(int numeroConta, string nomeUsuario, double saldo, double juros) : base(numeroConta, nomeUsuario, saldo, juros)
        {

        }
    }
}
