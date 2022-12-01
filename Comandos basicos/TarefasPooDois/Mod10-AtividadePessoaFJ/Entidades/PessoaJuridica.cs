using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_AtividadePessoaFJ.Entidades
{
     class PessoaJuridica : Pessoa
    {
        public int NumFuncionario { get; set; }
        public PessoaJuridica(string nome, double rendaAnual,int numFuncionario) : base(nome, rendaAnual)
        {
            this.NumFuncionario = numFuncionario;
        }
        public override double CalcularImposto()
        {
            if(NumFuncionario <= 0)
            {
                throw new ApplicationException("Erro");
            }
            if(NumFuncionario <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }

        }
    }
}
