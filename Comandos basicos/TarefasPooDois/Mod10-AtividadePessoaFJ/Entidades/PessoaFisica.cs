using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_AtividadePessoaFJ.Entidades
{
     class PessoaFisica : Pessoa
    {
        public double GastoMedico { get; set; }
        public PessoaFisica(string nome, double rendaAnual, double gastoMedico) : base(nome, rendaAnual)
        {
            GastoMedico = gastoMedico;
        }
        public override double CalcularImposto()
        {
            if(RendaAnual < 20000.00)
            {
                if(GastoMedico > 0)
                {
                    return (RendaAnual * 0.15) - (GastoMedico / 2);
                }
                else
                {
                return RendaAnual * 0.15;
                }
            }
            else
            {
                if(GastoMedico > 0)
                {
                    return (RendaAnual * 0.20) - (GastoMedico / 2);
                }
                else
                {
                    return RendaAnual * 0.20;
                }
            }
        }
    }
}
