using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoImposto.Entidades
{
    abstract class Pessoa
    {
        public string Nome { get; set; }   
        public double Renda { get; set; }

        public Pessoa(string nome, double renda)
        {
            this.Nome = nome;
            this.Renda = renda;
        }

        public abstract double ImpostoPago();
    }
}
