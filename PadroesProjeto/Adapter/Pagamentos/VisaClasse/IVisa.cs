using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.VisaClasse
{
    public interface IVisa
    {
        Guid GerarToken();
        void EfetuarPagamento();
        void ReceberPagamentoEmVezes(int vezes);
    }
}
