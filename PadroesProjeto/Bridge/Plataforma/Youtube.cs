using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    public class Youtube : IPlataform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RPMTP");
        }
    }
}
