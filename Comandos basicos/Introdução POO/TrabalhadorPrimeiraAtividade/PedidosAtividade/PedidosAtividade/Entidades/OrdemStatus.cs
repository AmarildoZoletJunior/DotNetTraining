using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosAtividade.Entidades
{
    enum OrdemStatus : int
    {
        PagamentoPendente,
        Processando,
        Postado,
        Entregue
    }
}
