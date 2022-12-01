using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades.Services
{
    internal class AluguelValor
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITax TaxaBrasil = new TaxaBrasil();


        public AluguelValor(double Precohora,double Precodia)
        {
            PrecoDia = Precodia;
            PrecoHora = Precohora;
        }

        public void Processamento(Aluguel aluguel)
        {
            TimeSpan t = aluguel.Volta.Subtract(aluguel.Saida);
            double horasd = Math.Ceiling(t.TotalHours);
            int horas = (int)horasd;
            double pagamento;
            if (horas > 0 && horas <= 12)
            {
                pagamento =  horas * PrecoHora;

            }
            else
            {
                pagamento = horas * (PrecoDia / 24);
            }

            double taxa = TaxaBrasil.ValorTaxa(pagamento);
  
            aluguel.tot = new Valores(pagamento, taxa);
        }
        
    }
}
