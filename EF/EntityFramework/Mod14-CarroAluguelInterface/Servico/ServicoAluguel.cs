using Mod14_CarroAluguelInterface.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_CarroAluguelInterface.Servico
{
    internal class ServicoAluguel
    {
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        ITaxa Taxa;
        public ServicoAluguel(double precoHora, double precoDia, ITaxa taxa)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            Taxa = taxa;
        }

 
        public void ProcessarPagamento(DatasAluguelCarro aluguel)
        {
            double PagamentoBasico = 0.0;
            TimeSpan tempoCorrido = aluguel.Fim.Subtract(aluguel.Inicio);

            if (tempoCorrido.TotalHours < 12)
            {
               PagamentoBasico = PrecoHora * Math.Ceiling(tempoCorrido.TotalHours);
            }
            else
            {
                PagamentoBasico = PrecoDia * Math.Ceiling(tempoCorrido.TotalDays);
            }
            double TaxaPrecoTotal = Taxa.QuantidadeTaxa(PagamentoBasico);
            aluguel.Pagamentos = new Pagamentos(PagamentoBasico, TaxaPrecoTotal);
        }
    }
}
