using Aluguel2.Entidades;
using System;

namespace Aluguel2.Servico
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }


        private ITaxa taxa1 { get; set; }
        public ServicoAluguel(double precoHora, double precoDia,ITaxa taxa)
        {
            taxa1 = taxa;
            PrecoHora = precoHora;
            PrecoDia = precoDia;
        }

        public void ProcessarFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duration = aluguelCarro.Finish.Subtract(aluguelCarro.Start);

            double PagamentoBasico = 0;
            if(duration.TotalHours <= 12)
            {
              PagamentoBasico =   PrecoHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                PagamentoBasico = PrecoDia * Math.Ceiling(duration.TotalDays);
            }
            double taxa = taxa1.CalcularTaxaBrasil(PagamentoBasico);

            aluguelCarro.Fatura = new Fatura(PagamentoBasico, taxa);    

           
        }
    }
}
