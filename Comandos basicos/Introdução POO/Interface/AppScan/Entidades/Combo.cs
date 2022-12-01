using AppScan.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppScan.Entidades
{
      class Combo : Dispositivo,Scanner,Print
    {
        public string NumeroSerial { get; set; }

        public override void ProcessarDocumento()
        {
            Console.WriteLine("Processado");
        }
        public void Scanner(string documento)
        {
            Console.WriteLine("Scanneado");
        }
        public void Print(string documento)
        {
            Console.WriteLine("Printado");
        }

    }
}
