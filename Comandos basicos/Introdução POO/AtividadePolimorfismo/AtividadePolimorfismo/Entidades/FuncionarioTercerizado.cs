using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo.Entidades
{
    class FuncionarioTercerizado : funcionario
    {
        public double Adicional { get; set; }

        public FuncionarioTercerizado(string nome, int horas, double horasTrabalhadas,double porcentagem) : base(nome,horas,horasTrabalhadas)
        {
            Adicional = porcentagem;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * Adicional;
        }
    }
}
