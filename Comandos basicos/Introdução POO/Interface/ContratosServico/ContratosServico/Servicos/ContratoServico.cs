using ContratosServico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosServico.Servicos
{
    class ContratoServico
    {
        IPagamentoOnline Pagamento;
        public ContratoServico(IPagamentoOnline pagament)
        {
            Pagamento = pagament;
        }

        public void ProcessamentoDeContrato(Contrato Contrato, int Meses)
        {
            double PagamentoBasico =  Contrato.ValorTotal / Meses;

            for (int i = 1; i <= Meses; i++)
            {
                double juros = PagamentoBasico + Pagamento.JurosMes(PagamentoBasico, i);
                double total = juros + Pagamento.TaxaPagamento(juros);
                DateTime nova = Contrato.DataInicio.AddMonths(i);
                Contrato.Parcelas.Add(new Parcelas(nova, total));
            }
        }
    }
}
