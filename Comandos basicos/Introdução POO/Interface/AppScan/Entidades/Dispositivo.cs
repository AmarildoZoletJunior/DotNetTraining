using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppScan.Entidades
{
     abstract class Dispositivo
    {
        public string NumeroSerial { get; set; }

        public abstract void ProcessarDocumento();
    }
}
