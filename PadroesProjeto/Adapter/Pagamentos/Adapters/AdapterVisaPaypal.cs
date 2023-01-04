using Adapter.Pagamentos.PaypalClasse;
using Adapter.Pagamentos.VisaClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.Adapters
{
    public class AdapterVisaPaypal : IPaypal
    {
        private Visa visa;

        public AdapterVisaPaypal(Visa visa)
        {
            this.visa = visa;
        }

        public void FazerPagamento()
        {
            visa.EfetuarPagamento();
        }

        public Guid GerarToken()
        {
            return visa.GerarToken();
        }

        public void ReceberPagamento(int vezes)
        {
            visa.ReceberPagamentoEmVezes(vezes);
        }
    }
}
