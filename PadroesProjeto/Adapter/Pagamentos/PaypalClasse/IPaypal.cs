using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.PaypalClasse
{
    public interface IPaypal
    {
        Guid GerarToken();
        void FazerPagamento();
        void ReceberPagamento(int vezes);
    }
}
