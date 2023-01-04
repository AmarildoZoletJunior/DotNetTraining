using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    public class FacebookLive : IPlataform
    {
        public FacebookLive()
        {
            ConfigureRMTP();
            Console.WriteLine("FacebookLive: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("FacebookLive: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("FacebookLive: Configurando servidor RPMTP");
        }
    }
}
