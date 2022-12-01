using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_polimorfismo.Entidades
{
    abstract class Conta
    {
        public int numeroConta { get; protected set; }
        public string NomeUsuario { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta() { }
        public Conta(int numeroConta, string nomeUsuario, double saldo)
        {
            this.numeroConta = numeroConta;
            NomeUsuario = nomeUsuario;
            Saldo = saldo;
        }

        public virtual void Sacar(double quantidade)
        {
            if(Saldo >= quantidade && quantidade >= 1)
            {
                Saldo -= quantidade + 5.0;
            }
        }
        public void Depositar(double quantidade)
        {
            if(quantidade >= 1)
            {
                Saldo += quantidade;
            }
        }
    }
}
