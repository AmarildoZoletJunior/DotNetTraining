using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    public class TwitchTv : IPlataform
    {
        public TwitchTv()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTv: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTv: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTv: Configurando servidor RPMTP");
        }
    }
}
