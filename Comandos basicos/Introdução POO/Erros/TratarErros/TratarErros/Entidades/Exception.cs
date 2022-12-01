using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratarErros.Entidades
{
    class Exception : ApplicationException
    {
        public Exception(string message) : base(message)
        {

        }
    }
}
