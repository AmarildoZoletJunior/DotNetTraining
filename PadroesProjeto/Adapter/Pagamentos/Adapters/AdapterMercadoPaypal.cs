using Adapter.Pagamentos.MercadoPagoClasse;
using Adapter.Pagamentos.PaypalClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.Adapters
{
    class AdapterMercadoPaypal : IPaypal
    {
        private MercadoPago mercado;
        public AdapterMercadoPaypal(MercadoPago mer)
        {
            mercado = mer;

        }
        public void FazerPagamento()
        {
            mercado.EfetuarCompraDeProduto();
        }

        public Guid GerarToken()
        {
            return mercado.GerarTokenParaRequisicao();
        }

        public void ReceberPagamento(int vezes)
        {
            mercado.ReceberPagamentosDeVenda(vezes);
        }
    }
}
