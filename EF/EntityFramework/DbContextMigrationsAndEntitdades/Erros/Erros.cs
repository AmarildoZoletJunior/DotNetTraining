using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextMigrationsAndEntitdades.Erros
{
     class Erros : ApplicationException
    {
       public Erros(string mensagem) : base(mensagem)
        {

        }

    }
}
