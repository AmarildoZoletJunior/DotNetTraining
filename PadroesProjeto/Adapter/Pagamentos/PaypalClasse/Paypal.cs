using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.PaypalClasse
{
    public class Paypal : IPaypal
    {
        public Guid Id { get; set; }
        public void FazerPagamento()
        {
            if (Id == Guid.Empty)
            {
                GerarToken();
                Console.WriteLine($"Efetuando pagamento, Hash:{Id}");
            }
            Console.WriteLine($"Efetuando pagamento, Hash:{Id}");
        }

        public Guid GerarToken()
        {
            Id = Guid.NewGuid();
            return Id;
        }

        public void ReceberPagamento(int vezes)
        {
            if (Id == Guid.Empty)
            {
                GerarToken();
                Console.WriteLine($"Recebendo pagamento, Hash:{Id}, em {vezes} vezes");
            }
            Console.WriteLine($"Recebendo pagamento, Hash:{Id}, em {vezes} vezes");
        }
    }
}
