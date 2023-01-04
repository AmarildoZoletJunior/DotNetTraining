using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.MercadoPagoClasse
{
    class MercadoPago : IMercado
    {
        public Guid Guid { get; set; }
        public void EfetuarCompraDeProduto()
        {
            if(Guid == Guid.Empty)
            {
                GerarTokenParaRequisicao();
                Console.WriteLine($"Efetuando pagamento para Mercado Pago, Hash: {Guid}");
            }
            Console.WriteLine($"Efetuando pagamento para Mercado Pago, Hash: {Guid}");
        }

        public Guid GerarTokenParaRequisicao()
        {
            Guid = Guid.NewGuid();
            return Guid;
        }

        public void ReceberPagamentosDeVenda(int vezes)
        {
            if (Guid == Guid.Empty)
            {
                GerarTokenParaRequisicao();
                Console.WriteLine($"Recebendo saldo de venda, Hash: {Guid}, feito em {vezes} vezes");
            }
            Console.WriteLine($"Recebendo saldo de venda, Hash: {Guid}, feito em {vezes} vezes");
        }
    }
}
