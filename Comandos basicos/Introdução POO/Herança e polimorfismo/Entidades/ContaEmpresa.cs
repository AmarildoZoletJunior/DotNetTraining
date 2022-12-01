using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_e_polimorfismo.Entidades
{
    class ContaEmpresa : Conta
    {
        public double Limite { get; protected set; }

        public ContaEmpresa()
        {

        }
        public ContaEmpresa(int numeroConta, string nomeUsuario, double saldo,double limite) : base(numeroConta,nomeUsuario,saldo)
        { 
            Limite = limite;    
        }
        public void Emprestimo(double quantidade)
        {
            if(quantidade <= Limite)
            {
                Saldo += quantidade;
            }
        }


        
    }
}
