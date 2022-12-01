using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.Entidades
{
    class Exception : ApplicationException
    {
        public Exception(string mensagem) : base(mensagem)
        {

        }
    }
}
