using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11_AtividadeErroContaBanco.Entidade
{
     class Erros : ApplicationException
    {
        public Erros(string mensagem) : base(mensagem)
        {

        }
    }
}
