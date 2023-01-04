using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pagamentos.MercadoPagoClasse
{
    public interface IMercado
    {
        Guid GerarTokenParaRequisicao();
        void EfetuarCompraDeProduto();
        void ReceberPagamentosDeVenda(int vezes);
    }
}
