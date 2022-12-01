using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo.Entidades
{
   class funcionario
    {
        public string Nome {  get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public funcionario(string nome, int horas, double horasTrabalhadas)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = horasTrabalhadas;
        }
        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
        public override string ToString()
        {
            return $"{Nome} - R$ {Pagamento()}";
        }
    }
}
