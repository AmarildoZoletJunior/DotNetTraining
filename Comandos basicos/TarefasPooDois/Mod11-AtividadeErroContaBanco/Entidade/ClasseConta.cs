using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11_AtividadeErroContaBanco.Entidade
{
    class ClasseConta
    {
        public string Nome { get; set; }
        public int NumeroConta { get; set; }
        public double SaldoConta { get; set; }

        public ClasseConta(string nome, int numeroConta, double saldoConta)
        {
            Nome = nome;
            if (NumeroConta is int)
            {
                NumeroConta = numeroConta;
            }
            else
            {
                throw new Erros("Você deve digitar apenas numeros aqui");
            }

            if (saldoConta >= 0)
            {
                SaldoConta = saldoConta;
            }
            else
            {
                throw new Erros("O saldo da conta não pode iniciar com saldo negativo");
            }
        }
        public void Depositar(double quantidade)
        {
            if (quantidade > 0)
            {
                SaldoConta += quantidade;
            }
            else
            {
                throw new Erros("Impossivel depositar saldo negativo na conta");
            }

        }
        public void Sacar(double quantidade)
        {
            if (quantidade < SaldoConta)
            {
                SaldoConta -= quantidade;
            }
            else
            {
                throw new Erros("Impossivel retirar saldo acima do disponivel");
            }
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nNumero da conta: {NumeroConta}\nSaldo: {SaldoConta}";
        }
    }
}
