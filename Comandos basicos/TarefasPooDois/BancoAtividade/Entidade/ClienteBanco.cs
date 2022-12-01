using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade.Entidade
{
    internal class ClienteBanco
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ClienteBanco(int id, string nome, double saldo)
        {
            Id = id;
            Nome = nome;
            Deposito(saldo);
        }
        public ClienteBanco(int id,string nome)
        {
            Id = id;
            Nome = nome;
            Saldo = 0;
        }
        public void Deposito(double quantidade)
        {
            Saldo += quantidade;
        }
        public void Saque(double quantidade)
        {
            Saldo -= quantidade + 5;
        }
        public override string ToString()
        {
            return $"Dados da conta:\nNumero:{Id}\nNome: {Nome}\nSaldo: {Saldo}\n";
        }
    }
}
