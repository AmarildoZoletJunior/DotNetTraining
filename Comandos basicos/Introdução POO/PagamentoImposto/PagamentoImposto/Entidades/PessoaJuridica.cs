using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoImposto.Entidades
{
    class PessoaJuridica : Pessoa
    {
        public int NFuncionarios { get; set; }


        public PessoaJuridica(string nome, double renda,int funcionarios) : base(nome, renda)
        {
            NFuncionarios = funcionarios;
        }

        public override double ImpostoPago()
        {
           if(NFuncionarios >= 10)
            {
               return (16.00 / 100.00) * Renda;
            } else{
                return (14.00 / 100.00) * Renda;
            }
        }
    }
}
