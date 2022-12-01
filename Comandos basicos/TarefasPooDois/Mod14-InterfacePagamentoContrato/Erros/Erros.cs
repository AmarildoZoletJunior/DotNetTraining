using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod14_InterfacePagamentoContrato.Erros
{
    class Errors : ApplicationException
    {
        public Errors(string mensagem) : base(mensagem)
        {
        }
    }
}
