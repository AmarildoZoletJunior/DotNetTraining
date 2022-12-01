using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeErros.Entidades
{
     class ContaBancaria
    {
        public int Number { get; set; }
        public string NomeUsuario { get; set; }

        public double Balance { get; set; }

        public double LimiteSaque { get; set; }

        public ContaBancaria(int number, string nomeUsuario, double balance, double limiteSaque)
        {
            if(limiteSaque < 0 || balance < 0)
            {
                throw new Exception("Impossivel adicionar valores negativo");
            }
            Number = number;
            NomeUsuario = nomeUsuario;
            Balance = balance;
            LimiteSaque = limiteSaque;
        }

        public void Depositar(double quantidade)
        {
            if (quantidade > 0)
            {
                throw new Exception("Quantidade Não pode ser igual a 0");
            }

        }
        public void Retirar(double quantidade)
        {
            if(quantidade > Balance)
            {
                throw new Exception("Quantidade não pode ser maior que o saldo");
            }
            if(quantidade <= 1)
            {
                throw new Exception("Quantidade não pode ser menor que 0");
            }
            if(quantidade > LimiteSaque)
            {
                throw new Exception("Quantidade não pode exceder seu limite de saque");
            }
        }
    }
}
