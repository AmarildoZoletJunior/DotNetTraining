using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_polimorfismo.Entidades
{
    class ContaPoupanca : Conta
    {
        protected double Juros { get; set; }


        public ContaPoupanca()
        {

        }
        public ContaPoupanca(int numeroConta, string nomeUsuario, double saldo,double juros) : base(numeroConta, nomeUsuario, saldo) 
        {
            Juros = juros;
        }

        public void AtualizarSaldo(){
            Saldo += Saldo * Juros;
        }

        public sealed override void Sacar(double quantidade)
        {
            base.Sacar(quantidade);
            Saldo -= 2;
        }
    }
}
