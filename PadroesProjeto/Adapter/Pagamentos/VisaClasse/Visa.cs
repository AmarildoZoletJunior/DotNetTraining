using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.VisaClasse
{
    public class Visa : IVisa
    {
        public Guid Id { get; set; }
        public void EfetuarPagamento()
        {
            if(Id == Guid.Empty)
            {
                GerarToken();
                Console.WriteLine("Estou efetuando pagamento no cartão");
            }
            Console.WriteLine("Estou efetuando pagamento no cartão");
        }

        public Guid GerarToken()
        {
            Id = Guid.NewGuid();
            return Id;
        }

        public void ReceberPagamentoEmVezes(int vezes)
        {
            if(Id == Guid.Empty)
            {
                GerarToken();
                Console.WriteLine($"Esta fazendo o pagamento em {vezes} vezes");
            }
            Console.WriteLine($"Esta fazendo o pagamento em {vezes} vezes" );
        }
    }
}
