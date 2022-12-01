using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoImposto.Entidades
{
    internal class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }


        public PessoaFisica(string nome, double renda, double GastoSaude) : base(nome, renda)
        {
            this.GastoSaude = GastoSaude;
        }

        public override double ImpostoPago()
        {
            if (Renda >= 20000.00)
            {
                if (GastoSaude > 0)
                {
                    return ((25.00 / 100.00) * Renda) + (GastoSaude / 2);
                }
                else
                {
                    return (25.00 / 100.00) * Renda;
                }
            }
            else
            {
                if(GastoSaude > 0)
                {
                    return ((15.00 / 100.00) * Renda) + (GastoSaude / 2);
                }
                else
                {
                    return (15.00 / 100.00) * Renda;
                }
              
            }
        }
    }
}
