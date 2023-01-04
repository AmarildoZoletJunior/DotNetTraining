using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    public class DLive : IPlataform
    {
        public DLive()
        {
            ConfigureRMTP();
            Console.WriteLine("Iniciando Dlive....Aguarde");
        
        }
        public void AuthToken()
        {
            Console.WriteLine("DLive: Iniciando autorização..");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RMTP");
        }
    }
}
