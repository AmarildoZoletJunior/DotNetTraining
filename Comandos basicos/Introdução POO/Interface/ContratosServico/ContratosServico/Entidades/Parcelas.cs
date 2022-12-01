using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosServico.Entidades
{
    class Parcelas
    {
        public DateTime Duracao { get; set; }

        public double total { get; set; }

        public Parcelas(DateTime duracao, double total)
        {
            Duracao = duracao;
            this.total = total;
        }

        public override string ToString()
        {
            return $"{Duracao} - {total}";
        }
    }
}
